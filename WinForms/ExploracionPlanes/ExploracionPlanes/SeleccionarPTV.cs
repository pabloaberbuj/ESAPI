using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public partial class SeleccionarPTV : Form
    {
        public Structure ptv = null;
        public List<Structure> ptvs;
        public SeleccionarPTV(List<Structure> _ptvs)
        {
            InitializeComponent();
            ptvs= _ptvs;
            LB_PlanesComparar.DataSource = ptvs;
        }

        private void BT_Selecccionar_Click(object sender, EventArgs e)
        {
            ptv = (Structure)LB_PlanesComparar.SelectedItem;
            this.Close();
        }
    }
}
