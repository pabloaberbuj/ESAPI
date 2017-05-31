using System;
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

namespace Winform3
{
    public partial class Form1 : Form
    {
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("pa", "123qwe");
        Course curso;
        Patient paciente;
        PlanSetup plan;
        Structure estructura;
        string volumenDeDosis;
        string dosisDeVolumen;
        string volumenEstructura;
        string dosisMaxima;

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

        private void BT_AgregarHCALista_Click(object sender, EventArgs e)
        {
            LB_ListaHC.Items.Add(TB_AgregarHCALista.Text);
            TB_AgregarHCALista.Clear();
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public PlanSetup abrirPlanAprobado(Course curso) //plan con tratamiento aprobado y más de 3 fracciones (para evitar planes de QA y verificaciones
        {
            return curso.PlanSetups.Where(p => p.ApprovalStatus == PlanSetupApprovalStatus.TreatmentApproved && p.UniqueFractionation.NumberOfFractions > 3).FirstOrDefault();
        }

        public Structure elegirEstructura(PlanSetup plan, string nombreEstructura)
        {
            return plan.StructureSet.Structures.Where(s => s.Id.Contains(nombreEstructura)).FirstOrDefault();
        }

        public string obtenerVolumenEstructura(Structure estructura)
        {
            return Math.Round(estructura.Volume,1).ToString();
        }
        public string obtenerVolumenDeDosis(PlanSetup plan, Structure estructura, double dosis, int unidades)
        {
            DoseValue Dosis;
            if (unidades == 0)
            {
                Dosis = new DoseValue(dosis, DoseValue.DoseUnit.cGy);
            }
            else
            {
                Dosis = new DoseValue(dosis, DoseValue.DoseUnit.Percent);
            }
            

            return Convert.ToString(Math.Round(plan.GetVolumeAtDose(estructura, Dosis, VolumePresentation.Relative),1)) + "%";
        }

        public string obtenerDosisMaxima(PlanSetup plan, Structure estructura)
        {
            return obtenerDosisDeVolumen(plan, estructura, 0.000001);
        }
        public string obtenerDosisDeVolumen(PlanSetup plan, Structure estructura, double volumen)
        {
            DoseValue Dosis;
            Dosis = plan.GetDoseAtVolume(estructura, volumen, VolumePresentation.Relative, DoseValuePresentation.Absolute);
            return Math.Round(Dosis.Dose,1).ToString() + Dosis.UnitAsString;
        }

        

        private void BT_Analizar_Click(object sender, EventArgs e)
        {
            foreach (string hc in LB_ListaHC.Items)
            {
                try
                {
                    paciente = abrirPaciente(hc);
                    curso = abrirCurso(paciente, "C1");
                    plan = abrirPlanAprobado(curso);
                    estructura = elegirEstructura(plan, TB_Estructura.Text);
                    volumenEstructura = obtenerVolumenEstructura(estructura);
                    dosisMaxima = obtenerDosisMaxima(plan, estructura);
                    volumenDeDosis = obtenerVolumenDeDosis(plan, estructura, Convert.ToDouble(TB_Dosis.Text), CB_DosisUnidades.SelectedIndex);
                    dosisDeVolumen = obtenerDosisDeVolumen(plan, estructura, Convert.ToDouble(TB_Volumen.Text));
                    string aux = "\n" + paciente.Id + "\t \t" + estructura.Id + "\t \t Volumen: " + volumenEstructura + "\t \t Dosis Máx: " + dosisMaxima + "\t \t V_"+TB_Dosis.Text+ ": " + volumenDeDosis + "\t \t D_" + TB_Volumen.Text + ": " + dosisDeVolumen;
                    Label_Resultados.Text += aux;
                    Label_Resultados.Update();
                    cerrarPaciente();
                }
                catch (Exception ef)
                {
                    MessageBox.Show(ef.ToString());
                }
            }
        }
    }
}
