using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace VyRenPTV
{
    public partial class Form1 : Form
    {
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("pa", "123qwe");
        Course curso;
        Patient paciente;
        PlanSetup plan;
        Structure estructura;
        string volumenDeDosis;
        string volumenEstructura;
        string dosisPrescripta;
        static string[] HCaux = File.ReadAllLines("lista.txt");
        string[] datosAExportar = new string[HCaux.Count()];


        public Form1()
        {
            InitializeComponent();
        }

        public Patient abrirPaciente(string ID)
        {
            return app.OpenPatientById(ID);
        }

        public void cerrarPaciente()
        {
            app.ClosePatient();
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }
        public PlanSetup abrirPlanAprobado(Course curso) //plan con tratamiento aprobado y más de 3 fracciones (para evitar planes de QA y verificaciones)
        {
            return curso.PlanSetups.Where(p => p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved && p.UniqueFractionation.NumberOfFractions > 3).FirstOrDefault();
        }

        public Structure elegirEstructura(PlanSetup plan, string nombreEstructura)
        {
            return plan.StructureSet.Structures.Where(s => s.Id.Contains(nombreEstructura)).FirstOrDefault();
        }

        public string obtenerDosisPrescripta(PlanSetup plan)
        {
            return plan.TotalPrescribedDose.Dose.ToString();
        }

        public string obtenerVolumenEstructura(Structure estructura)
        {
            return Math.Round(estructura.Volume, 1).ToString();
        }

        public string obtenerVolumenDeDosis(PlanSetup plan, Structure estructura, double dosis)
        {
            DoseValue Dosis = new DoseValue(dosis, DoseValue.DoseUnit.cGy);

            return Convert.ToString(Math.Round(plan.GetVolumeAtDose(estructura, Dosis, VolumePresentation.Relative), 1)) + "%";
        }

        public string obtenerDosisMaxima(PlanSetup plan, Structure estructura)
        {
            return obtenerDosisDeVolumen(plan, estructura, 0.000001);
        }

        public string obtenerDosisDeVolumen(PlanSetup plan, Structure estructura, double volumen)
        {
            DoseValue Dosis;
            Dosis = plan.GetDoseAtVolume(estructura, volumen, VolumePresentation.Relative, DoseValuePresentation.Absolute);
            return Math.Round(Dosis.Dose, 1).ToString() + Dosis.UnitAsString;
        }

        private void BT_AgregarALista_Click(object sender, EventArgs e)
        {
            LB_HCs.Items.Add(TB_Agregar.Text);
            TB_Agregar.Clear();
            TB_Agregar.Focus();
        }

        private void BT_Analizar_Click(object sender, EventArgs e)
        {
            datosAExportar[0] = "HC \t Prescripción \t Recto Vol \t Recto V_40 \t RenPTV Vol \t Vejiga Vol \t Vejiga V_45 \t VenPTV Vol";
            int i = 1;
            //foreach (string hc in LB_HCs.Items)
            foreach (string hc in HCaux)
            {
                try
                {
                    paciente = abrirPaciente(hc);
                    curso = abrirCurso(paciente, "C1");
                    plan = abrirPlanAprobado(curso);
                    dosisPrescripta = obtenerDosisPrescripta(plan);
                    estructura = elegirEstructura(plan, "Recto");
                    volumenEstructura = obtenerVolumenEstructura(estructura);
                    volumenDeDosis = obtenerVolumenDeDosis(plan, estructura, 4000);
                    datosAExportar[i] += hc + "\t" + dosisPrescripta + "\t" + volumenEstructura + "\t" + volumenDeDosis + "\t";
                    estructura = elegirEstructura(plan, "RenPTV");
                    volumenEstructura = obtenerVolumenEstructura(estructura);
                    datosAExportar[i] += volumenEstructura + "\t";
                    estructura = elegirEstructura(plan, "Vejiga");
                    volumenEstructura = obtenerVolumenEstructura(estructura);
                    volumenDeDosis = obtenerVolumenDeDosis(plan, estructura, 4500);
                    datosAExportar[i] += volumenEstructura + "\t" + volumenDeDosis + "\t";
                    estructura = elegirEstructura(plan, "VenPTV");
                    volumenEstructura = obtenerVolumenEstructura(estructura);
                    datosAExportar[i] += volumenEstructura;
                    L_Reporte.Text += hc + " OK \n";
                    cerrarPaciente();
                    i++;
                    L_Reporte.Update();
                }
                catch (Exception ef)
                {
                    L_Reporte.Text += hc + " Error \n";
                    L_Reporte.Update();
                }
            }
            File.WriteAllLines("reporte.txt", datosAExportar);
        }
    }
}
