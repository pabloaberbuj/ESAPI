using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string traerHC()
        {
            return TB_HC.Text;
        }
        public void agregarALista(string texto)
        {
            LB_Planes.Items.Add(texto);
        }
        public void escribirNombreCurso(string nombreCurso)
        {
            LB_Curso.Text = nombreCurso;
        }

        public void BT_boton_Click(object sender, EventArgs e)
        {
            Program.Execute(app)
        }
    }
    
}
