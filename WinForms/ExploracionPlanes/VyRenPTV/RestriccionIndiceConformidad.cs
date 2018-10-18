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
    public class RestriccionIndiceConformidad : IRestriccion
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
            RestriccionIndiceConformidad restriccion = new RestriccionIndiceConformidad()
            {
                estructura = _estructura,
                esMenorQue = _esMenorQue,
                valorCorrespondiente = _valorCorrespondiente, //qué isodosis busco
                valorEsperado = _valorEsperado,
                valorTolerado = _valorTolerado,
            };
            restriccion.crearEtiquetaInicio();
            restriccion.crearEtiqueta();
            return restriccion;
        }

        public void crearEtiquetaInicio()
        {
            etiquetaInicio = estructura.nombre + ": IC" + " (" + valorCorrespondiente + "%)";
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
            }
        }


        public void analizarPlanEstructura(PlanSetup plan, Structure estructura)
        {
            Structure BODY = plan.StructureSet.Structures.Where(s => s.DicomType == "EXTERNAL").FirstOrDefault();
            if (BODY == null)
            {
                MessageBox.Show("No se encuentra la estructura BODY. \nNo se puede analizar el I.C. de la estructura" + estructura.Id);
                valorMedido = Double.NaN;
            }
            else
            {
                valorCorrespondiente = valorCorrespondiente * prescripcionEstructura / 100; //Convierto el % a Gy para extraer
                DoseValue dosis = new DoseValue(valorCorrespondiente * 100, DoseValue.DoseUnit.cGy); //y acá en cGy
                MessageBox.Show("BODY: " + BODY.Id + "\n Valor Correspondiente: en Gy" + valorCorrespondiente.ToString() + "\n dosis en cGy: " + dosis.ValueAsString +
                    "\n volumen isodosis: " + plan.GetVolumeAtDose(BODY, dosis, VolumePresentation.AbsoluteCm3).ToString() + "\n volumen estructura: " + estructura.Volume.ToString());
                valorMedido = plan.GetVolumeAtDose(BODY, dosis, VolumePresentation.AbsoluteCm3)/estructura.Volume;
            }
        }

        public bool chequearSamplingCoverage(PlanSetup plan, Structure estructura)
        {
            if (Double.IsNaN(valorMedido))
            {
                if (plan.GetDVHCumulativeData(estructura, DoseValuePresentation.Absolute, VolumePresentation.Relative, 0.01).SamplingCoverage < 0.9)
                {
                    return true;
                }
            }
            return false;
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

        public void editar(ComboBox CB_Estructura, TextBox TB_nombresAlt, ComboBox CB_TipoRestr, TextBox TB_valorCorrespondiente,
     ComboBox CB_UnidadesCorresp, ComboBox CB_EsMenorQue, TextBox TB_ValorEsperado, TextBox TB_ValorTolerado, ComboBox CB_UnidadesValor)
        {
            CB_Estructura.Text = estructura.nombre;
            for (int i = 1; i < estructura.nombresPosibles.Count; i++)
            {
                if (i > 1)
                {
                    TB_nombresAlt.Text += "\r\n";
                }
                TB_nombresAlt.Text += estructura.nombresPosibles[i];
            }
            CB_TipoRestr.SelectedIndex = 4; //cambiar en cada restriccion
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
