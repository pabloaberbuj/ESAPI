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
        public double valorCorrespondiente { get; set; }
        public double valorMedido { get; set; }
        public double valorEsperado { get; set; }
        public double valorTolerado { get; set; }
        public string etiqueta { get; set; }

        public int cumple()
        {
            if (esMenorQue)
            {
                if (valorMedido <= valorEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(valorTolerado) && valorMedido <= valorTolerado)
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
                if (valorMedido >= valorEsperado)
                {
                    return 0;
                }
                else if (!Double.IsNaN(valorTolerado) && valorMedido >= valorTolerado)
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
                valorCorrespondiente = _dosis,
                valorEsperado = _volumenEsperado,
                valorTolerado = _volumenTolerable,
            };
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiqueta()
        {
            etiqueta = estructura.nombre + ": ";
            etiqueta += "V" + valorCorrespondiente.ToString();
            if (!Double.IsNaN(valorEsperado))
            {
                if (esMenorQue)
                {
                    etiqueta += " < ";
                }
                else
                {
                    etiqueta += " > ";
                }
                etiqueta += valorEsperado.ToString();
                if (!Double.IsNaN(valorTolerado))
                {
                    etiqueta += " (" + valorTolerado.ToString() + ")";
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

        public void analizarPlanEstructura(PlanSetup plan, Structure estructura)
        {
            DoseValue dosis = new DoseValue();
            if (doseValuePresentation == DoseValuePresentation.Absolute)
            {
                dosis = new DoseValue(valorCorrespondiente*100, DoseValue.DoseUnit.cGy);
            }
            else
            {
                dosis = new DoseValue(valorCorrespondiente, DoseValue.DoseUnit.Percent);
            }
            valorMedido = Math.Round(plan.GetVolumeAtDose(estructura, dosis, volumePresentation),2);

        }


        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }
     }
}

