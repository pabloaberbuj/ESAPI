using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace WindowsFormsApplication1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                using (VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication(null, null))
                {
                    Execute(app);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
                        
        }
        public static void Execute(VMS.TPS.Common.Model.API.Application app)
        {
            Form1 ventana = new Form1();
            System.Windows.Forms.Application.EnableVisualStyles();
            System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);
            System.Windows.Forms.Application.Run(ventana);
            string HC = ventana.traerHC();
            
            Patient paciente = app.OpenPatientById(HC);
            Course curso = paciente.Courses.Where(c => c.Id == "C1").FirstOrDefault();
            ventana.escribirNombreCurso(curso.Id);
            foreach (PlanSetup p in curso.PlanSetups)
            {
                ventana.agregarALista(p.Id);
            }
            app.ClosePatient();
        }
    }
}
