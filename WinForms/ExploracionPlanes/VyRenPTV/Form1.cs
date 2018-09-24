using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExploracionPlanes
{
    public partial class Form1 : Form
    {

        BindingList<IRestriccion> listaRestricciones = new BindingList<IRestriccion>();



        public Form1(Main main, bool edita)
        {
            InitializeComponent();
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            LB_listaRestricciones.DataSource = listaRestricciones;
            LB_listaRestricciones.DisplayMember = "etiqueta";


        }

        private Estructura estructura()
        {
            return Estructura.crear(CB_Estructura.Text, estructuraNombresAlt());
        }

        private List<string> estructuraNombresAlt()
        {
            if (!string.IsNullOrEmpty(TB_EstructuraNombresAlt.Text))
            {
                return Regex.Split(TB_EstructuraNombresAlt.Text, "\r\n").ToList<string>();
            }
            else
            {
                return new List<string>();
            }
        }
        private double valorCorrespondiente()
        {
            if (!string.IsNullOrEmpty(TB_CorrespA.Text))
            {
                return Convert.ToDouble(TB_CorrespA.Text);
            }
            else
            {
                return Double.NaN;
            }
        }

        private string nombrePlantilla()
        {
            return TB_NombrePlantilla.Text;
        }

        private bool esParaExtraccion()
        {
            return CHB_esParaExtraccion.Checked;
        }

        private Plantilla plantillaActual()
        {
            return Plantilla.crear(nombrePlantilla(), esParaExtraccion(), listaRestricciones);
        }

        private double valorEsperado()
        {
            if (!String.IsNullOrEmpty(TB_ValorEsperado.Text))
            {
                return Convert.ToDouble(TB_ValorEsperado.Text);
            }
            else
            {
                return Double.NaN;
            }
        }

        private double valorTolerado()
        {
            if (!String.IsNullOrEmpty(TB_ValorTolerado.Text))
            {
                return Convert.ToDouble(TB_ValorTolerado.Text);
            }
            else
            {
                return Double.NaN;
            }
        }
        private string unidadValor()
        {
            return CB_ValorEsperadoUnidades.Text;
        }

        private string unidadCorrespondiente()
        {
            return CB_CorrespAUnidades.Text;
        }

        private bool esRestriccionDosis()
        {
            return CB_TipoRestriccion.SelectedIndex == 0;
        }

        private bool esRestriccionDmedia()
        {
            return CB_TipoRestriccion.SelectedIndex == 1;
        }

        private bool esRestriccionDmax()
        {
            return CB_TipoRestriccion.SelectedIndex == 2;
        }

        private bool esRestriccionVolumen()
        {
            return CB_TipoRestriccion.SelectedIndex == 3;
        }

        private bool esMenorQue()
        {
            return CB_MenorOMayor.SelectedIndex == 0;
        }

        private void cargarUnidadesDosis(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("Gy");
            cb.Items.Add("%");
        }

        private void cargarUnidadesVolumen(ComboBox cb)
        {
            cb.Items.Clear();
            cb.Items.Add("%");
            cb.Items.Add("cm3");
        }
        private void BT_AgregarALista_Click(object sender, EventArgs e)
        {
            restriccionActual().agregarALista(listaRestricciones);
            limpiarPrescripcion();
            if (!CB_Estructura.Items.Contains(estructura().nombre))
            {
                CB_Estructura.Items.Add(estructura().nombre);
            }
            fijarEsParaExtraccion();

        }

        private void actualizarPorRestriccion()
        {
            if (esRestriccionDosis())
            {
                L_CorrespA.Text = "correspondiente a \nun volumen de: ";
                L_CorrespA.Visible = true;
                TB_CorrespA.Visible = true;
                CB_CorrespAUnidades.Visible = true;
                cargarUnidadesDosis(CB_ValorEsperadoUnidades);
                cargarUnidadesDosis(CB_ValorToleradoUnidades);
                cargarUnidadesVolumen(CB_CorrespAUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_CorrespAUnidades.SelectedIndex = 0;
            }
            else if (esRestriccionDmedia() || esRestriccionDmax())
            {
                L_CorrespA.Visible = false;
                TB_CorrespA.Visible = false;
                CB_CorrespAUnidades.Visible = false;
                cargarUnidadesDosis(CB_ValorEsperadoUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
            }
            else
            {
                L_CorrespA.Text = "correspondiente a \nuna dosis de: ";
                L_CorrespA.Visible = true;
                TB_CorrespA.Visible = true;
                CB_CorrespAUnidades.Visible = true;
                cargarUnidadesDosis(CB_CorrespAUnidades);
                cargarUnidadesVolumen(CB_ValorEsperadoUnidades);
                cargarUnidadesVolumen(CB_ValorToleradoUnidades);
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_CorrespAUnidades.SelectedIndex = 0;
            }
        }
        private IRestriccion restriccionActual()
        {
            if (esRestriccionDosis())
            {
                return new RestriccionDosis().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(), valorTolerado(), valorCorrespondiente());
            }
            else if (esRestriccionDmedia())
            {
                return new RestriccionDosisMedia().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(), valorTolerado(), valorCorrespondiente());
            }
            else if (esRestriccionDmax())
            {
                return new RestriccionDosisMax().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(), valorTolerado(), valorCorrespondiente());
            }
            else //esRestriccionVolumen
            {
                return new RestriccionVolumen().crear(estructura(), unidadValor(), unidadCorrespondiente(), esMenorQue(), valorEsperado(), valorTolerado(), valorCorrespondiente());
            }

        }

        private void CB_TipoRestriccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPorRestriccion();
            CB_ValorEsperadoUnidades_SelectedIndexChanged(sender, e);
        }

        private void limpiarPrescripcion()
        {
            TB_CorrespA.Clear();
            TB_ValorEsperado.Clear();
            TB_ValorTolerado.Clear();
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            CB_CorrespAUnidades.SelectedIndex = 0;
            CB_ValorEsperadoUnidades.SelectedIndex = 0;
        }

        private void limpiarPlantilla()
        {
            limpiarPrescripcion();
            CB_Estructura.Items.Clear();
            listaRestricciones.Clear();
            TB_NombrePlantilla.Clear();
            fijarEsParaExtraccion();
        }
        private void BT_GuardarPlantilla_Click(object sender, EventArgs e)
        {
            Plantilla.guardar(plantillaActual());
            limpiarPlantilla();
        }

        private void CB_ValorEsperadoUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            CB_ValorToleradoUnidades.SelectedIndex = CB_ValorEsperadoUnidades.SelectedIndex;
        }

        private void BT_EliminarRestriccion_Click(object sender, EventArgs e)
        {
            List<IRestriccion> listaAEliminar = LB_listaRestricciones.SelectedItems.OfType<IRestriccion>().ToList();
            foreach (IRestriccion item in listaAEliminar)
            {
                listaRestricciones.Remove(item);
            }
            fijarEsParaExtraccion();
        }

        private void CB_Estructura_TextChanged(object sender, EventArgs e)
        {
            TB_EstructuraNombresAlt.Clear();
        }

        private void CHB_esParaExtraccion_CheckedChanged(object sender, EventArgs e)
        {
            if (esParaExtraccion())
            {
                Panel_esMenorque.Visible = false;
            }
            else
            {
                Panel_esMenorque.Visible = true;
            }
        }

        private void fijarEsParaExtraccion()
        {
            if (LB_listaRestricciones.Items.Count > 0)
            {
                CHB_esParaExtraccion.Enabled = false;
            }
            else
            {
                CHB_esParaExtraccion.Enabled = true;
            }
        }

    }
}
