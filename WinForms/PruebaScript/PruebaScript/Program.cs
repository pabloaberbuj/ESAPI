using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;
using ExploracionPlanes;
using System.Windows.Forms;

namespace VMS.TPS
{
    class Program
    {
        class Script
        {
            public Script()
            {
            }
            public void Execute(ScriptContext context)
            {
                ExploracionPlanes.Main main = new Main(context.Patient, context.PlanSetup);
                main.abrirForm();
            }
        }
    }
}
