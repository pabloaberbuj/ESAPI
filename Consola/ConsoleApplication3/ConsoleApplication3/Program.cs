using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace Standalone
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                using (Application app = Application.CreateApplication(null, null))
                {
                    Execute(app);
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
        }
        static void Execute(Application app)
        {
            Console.WriteLine("Ingresar HC: ");
            string HC = Console.ReadLine();
            Patient paciente = app.OpenPatientById(HC);
            Console.WriteLine("Nombre del paciente: " + paciente.LastName + ", " + paciente.FirstName);
            Course curso = (from Course c in paciente.Courses where c.Id == "C1" select c).FirstOrDefault();
            Console.WriteLine("Se abrió el curso" + curso.Id);
            PlanSetup plan = (from PlanSetup p in curso.PlanSetups where p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved select p).FirstOrDefault();
            Console.WriteLine("Se abrió el plan" + plan.Id);
            double MUtotales = 0;
            foreach(Beam campo in plan.Beams)
            {
                MUtotales += campo.Meterset.Value;
            }
            Console.WriteLine("UM totales" + MUtotales.ToString());
            StructureSet ss = plan.StructureSet;
            Structure ptv = (from Structure s in ss.Structures where s.Id.Contains("PTV") select s).FirstOrDefault();
            Console.WriteLine("El volumen del PTV es " + ptv.Volume.ToString());
            DVHData dvh = plan.GetDVHCumulativeData(ptv, DoseValuePresentation.Absolute, VolumePresentation.AbsoluteCm3, 0.1);
            Console.WriteLine("La dosis máxima en el PTV es" + dvh.MaxDose);
            Console.ReadLine();
        }
    }
}
