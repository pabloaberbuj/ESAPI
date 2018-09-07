﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class RestriccionVolumen : IRestriccion
    {
        public string estructura { get; set; }
        public DoseValuePresentation doseValuePresentation { get; set; }
        public VolumePresentation volumePresentation { get; set; }
        public bool esMenorQue { get; set; }
        public double Dosis { get; set; }
        public double VolumenMedido { get; set; }
        public double VolumenEsperado { get; set; }
        public string etiqueta { get; set; }

        public static bool cumple(RestriccionVolumen restriccionVolumen)
        {
            if (restriccionVolumen.esMenorQue)
            {
                return restriccionVolumen.VolumenMedido <= restriccionVolumen.VolumenEsperado;
            }
            else
            {
                return restriccionVolumen.VolumenMedido >= restriccionVolumen.VolumenEsperado;
            }
        }

        public static RestriccionVolumen crear(string _estructura, string _unidadDosis, string _unidadVolumen, bool _esMenorQue,
            double _volumenEsperado, double _dosis)
        {
            RestriccionVolumen restriccion = new RestriccionVolumen()
            {
                estructura = _estructura,
                doseValuePresentation = unidadesDosis(_unidadDosis),
                volumePresentation = unidadesVolumen(_unidadVolumen),
                esMenorQue = _esMenorQue,
                Dosis = _dosis,
                VolumenEsperado = _volumenEsperado,
            };
            crearEtiqueta(restriccion);
            return restriccion;
        }

        public static void crearEtiqueta(RestriccionVolumen restriccion)
        {
            restriccion.etiqueta = restriccion.estructura + ": ";
            restriccion.etiqueta += "V" + restriccion.Dosis.ToString();
            if (restriccion.esMenorQue)
            {
                restriccion.etiqueta += " < ";
            }
            else
            {
                restriccion.etiqueta += " > ";
            }
            restriccion.etiqueta += restriccion.VolumenEsperado.ToString();
            if (restriccion.volumePresentation == VolumePresentation.Relative)
            {
                restriccion.etiqueta += "%";
            }
            else
            {
                restriccion.etiqueta += "cm3";
            }
        }

        public static DoseValuePresentation unidadesDosis(string unidad)
        {
            if (unidad == "Gy")
            {
                return DoseValuePresentation.Absolute;
            }
            else
            {
                return DoseValuePresentation.Relative;
            }
        }

        public static VolumePresentation unidadesVolumen(string unidad)
        {
            if (unidad == "%")
            {
                return VolumePresentation.Relative;
            }
            else
            {
                return VolumePresentation.AbsoluteCm3;
            }
        }

        public static bool analizarPlanEstructura(RestriccionVolumen restriccion, PlanSetup plan, Structure estructura)
        {
            DoseValue dosis = new DoseValue(restriccion.Dosis, DoseValue.DoseUnit.Gy);
            restriccion.VolumenMedido = plan.GetVolumeAtDose(estructura, dosis, restriccion.volumePresentation);
            return cumple(restriccion);
        }

        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }
    }
}
