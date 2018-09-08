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



        public Form1()
        {
            InitializeComponent();
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            LB_listaRestricciones.DataSource = listaRestricciones;
            LB_listaRestricciones.DisplayMember = "etiqueta";


        }

        private string estructura()
        {
            return CB_Estructura.Text;
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
        private double volumenCorrespondiente()
        {
            if (!esRestriccionVolumen() && !string.IsNullOrEmpty(TB_CorrespA.Text))
            {
                return Convert.ToDouble(TB_CorrespA.Text);
            }
            else
            {
                return Double.NaN;
            }
        }

        private double dosisCorrespondiente()
        {
            if (esRestriccionVolumen() && !string.IsNullOrEmpty(TB_CorrespA.Text))
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

        private Plantilla plantillaActual()
        {
            return Plantilla.crear(nombrePlantilla(), listaRestricciones);
        }

        private double dosisEsperada()
        {
            if (!esRestriccionVolumen())
            {
                return Convert.ToDouble(TB_ValorEsperado.Text);
            }
            else
            {
                return Double.NaN;
            }

        }

        private double volumenEsperado()
        {
            if (esRestriccionVolumen())
            {
                return Convert.ToDouble(TB_ValorEsperado.Text);
            }
            else
            {
                return Double.NaN;
            }
        }

        private string unidadDosis()
        {
            if (esRestriccionVolumen())
            {
                return CB_CorrespAUnidades.Text;
            }
            else
            {
                return CB_ValorEsperadoUnidades.Text;
            }
        }

        private string unidadVolumen()
        {
            if (esRestriccionVolumen())
            {
                return CB_ValorEsperadoUnidades.Text;
            }
            else
            {
                return CB_CorrespAUnidades.Text;
            }
        }

        private double PrescripcionEstructura()
        {
            if (unidadDosis() == "%")
            {
                return Convert.ToDouble(CB_PrescripcionEstructura.Text);
            }
            else
            {
                return Double.NaN;
            }
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
            CB_Estructura.Items.Add(estructura());
            CB_PrescripcionEstructura.Items.Add(PrescripcionEstructura());
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
                CB_ValorEsperadoUnidades.SelectedIndex = 0;
                CB_CorrespAUnidades.SelectedIndex = 0;
            }
        }
        private IRestriccion restriccionActual()
        {
            if (!esRestriccionVolumen())
            {
                return RestriccionDosis.crear(estructura(), estructuraNombresAlt(), unidadDosis(), unidadVolumen(), esRestriccionDmax(), esRestriccionDmedia(), esMenorQue(), dosisEsperada(), volumenCorrespondiente(), PrescripcionEstructura());
            }
            else
            {
                return RestriccionVolumen.crear(estructura(), estructuraNombresAlt(), unidadDosis(), unidadVolumen(), esMenorQue(), volumenEsperado(), dosisCorrespondiente());
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
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            CB_CorrespAUnidades.SelectedIndex = 0;
            CB_ValorEsperadoUnidades.SelectedIndex = 0;
        }

        private void limpiarPlantilla()
        {
            limpiarPrescripcion();
            CB_Estructura.Items.Clear();
            CB_PrescripcionEstructura.Items.Clear();
            listaRestricciones.Clear();
            TB_NombrePlantilla.Clear();
        }
        private void BT_GuardarPlantilla_Click(object sender, EventArgs e)
        {
            Plantilla.guardar(plantillaActual());
            limpiarPlantilla();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plantilla.leerPlantillas();
        }

        private void CB_ValorEsperadoUnidades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_ValorEsperadoUnidades.Text == "%" && !esRestriccionVolumen())
            {
                GB_PrescripcionEstructura.Visible = true;
            }
            else
            {
                GB_PrescripcionEstructura.Visible = false;
            }
        }

        private void BT_EliminarRestriccion_Click(object sender, EventArgs e)
        {
            List<IRestriccion> listaAEliminar = LB_listaRestricciones.SelectedItems.OfType<IRestriccion>().ToList();
            foreach (IRestriccion item in listaAEliminar)
            {
                listaRestricciones.Remove(item);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            estructuraNombresAlt();
        }

        private void CB_Estructura_TextChanged(object sender, EventArgs e)
        {
            TB_EstructuraNombresAlt.Clear();
        }
    }
}
