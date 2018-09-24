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
        public Estructura estructura { get; set; }
        public DoseValuePresentation doseValuePresentation { get; set; }
        public VolumePresentation volumePresentation { get; set; }
        public bool esMenorQue { get; set; }
        public double valorCorrespondiente { get; set; }
        public double valorMedido { get; set; }
        public double valorEsperado { get; set; }
        public double valorTolerado { get; set; }
        public double PrescripcionEstructura { get; set; }
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

        IRestriccion crear(Estructura _estructura, string _unidadValor, string _unidadCorrespondiente, bool _esMenorQue,
            double _valorEsperado, double _valorTolerado, double _valorCorrespondiente, double _prescripcionEstructura)
        {
            RestriccionDosis restriccion = new RestriccionDosis()
            {
                estructura = _estructura,
                doseValuePresentation = unidadesDosis(_unidadValor),
                volumePresentation = unidadesVolumen(_unidadCorrespondiente),
                esMenorQue = _esMenorQue,
                valorCorrespondiente = _valorCorrespondiente,
                valorEsperado = _valorEsperado,
                valorTolerado = _valorTolerado,
                PrescripcionEstructura = _prescripcionEstructura,
            };
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiqueta()
        {
            etiqueta = estructura.nombre + ": D" + valorCorrespondiente.ToString();
            
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

        public void analizarPlanEstructura (PlanSetup plan, Structure estructura)
        {
            if (doseValuePresentation == DoseValuePresentation.Absolute)
            {
                valorMedido = Math.Round(plan.GetDoseAtVolume(estructura, valorCorrespondiente, volumePresentation, doseValuePresentation).Dose / 100, 2);
            }
            else
            {
                valorMedido = Math.Round(plan.GetDoseAtVolume(estructura, valorCorrespondiente, volumePresentation, doseValuePresentation).Dose, 2);
            }
                
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
