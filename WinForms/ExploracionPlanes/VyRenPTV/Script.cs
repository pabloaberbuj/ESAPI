using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
            ExploracionPlanes.Main main = new ExploracionPlanes.Main(context.Patient, context.PlanSetup);
            {
            }
        }
    }
}
