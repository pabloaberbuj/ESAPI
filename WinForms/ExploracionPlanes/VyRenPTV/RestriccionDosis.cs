using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;


namespace ExploracionPlanes
{
    public class RestriccionDosis: IRestriccion
    {
        public string estructura { get; set; }
        public List<string> estructuraNombresPosibles { get; set; }
        public DoseValuePresentation doseValuePresentation { get; set; }
        public VolumePresentation volumePresentation { get; set; }
        public bool esDosisMaxima { get; set; }
        public bool esDosisMedia { get; set; }
        public bool esMenorQue { get; set; }
        public double Volumen { get; set; }
        public double DosisMedida { get; set; }
        public double DosisEsperada { get; set; }
        public double DosisTolerable { get; set; }
        public double PrescripcionEstructura { get; set; }
        public string etiqueta { get; set; }
        
        public static int cumple(RestriccionDosis restriccionDosis)
        {
            if (restriccionDosis.esMenorQue)
            {
                if (restriccionDosis.DosisMedida <= restriccionDosis.DosisEsperada)
                {
                    return 0;
                }
                else if (!Double.IsNaN(restriccionDosis.DosisTolerable) && restriccionDosis.DosisMedida <= restriccionDosis.DosisTolerable)
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
                if (restriccionDosis.DosisMedida >= restriccionDosis.DosisEsperada)
                {
                    return 0;
                }
                else if (!Double.IsNaN(restriccionDosis.DosisTolerable) && restriccionDosis.DosisMedida >= restriccionDosis.DosisTolerable)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static RestriccionDosis crear(string _estructura, List<string> _estructuraNombresAlternativos, string _unidadDosis, string _unidadVolumen, bool _esDosisMaxima, bool _esDosisMedia, bool _esMenorQue,
            double _dosisEsperada, double _dosisTolerable, double _volumen = Double.NaN, double _prescripcionEstructura= Double.NaN)
        {
            List<string> nombresPosibles = _estructuraNombresAlternativos;
            nombresPosibles.Insert(0, _estructura);
            RestriccionDosis restriccion = new RestriccionDosis()
            {
                estructura = _estructura,
                estructuraNombresPosibles = nombresPosibles,
                doseValuePresentation = unidadesDosis(_unidadDosis),
                volumePresentation = unidadesVolumen(_unidadVolumen),
                esDosisMaxima = _esDosisMaxima,
                esDosisMedia = _esDosisMedia,
                esMenorQue = _esMenorQue,
                Volumen = _volumen,
                DosisEsperada = _dosisEsperada,
                DosisTolerable = _dosisTolerable,
                PrescripcionEstructura = _prescripcionEstructura,
            };
            crearEtiqueta(restriccion);
            return restriccion;

        }

        public static void crearEtiqueta(RestriccionDosis restriccion)
        {
            restriccion.etiqueta = restriccion.estructura + ": ";
            if (restriccion.esDosisMaxima)
            {
                restriccion.etiqueta += "Dmax";
            }
            else if (restriccion.esDosisMedia)
            {
                restriccion.etiqueta += "Dmedia";
            }
            else
            {
                restriccion.etiqueta += "D" + restriccion.Volumen.ToString();
            }
            if (!Double.IsNaN(restriccion.DosisEsperada))
            {
                if (restriccion.esMenorQue)
                {
                    restriccion.etiqueta += " < ";
                }
                else
                {
                    restriccion.etiqueta += " > ";
                }
                restriccion.etiqueta += restriccion.DosisEsperada.ToString();
                if (!Double.IsNaN(restriccion.DosisTolerable))
                {
                    restriccion.etiqueta += " (" + restriccion.DosisTolerable.ToString() + ")";
                }
                if (restriccion.doseValuePresentation == DoseValuePresentation.Absolute)
                {
                    restriccion.etiqueta += "Gy";
                }
                else
                {
                    restriccion.etiqueta += "% (donde 100% =" + restriccion.PrescripcionEstructura.ToString() + "Gy)";
                }
            }
            
        }

        

        public static DoseValuePresentation unidadesDosis(string unidad)
        {
            if (unidad=="Gy")
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
            if (unidad=="%")
            {
                return VolumePresentation.Relative;
            }
            else
            {
                return VolumePresentation.AbsoluteCm3;
            }
        }

        public static int analizarPlanEstructura (RestriccionDosis restriccion, PlanSetup plan, Structure estructura)
        {
            restriccion.DosisMedida = plan.GetDoseAtVolume(estructura, restriccion.Volumen, restriccion.volumePresentation, restriccion.doseValuePresentation).Dose;
            return cumple(restriccion);
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
