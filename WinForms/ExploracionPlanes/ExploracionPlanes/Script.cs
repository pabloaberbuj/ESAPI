using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;


namespace VMS.TPS
{
    class Script
    {
        public Script()
        {
        }
        public void Execute(ScriptContext context)
        {
            ExploracionPlanes.Main main = new ExploracionPlanes.Main(true, context.Patient, context.PlanSetup, context.CurrentUser,context.PlanSumsInScope,context.PlansInScope);
            main.ShowDialog();
            main.Dispose();
            
        }
    }
}
