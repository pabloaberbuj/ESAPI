using System;
using System.IO;
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
        public PruebaImprimir aplicarPlantilla;
        //public Form2 aplicarPlantilla;
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
            aplicarPlantilla = new PruebaImprimir(plantillaSeleccionada());
            //aplicarPlantilla = new Form2(plantillaSeleccionada());
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
            LB_Plantillas.DisplayMember = "etiqueta";
        }

        private void LB_Plantillas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_Editar);
            Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_Duplicar);
            Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count>0, BT_Eliminar);
            Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1 && !((Plantilla)LB_Plantillas.SelectedItems[0]).esParaExtraccion, BT_AplicarAUnPlan);
            Metodos.habilitarBoton(LB_Plantillas.SelectedItems.Count == 1, BT_AplicarPorLote);

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
    }
}

