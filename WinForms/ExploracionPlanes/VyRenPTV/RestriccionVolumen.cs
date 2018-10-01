using System;
using System.Windows.Forms;
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
            RestriccionVolumen restriccion = new RestriccionVolumen()
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
            etiquetaInicio = estructura.nombre + ": " + "V" + valorCorrespondiente.ToString() + unidadCorrespondiente;
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
            if (unidadCorrespondiente == "%")
            {
                valorCorrespondiente = valorCorrespondiente * prescripcionEstructura / 100; //Convierto el % a Gy para extraer
            }
            DoseValue dosis = new DoseValue(valorCorrespondiente * 100, DoseValue.DoseUnit.cGy);
            
            if (unidadValor == "%")
            {
                volumePresentation = VolumePresentation.Relative;
            }
            else
            {
                volumePresentation = VolumePresentation.AbsoluteCm3;
            }
            valorMedido = Math.Round(plan.GetVolumeAtDose(estructura, dosis, volumePresentation), 2);
        }


        public void agregarALista(BindingList<IRestriccion> lista)
        {
            lista.Add(this);
        }

        public bool dosisEstaEnPorcentaje()
        {
            if (unidadCorrespondiente == "%")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void editar(ComboBox CB_Estructura, TextBox TB_nombresAlt, ComboBox CB_TipoRestr, TextBox TB_valorCorrespondiente,
        ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, TextBox TB_ValorEsperado, TextBox TB_ValorTolerado, ComboBox CB_UnidadesValor)
        {
            CB_Estructura.Text = estructura.nombre;
            for (int i = 1; i < estructura.nombresPosibles.Count; i++)
            {
                TB_nombresAlt.Text += "\r\n" + estructura.nombresPosibles[i];
            }
            CB_TipoRestr.SelectedIndex = 3; //cambiar en cada restriccion
            TB_valorCorrespondiente.Text = valorCorrespondiente.ToString();
            if (esMenorQue)
            {
                CB_EsMenorQue.SelectedIndex = 0;
            }
            else
            {
                CB_EsMenorQue.SelectedIndex = 1;
            }
            TB_ValorEsperado.Text = valorEsperado.ToString();
            TB_ValorTolerado.Text = valorTolerado.ToString();
        }

    }
}

