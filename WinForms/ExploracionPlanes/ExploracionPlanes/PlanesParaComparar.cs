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
    public partial class PlanesParaComparar : Form
    {
        public PlanSetup planParaComparar = null;
        public IEnumerable<PlanSetup> planesContext;
        public PlanesParaComparar(IEnumerable<PlanSetup> _planesContext)
        {
            InitializeComponent();
            planesContext = _planesContext;
            LB_PlanesComparar.DataSource = planesContext.ToList();
        }

        private void BT_Selecccionar_Click(object sender, EventArgs e)
        {
            planParaComparar = (PlanSetup)LB_PlanesComparar.SelectedItem;
            this.Close();
        }
    }
}
