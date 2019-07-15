using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using System.IO;


namespace VMS.TPS
{
    class Script
    {
        public Script()
        {
        }
        public void Execute(ScriptContext context)
        {
            ExploracionPlanes.Main main = new ExploracionPlanes.Main(true, context.Patient, context.PlanSetup, context.CurrentUser,context.PlanSumsInScope);
            main.ShowDialog();
            main.Dispose();
            
        }
    }
}
