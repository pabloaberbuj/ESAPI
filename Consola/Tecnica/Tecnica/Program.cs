using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ListaPacientes
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                using (Application app = Application.CreateApplication("pa", "123qwe"))
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

            try
            {
                Patient paciente = app.OpenPatientById(HC);
                Course curso = (from Course c in paciente.Courses where c.Id == "C1" select c).FirstOrDefault();
                Console.WriteLine("Se abrió el curso" + curso.Id);
                PlanSetup plan = (from PlanSetup p in curso.PlanSetups where p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved && p.UniqueFractionation.NumberOfFractions > 2 select p).FirstOrDefault();
                Console.WriteLine("Se abrió el plan" + plan.Id);
                Beam campo1 = plan.Beams.ElementAt(0);
                if (campo1.MLCPlanType == MLCPlanType.Static)
                { Console.WriteLine("El plan es 3D"); }
                else if (campo1.MLCPlanType == MLCPlanType.DoseDynamic)
                { Console.WriteLine("El plan es IMRT"); }
                else if (campo1.MLCPlanType == MLCPlanType.VMAT)
                { Console.WriteLine("El plan es VMAT"); }
                else { Console.WriteLine("El plan es " + campo1.MLCPlanType.ToString()); }
                app.ClosePatient();
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
        }
    }
}

