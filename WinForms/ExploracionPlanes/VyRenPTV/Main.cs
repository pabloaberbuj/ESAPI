using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExploracionPlanes
{
    public partial class Main : Form
    {
        public Form1 crearPlantilla;
        public Form2 aplicarPlantilla;
        public Form3 aplicarPorLote;
        public Main()
        {
            InitializeComponent();
            leerPlantillas();
            
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
            aplicarPlantilla = new Form2(plantillaSeleccionada());
            aplicarPlantilla.ShowDialog();
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

        public void leerPlantillas()
        {
            LB_Plantillas.DataSource = null;
            LB_Plantillas.DataSource = Plantilla.leerPlantillas();
            LB_Plantillas.DisplayMember = "nombre";
        }

        private void habilitarBoton(bool test, Button bt)
        {
            if (test)
            {
                bt.Enabled = true;
            }
            else
            {
                bt.Enabled = false;
            }
        }

        private void LB_Plantillas_SelectedIndexChanged(object sender, EventArgs e)
        {
            habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_Editar);
            habilitarBoton(LB_Plantillas.SelectedItems.Count>0, BT_Eliminar);
            habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_AplicarAUnPlan);
            habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_AplicarPorLote);

        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            plantillaSeleccionada().eliminar();
            leerPlantillas();
        }
    }
}

