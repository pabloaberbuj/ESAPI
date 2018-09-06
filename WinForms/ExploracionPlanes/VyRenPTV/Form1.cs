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
            return TB_Estructura.Text;
        }
        private double volumenCorrespondiente()
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

        private Plantilla plantillaActual()
        {
            return Plantilla.crear(nombrePlantilla(),listaRestricciones);
        }

        private double dosisEsperada()
        {
            return Convert.ToDouble(TB_ValorEsperado.Text);
        }

        private string unidadDosis()
        {
            return CB_ValorEsperadoUnidades.SelectedText;
        }

        private string unidadVolumen()
        {
            return CB_CorrespAUnidades.SelectedText;
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
            cb.Items.Add("Gy");
            cb.Items.Add("%");
        }

        private void cargarUnidadesVolumen(ComboBox cb)
        {
            cb.Items.Add("%");
            cb.Items.Add("cm3");
        }
        private void BT_AgregarALista_Click(object sender, EventArgs e)
        {
            if (!esRestriccionVolumen())
            {
                restriccionActual().agregarALista(listaRestricciones);
                limpiar();
            }
            else
            {

            }
        }

        private void actualizarPorRestriccion()
        {
            if(esRestriccionDosis())
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
                return RestriccionDosis.crear(estructura(), unidadDosis(), unidadVolumen(), esRestriccionDmax(), esRestriccionDmedia(), esMenorQue(), dosisEsperada(), volumenCorrespondiente());
            }
            else
            {
                return new RestriccionDosis(); //Acá iría restriccionVolumen
            }
                
        }

        private void CB_TipoRestriccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            actualizarPorRestriccion();
        }

        private void limpiar()
        {
            TB_Estructura.Clear();
            TB_CorrespA.Clear();
            TB_ValorEsperado.Clear();
            CB_MenorOMayor.SelectedIndex = 0;
            CB_TipoRestriccion.SelectedIndex = 0;
            CB_CorrespAUnidades.SelectedIndex = -1;
            CB_ValorEsperadoUnidades.SelectedIndex = 0;
        }

        private void BT_GuardarPlantilla_Click(object sender, EventArgs e)
        {
            Plantilla.guardar(plantillaActual());
        }
    }
}
