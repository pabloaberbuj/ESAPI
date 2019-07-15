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
    public partial class FormConfiguracion : Form
    {
        public FormConfiguracion()
        {
            InitializeComponent();
            TB_Ruta.Text = Properties.Settings.Default.Path;
            TB_VolumenDM.Text = Properties.Settings.Default.VolDosisMax.ToString();
        }

        private void BT_Guardar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Path = TB_Ruta.Text;
            Properties.Settings.Default.VolDosisMax = Convert.ToDouble(TB_VolumenDM.Text);
            Properties.Settings.Default.Save();
            Close();
        }

        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_SeleccionarRuta_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.SelectedPath = Properties.Settings.Default.Path;
            DialogResult result = fbd.ShowDialog();
            if (result == DialogResult.OK)
            {
                TB_Ruta.Text = fbd.SelectedPath;
            }
        }
    }
}
