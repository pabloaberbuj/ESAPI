using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public partial class TBI : Form
    {
        Patient paciente;
        Course curso;
        PlanSetup plan;
        VMS.TPS.Common.Model.API.Application app;
        List<string> txt = new List<string>();
        public TBI()
        {
            InitializeComponent();
            try
            {
                app = VMS.TPS.Common.Model.API.Application.CreateApplication("paberbuj", "123qwe");
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede acceder a Eclipse.\n Compruebe que está en una PC con acceso al TPS");
            }
        }

        public bool abrirPaciente(string ID)
        {
            if (paciente != null)
            {
                cerrarPaciente();
            }
            if (app.PatientSummaries.Any(p => p.Id == ID))
            {
                paciente = app.OpenPatientById(ID);
                return true;
            }
            else
            {
                //MessageBox.Show("El paciente no existe");
                return false;
            }
        }
        public void cerrarPaciente()
        {
            app.ClosePatient();
        }

        public List<string> IDs(string archivo)
        {
            return File.ReadAllLines(archivo).ToList<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> ids = IDs("ID_TBI.txt");
            foreach (string id in ids)
            {
                if (abrirPaciente(id))
                {
                    int campos = 0;
                    if (paciente.Courses != null)
                    {
                        foreach (Course curso in paciente.Courses)
                        {
                            if (curso.PlanSetups != null)
                            {
                                foreach (PlanSetup plan in curso.PlanSetups)
                                {
                                    if (plan.Id.Contains("Ant"))
                                    {
                                        foreach (Beam campo in plan.Beams)
                                        {
                                            if (campo.Technique.Id == "ARC" && (campo.DoseRate == 80 || campo.DoseRate == 100))
                                            {
                                                string aux = paciente.Id + ";" + curso.Id + ";" + plan.Id + ";" + campo.Id + ";" + campo.ControlPoints.First().GantryAngle + ";" + campo.ControlPoints.Last().GantryAngle + ";" + campo.Meterset.Value + ";" + campo.TreatmentUnit.Id;
                                                txt.Add(aux);
                                                campos++;
                                                //textBox1.Text += "\r" + paciente.Id + " " + plan.Id + " " + campo.Id + "\r";
                                                //textBox1.Update();
                                            }
                                        }
                                    }
                                }
                            }
                        }

                        cerrarPaciente();
                        textBox1.Text += Environment.NewLine + id + " " + campos.ToString();
                        textBox1.Update();
                    }


                }
            }
            File.WriteAllLines("output.txt", txt);
        }
    }


}

