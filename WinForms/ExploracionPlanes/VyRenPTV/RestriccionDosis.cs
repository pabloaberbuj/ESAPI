using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class RestriccionDosis: IRestriccion
    {
        string estructura { get; set; }
        DoseValuePresentation doseValuePresentation { get; set; }
        VolumePresentation volumePresentation { get; set; }
        bool esDosisMaxima { get; set; }
        bool esDosisMedia { get; set; }
        bool esMenorQue { get; set; }
        double Volumen { get; set; }
        double DosisMedida { get; set; }
        double DosisEsperada { get; set; }
        string etiqueta { get; set; }
        
        public static bool cumple(RestriccionDosis restriccionDosis)
        {
            if (restriccionDosis.esMenorQue)
            {
                return restriccionDosis.DosisMedida <= restriccionDosis.DosisEsperada;
            }
            else
            {
                return restriccionDosis.DosisMedida >= restriccionDosis.DosisEsperada; 
            }
        }

        public static RestriccionDosis crear(string _estructura, string _unidadDosis, string _unidadVolumen, bool _esDosisMaxima, bool _esDosisMedia, bool _esMenorQue,
            double _dosisEsperada, double _volumen = Double.NaN)
        {
            RestriccionDosis restriccion = new RestriccionDosis()
            {
                estructura = _estructura,
                doseValuePresentation = unidadesDosis(_unidadDosis),
                volumePresentation = unidadesVolumen(_unidadVolumen),
                esDosisMaxima = _esDosisMaxima,
                esDosisMedia = _esDosisMedia,
                esMenorQue = _esMenorQue,
                Volumen = _volumen,
                DosisEsperada = _dosisEsperada,
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
            if (restriccion.esMenorQue)
            {
                restriccion.etiqueta += " < ";
            }
            else
            {
                restriccion.etiqueta += " > ";
            }
            restriccion.etiqueta += restriccion.DosisEsperada.ToString();
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

        public static bool analizarPlanEstructura (RestriccionDosis restriccion, PlanSetup plan, Structure estructura)
        {
            restriccion.DosisMedida = plan.GetDoseAtVolume(estructura, restriccion.Volumen, restriccion.volumePresentation, restriccion.doseValuePresentation).Dose;
            return cumple(restriccion);
        }

        public void agregarALista(List<IRestriccion> lista)
        {
            lista.Add(this);
        }
    }
}
