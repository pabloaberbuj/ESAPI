using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace PatientSummary
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
            List<string> lista = new List<string>();
            try
            {
                int cantidad = app.PatientSummaries.Count();
                Console.WriteLine("el numero total de pacientes es: " + cantidad.ToString());
                Console.ReadLine();

                //foreach (var p in app.PatientSummaries)
                for (int i=100;i<300;i++)
                {
                    var p = app.PatientSummaries.ElementAt(i);
                    string aux = p.Id + " " + p.LastName + " " + p.FirstName + Environment.NewLine;
                    lista.Add(aux);
                }
                Console.ReadLine();
                File.WriteAllLines("c:\\listado.txt", lista.ToArray());
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.ToString());
            }

        }
    }
}
