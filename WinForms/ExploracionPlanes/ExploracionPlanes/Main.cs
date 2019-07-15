using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;

namespace ExploracionPlanes
{
    public partial class Main : Form
    {
        public Form1 crearPlantilla;
        //public PruebaImprimir aplicarPlantilla;
        public Form2 aplicarPlantilla;
        public Form3 aplicarPorLote;
        public PlantillaBlanco plantillaBlanco;
        bool hayContext = false;
        bool editaPlantilla = false;
        Patient pacienteContext = null;
        PlanningItem planContext = null;
        User usuarioContext = null;
        IEnumerable<PlanSum> planSumsContext = null;
        string texto = "";

        public Main(bool _hayContext = false, Patient _pacienteContext = null, PlanningItem _planContext = null, User _usuarioContext = null, IEnumerable<PlanSum> _planSumsContext = null)
        {
            InitializeComponent();
            leerPlantillas();
            hayContext = _hayContext;
            pacienteContext = _pacienteContext;
            planContext = _planContext;
            usuarioContext = _usuarioContext;
            planSumsContext = _planSumsContext;
            habilitarBotones();
            if (hayContext && planContext != null)
            {
                texto += Chequeos.chequeos(planContext, false);
                if (texto != "")
                {
                    if (MessageBox.Show(texto, "Chequeos en plan actual") == DialogResult.OK)
                    {

                    }
                }
                else
                {
                    if (MessageBox.Show("Todo bien", "Chequeos en plan actual") == DialogResult.OK)
                    {

                    }
                }
            }
            else if (hayContext && pacienteContext == null)
            {
                MessageBox.Show("Debe abrir un paciente");
                this.Close();
            }
            else if (hayContext && planContext == null)
            {
                if (_planSumsContext != null)
                {
                    PlanesSumaContext planesSumaContext = new PlanesSumaContext(planSumsContext);
                    planesSumaContext.ShowDialog();
                    planContext = planesSumaContext.PlanSuma;
                    texto += Chequeos.chequeos(planContext, true);
                    if (texto != "")
                    {
                        if (MessageBox.Show(texto, "Chequeos en plan actual") == DialogResult.OK)
                        {

                        }
                    }
                    else
                    {
                        if (MessageBox.Show("Todo bien", "Chequeos en plan actual") == DialogResult.OK)
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un plan");
                    this.Close();
                }

            }
            else
            {
                /*MessageBox.Show("Se va a hacer el chequeo");
                texto += Chequeos.chequeos(planContext, false);
                if (texto != "")
                {
                    MessageBox.Show(texto, "Chequeos en plan actual");
                }
                else
                {
                    MessageBox.Show("Todo bien", "Chequeos en plan actual");
                }*/
            }

        }

        private void BT_Nueva_Click(object sender, EventArgs e)
        {
            crearPlantilla = new Form1(this, false);
            crearPlantilla.ShowDialog();
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            crearPlantilla = new Form1(this, true);
            crearPlantilla.ShowDialog();

        }

        private void BT_AplicarAUnPlan_Click(object sender, EventArgs e)
        {
            //aplicarPlantilla = new PruebaImprimir(plantillaSeleccionada());
            aplicarPlantilla = new Form2(plantillaSeleccionada(), hayContext, pacienteContext, planContext, usuarioContext);
            aplicarPlantilla.ShowDialog();
            if (hayContext)
            {
                aplicarPlantilla.Dispose();
            }
        }

        public Plantilla plantillaSeleccionada()
        {
            return (Plantilla)LB_Plantillas.SelectedItem;
        }

        private void BT_AplicarPorLote_Click(object sender, EventArgs e)
        {
            aplicarPorLote = new Form3(plantillaSeleccionada());
            aplicarPorLote.ShowDialog();
        }


        private void BT_Ver_Click(object sender, EventArgs e)
        {
            plantillaBlanco = new PlantillaBlanco(plantillaSeleccionada());
            plantillaBlanco.ShowDialog();
        }

        public void leerPlantillas()
        {
            LB_Plantillas.DataSource = null;
            LB_Plantillas.DataSource = Plantilla.leerPlantillas();
            LB_Plantillas.DisplayMember = "etiqueta";
        }

        private void LB_Plantillas_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBotones();
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            plantillaSeleccionada().eliminar();
            leerPlantillas();
        }

        private void BT_Duplicar_Click(object sender, EventArgs e)
        {
            FormTB formTb = new FormTB();
            formTb.Text = "Nombre plantilla";
            formTb.Controls.OfType<Label>().FirstOrDefault().Text = "Ingrese el nombre de la nueva plantilla";
            formTb.ShowDialog();
            if (formTb.DialogResult == DialogResult.OK)
            {
                plantillaSeleccionada().duplicar(formTb.salida);
                leerPlantillas();
            }
        }


        private void habilitarBotones()
        {
            if (hayContext)
            {
                BT_Nueva.Enabled = false;
                BT_Editar.Enabled = false;
                BT_Ver.Enabled = false;
                BT_Duplicar.Enabled = false;
                BT_Eliminar.Enabled = false;
                BT_AplicarAUnPlan.Enabled = true;
                BT_AplicarPorLote.Enabled = false;
            }
            else
            {
                Metodos.habilitarBoton(editaPlantilla, BT_Nueva);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1 && editaPlantilla, BT_Editar);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1 && editaPlantilla, BT_Duplicar);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_Ver);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count > 0 && editaPlantilla, BT_Eliminar);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1 && !((Plantilla)LB_Plantillas.SelectedItems[0]).esParaExtraccion, BT_AplicarAUnPlan);
                Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_AplicarPorLote);
                Metodos.habilitarBoton(editaPlantilla, BT_Configuracion);
            }
        }

        private void BT_HabilitarEdicion_Click(object sender, EventArgs e)
        {
            if (editaPlantilla == false)
            {
                FormTB formTb = new FormTB("", false, true);
                formTb.Text = "Edición de plantillas";
                formTb.Controls.OfType<Label>().FirstOrDefault().Text = "Ingrese contraseña para edición de plantillas";
                formTb.ShowDialog();
                if (formTb.DialogResult == DialogResult.OK)
                {
                    editaPlantilla = true;
                    L_Editando.Visible = true;
                    BT_HabilitarEdicion.Text = "Deshabilitar Edición";
                }
            }
            else
            {
                editaPlantilla = false;
                L_Editando.Visible = false;
                BT_HabilitarEdicion.Text = "Habilitar Edición";
            }
            habilitarBotones();
        }

        private void BT_Configuracion_Click(object sender, EventArgs e)
        {
            FormConfiguracion formConfiguracion = new FormConfiguracion();
            formConfiguracion.ShowDialog();
            //LB_Plantillas.Items.Clear();
            leerPlantillas();
        }
    }
}

