using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class RestriccionDosisMax : IRestriccion
    {
        public Estructura estructura { get; set; }
        public DoseValuePresentation doseValuePresentation { get; set; }
        public bool esMenorQue { get; set; }
        public double DosisMedida { get; set; }
        public double DosisEsperada { get; set; }
        public double DosisTolerable { get; set; }
        public double PrescripcionEstructura { get; set; }
        public string etiqueta { get; set; }

        public int cumple()
        {
            if (esMenorQue)
            {
                if (DosisMedida <= DosisEsperada)
                {
                    return 0;
                }
                else if (!Double.IsNaN(DosisTolerable) && DosisMedida <= DosisTolerable)
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
                if (DosisMedida >= DosisEsperada)
                {
                    return 0;
                }
                else if (!Double.IsNaN(DosisTolerable) && DosisMedida >= DosisTolerable)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static IRestriccion crear(Estructura _estructura, string _unidadDosis, bool _esMenorQue,
    double _dosisEsperada, double _dosisTolerable, double _prescripcionEstructura = Double.NaN)
        {
            RestriccionDosisMax restriccion = new RestriccionDosisMax()
            {
                estructura = _estructura,
                doseValuePresentation = unidadesDosis(_unidadDosis),
                esMenorQue = _esMenorQue,
                DosisEsperada = _dosisEsperada,
                DosisTolerable = _dosisTolerable,
                PrescripcionEstructura = _prescripcionEstructura,
            };
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiqueta()
        {
            etiqueta = estructura.nombre + ": Dmax";
            if (!Double.IsNaN(DosisEsperada))
            {
                if (esMenorQue)
                {
                    etiqueta += " < ";
                }
                else
                {
                    etiqueta += " > ";
                }
                etiqueta += DosisEsperada.ToString();
                if (!Double.IsNaN(DosisTolerable))
                {
                    etiqueta += " (" + DosisTolerable.ToString() + ")";
                }
                if (doseValuePresentation == DoseValuePresentation.Absolute)
                {
                    etiqueta += "Gy";
                }
                else
                {
                    etiqueta += "% (donde 100% =" + PrescripcionEstructura.ToString() + "Gy)";
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

        public  int analizarPlanEstructura(PlanSetup plan, Structure estructura) //Ver cuál sirve
        {
            //DosisMedida = plan.GetDVHCumulativeData(estructura, doseValuePresentation, VolumePresentation.Relative, 0.1).MaxDose.Dose;
            DosisMedida = plan.GetDoseAtVolume(estructura, 0.000001, VolumePresentation.AbsoluteCm3, doseValuePresentation).Dose; 
            return cumple();
        }

        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }

        /*   public void editar(IRestriccion restriccion, string Estructura, List<string> nombresAlt, int tipoRest, double valorCorresp, bool esMenor, double valorEsperado, double valorTolerado, string unidadCorresp, string unidadEsperado)
           {
               Estructura = ((RestriccionDosis)restriccion).estructura;
               nombresAlt = ((RestriccionDosis)restriccion).estructuraNombresPosibles;
               nombresAlt.Remove(((RestriccionDosis)restriccion).estructura);
               if (esDosisMedia)
               {
                   tipoRest = 1;
               }
               else if (esDosisMaxima)
               {
                   tipoRest = 2;
               }
               else
               {
                   tipoRest = 0;
               }
               esMenor = ((RestriccionDosis)restriccion).esMenorQue;
               valorCorresp = ((RestriccionDosis)restriccion).Volumen;
               DosisEsperada = ((RestriccionDosis)restriccion).DosisEsperada;
               DosisMedida = ((RestriccionDosis)restriccion).DosisMedida;



           }*/
    }
}


