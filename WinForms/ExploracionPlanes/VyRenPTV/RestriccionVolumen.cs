using System;
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
        public Estructura estructura { get; set; }
        public List<string> estructuraNombresPosibles { get; set; }
        public DoseValuePresentation doseValuePresentation { get; set; }
        public VolumePresentation volumePresentation { get; set; }
        public bool esMenorQue { get; set; }
        public double Dosis { get; set; }
        public double VolumenMedido { get; set; }
        public double VolumenEsperado { get; set; }
        public double VolumenTolerable { get; set; }
        public string etiqueta { get; set; }

        public int cumple()
        {
            if (esMenorQue)
            {
                if (VolumenMedido <= VolumenEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(VolumenTolerable) && VolumenMedido <= VolumenTolerable)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
            else
            {
                if (VolumenMedido >= VolumenEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(VolumenTolerable) && VolumenMedido >= VolumenTolerable)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }
        public static IRestriccion crear(Estructura _estructura, string _unidadDosis, string _unidadVolumen, bool _esMenorQue,
            double _volumenEsperado, double _volumenTolerable, double _dosis)
        {
            RestriccionVolumen restriccion = new RestriccionVolumen()
            {
                estructura = _estructura,
                doseValuePresentation = unidadesDosis(_unidadDosis),
                volumePresentation = unidadesVolumen(_unidadVolumen),
                esMenorQue = _esMenorQue,
                Dosis = _dosis,
                VolumenEsperado = _volumenEsperado,
                VolumenTolerable = _volumenTolerable,
            };
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiqueta()
        {
            etiqueta = estructura.nombre + ": ";
            etiqueta += "V" + Dosis.ToString();
            if (!Double.IsNaN(VolumenEsperado))
            {
                if (esMenorQue)
                {
                    etiqueta += " < ";
                }
                else
                {
                    etiqueta += " > ";
                }
                etiqueta += VolumenEsperado.ToString();
                if (!Double.IsNaN(VolumenTolerable))
                {
                    etiqueta += " (" + VolumenTolerable.ToString() + ")";
                }
                if (volumePresentation == VolumePresentation.Relative)
                {
                    etiqueta += "%";
                }
                else
                {
                    etiqueta += "cm3";
                }
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

        public int analizarPlanEstructura(PlanSetup plan, Structure estructura)
        {
            DoseValue dosis = new DoseValue(Dosis, DoseValue.DoseUnit.Gy);
            VolumenMedido = plan.GetVolumeAtDose(estructura, dosis, volumePresentation);
            return cumple();
        }

        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }
    }
}

