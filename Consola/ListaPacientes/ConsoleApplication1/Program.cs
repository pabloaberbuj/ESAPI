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
            try
            {
                StreamWriter Tec3D = new StreamWriter("c:\\3d.txt");
                StreamWriter TecIMRT = new StreamWriter("c:\\IMRT.txt");
                StreamWriter TecVMAT = new StreamWriter("c:\\VMAT.txt");
                int numpacientes = app.PatientSummaries.Count(); //ver cantidad de pacientes
                List<string> IDs = new List<string>(); //genero una lista con todas las IDs
                foreach (var p in app.PatientSummaries)
                {
                    IDs.Add(p.Id);
                }
                File.WriteAllLines("c:\\lista.txt", IDs);
                Console.WriteLine("Lista creada, presione Enter para clasificación de planes");
                Console.ReadLine();
                foreach (string ID in IDs)
                {
                    Patient paciente = app.OpenPatientById(ID);
                    foreach (Course c in paciente.Courses)
                    {
                        foreach (PlanSetup p in c.PlanSetups)
                        {
                            if (p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved)
                            {
                                if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.Static)
                                {
                                    Tec3D.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id);
                                }
                                else if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.DoseDynamic)
                                {
                                    Tec3D.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id);
                                }
                                else if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.VMAT)
                                {
                                    TecVMAT.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id);
                                }
                            }
                        }
                    }
                    app.ClosePatient();
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }
        }
    }
}