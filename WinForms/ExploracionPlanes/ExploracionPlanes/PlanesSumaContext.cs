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
    public partial class PlanesSumaContext : Form
    {
        public PlanSum PlanSuma = null;
        public IEnumerable<PlanSum> planSumsContext;
        public PlanesSumaContext(IEnumerable<PlanSum> _planSumsContext)
        {
            InitializeComponent();
            planSumsContext = _planSumsContext;
            LB_PlanesSuma.DataSource = planSumsContext.ToList();
        }

        private void BT_Selecccionar_Click(object sender, EventArgs e)
        {
            PlanSuma = (PlanSum)LB_PlanesSuma.SelectedItem;
            this.Close();
        }
    }
}
