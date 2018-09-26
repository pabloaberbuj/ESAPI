using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;


namespace ExploracionPlanes
{
    public class RestriccionDosis : IRestriccion
    {
        public Estructura estructura { get; set; }
        public string unidadValor { get; set; }
        public string unidadCorrespondiente { get; set; }
        public bool esMenorQue { get; set; }
        public double valorCorrespondiente { get; set; }
        public double valorMedido { get; set; }
        public double valorEsperado { get; set; }
        public double valorTolerado { get; set; }
        public double prescripcionEstructura { get; set; }
        public string etiquetaInicio { get; set; }
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

        public IRestriccion crear(Estructura _estructura, string _unidadValor, string _unidadCorrespondiente, bool _esMenorQue,
   double _valorEsperado, double _valorTolerado, double _valorCorrespondiente)

        {
            RestriccionDosis restriccion = new RestriccionDosis()
            {
                estructura = _estructura,
                unidadValor = _unidadValor,
                unidadCorrespondiente = _unidadCorrespondiente,
                esMenorQue = _esMenorQue,
                valorCorrespondiente = _valorCorrespondiente,
                valorEsperado = _valorEsperado,
                valorTolerado = _valorTolerado,
            };
            restriccion.crearEtiquetaInicio();
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiquetaInicio()
        {
            etiquetaInicio = estructura.nombre + ": D" + valorCorrespondiente.ToString() + unidadCorrespondiente;
        }
        public void crearEtiqueta()
        {
            etiqueta = etiquetaInicio;
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
                    etiqueta += " (" + valorTolerado.ToString() + ") ";
                }
                etiqueta += unidadValor;
            }

        }



        

        public void analizarPlanEstructura(PlanSetup plan, Structure estructura)
        {
            VolumePresentation volumePresentation;
            DoseValuePresentation doseValuePresentation = DoseValuePresentation.Absolute;
            if (unidadCorrespondiente == "%")
            {
                volumePresentation = VolumePresentation.Relative;
            }
            else
            {
                volumePresentation = VolumePresentation.AbsoluteCm3;
            }
            valorMedido = Math.Round(plan.GetDoseAtVolume(estructura, valorCorrespondiente, volumePresentation, doseValuePresentation).Dose / 100, 2);
            if (unidadValor == "%")
            {
                valorMedido = valorMedido / prescripcionEstructura * 100; //extraigo en Gy y paso a porcentaje
            }
            
        }


        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }

        public bool dosisEstaEnPorcentaje()
        {
            if (unidadValor == "%")
            {
                return true;
            }
            else
            {
                return false;
            }
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
