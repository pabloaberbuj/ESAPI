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
    public partial class Form_ListaRestricciones : Form
    {
        public IRestriccion restriccionElegida;
        public Form_ListaRestricciones(BindingList<IRestriccion> _restricciones)
        {
            InitializeComponent();
            LB_ListaRestricciones.DataSource = _restricciones;
            LB_ListaRestricciones.DisplayMember = "etiqueta";
        }

        private void BT_Aceptar_Click(object sender, EventArgs e)
        {
            restriccionElegida = (IRestriccion)LB_ListaRestricciones.SelectedItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
