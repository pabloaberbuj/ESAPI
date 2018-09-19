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
        public Main()
        {
            InitializeComponent();
        }

        private void BT_Nueva_Click(object sender, EventArgs e)
        {
            crearPlantilla = new Form1(this, false);
            crearPlantilla.Show();
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            crearPlantilla = new Form1(this, true);
            crearPlantilla.Show();
        }

        private void BT_AplicarAUnPlan_Click(object sender, EventArgs e)
        {
            aplicarPlantilla = new d
        }
    }
}
