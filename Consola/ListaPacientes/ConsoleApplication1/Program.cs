using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
            try
            {
                bool plan3D = false;
                bool planIMRT = false;
                bool planVMAT = false;
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
                //foreach (string ID in IDs)
                for(int i=0; i<50; i++)
                {
                    //Patient paciente = app.OpenPatientById(ID);
                    Patient paciente = app.OpenPatientById(IDs[i]);
                    plan3D = false; planIMRT = false; planVMAT = false;
                    foreach (Course c in paciente.Courses)
                    {
                        foreach (PlanSetup p in c.PlanSetups)
                        {
                            if (p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved)
                            {
                                if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.Static && plan3D==false)
                                {
                                    Tec3D.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id); plan3D = true;
                                    Console.WriteLine("El paciente " + paciente.Id + "tiene un plan 3D");
                                }
                                else if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.DoseDynamic && planIMRT ==false)
                                {
                                    Tec3D.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id); planIMRT = true;
                                    Console.WriteLine("El paciente " + paciente.Id + "tiene un plan IMRT");
                                }
                                else if (p.Beams.ElementAt(0).MLCPlanType == MLCPlanType.VMAT && planVMAT==false)
                                {
                                    TecVMAT.WriteLine(paciente.Id + "\t" + c.Id + "\t" + p.Id); planVMAT = true;
                                    Console.WriteLine("El paciente " + paciente.Id + "tiene un plan VMAT");
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