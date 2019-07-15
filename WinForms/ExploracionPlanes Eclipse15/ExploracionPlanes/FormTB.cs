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
        public bool salidaDouble { get; set; }
        public bool esPasword { get; set; }
        public string password = "editaplantilla";

        public FormTB(string textoTB = "", bool _salidaDouble=false, bool _esPasword=false)
        {
            InitializeComponent();
            TB_Llenar.Text = textoTB;
            salidaDouble = _salidaDouble;
            esPasword = _esPasword;
            StartPosition = FormStartPosition.CenterParent;
            if (esPasword)
            {
                TB_Llenar.PasswordChar = '*';
            }
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            double aux=0;
            if (salidaDouble)
            {
                aux = Metodos.validarYConvertirADouble(TB_Llenar.Text);
            }
            salida = TB_Llenar.Text;
            if (!Double.IsNaN(aux))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                TB_Llenar.SelectAll();
            }
            if (!esPasword)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else if (esPasword && password==TB_Llenar.Text)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("La contraseña ingresada es incorrecta");
                DialogResult = DialogResult.None;
                TB_Llenar.Focus();
                TB_Llenar.SelectAll();
            }
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
