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
    public partial class FormTB : Form
    {
        public string salida { get; set; }
        
        public FormTB()
        {
            InitializeComponent();
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            salida = TB_Llenar.Text;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void BT_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void TB_Llenar_TextChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(!string.IsNullOrEmpty(TB_Llenar.Text), BT_Aceptar);
        }
    }
}
