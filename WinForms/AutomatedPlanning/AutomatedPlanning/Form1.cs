using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace AutomatedPlanning
{
    public partial class Form1 : Form
    {
        Patient paciente;
        Course curso;
        ExternalPlanSetup plan;

        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("paberbuj", "123qwe");

        public Form1()
        {
            InitializeComponent();
        }

        public Patient abrirPaciente(string ID)
        {
            return app.OpenPatientById(ID);
        }

        public string cerrarPaciente()
        {
            app.ClosePatient();
            return "Se ha cerrado el paciente";
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public ExternalPlanSetup abrirPlan(Course curso, string nombrePlan)
        {
            return curso.ExternalPlanSetups.Where(p => p.Id == nombrePlan).FirstOrDefault();
        }

        public string salvarPaciente()
        {
            app.SaveModifications();
            return "Se ha guardado el plan";
        }

        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                paciente = abrirPaciente(TB_ID.Text);
                TB_Output.Text += "Se abrió el paciente: " + paciente.Name + "\n";
                curso = abrirCurso(paciente, TB_Curso.Text);
                TB_Output.Text += "Se abrió el curso: " + curso.Name + "\n";
                plan = abrirPlan(curso, TB_Plan.Text);
                TB_Output.Text += "Se abrió el plan: " + plan.Name + "\n";
            }
            catch (Exception)
            {
                TB_Output.Text += "No se pudo abrir";
            }
            
        }

        private void BT_Optimizar_Click(object sender, EventArgs e)
        {
            TB_Output.Text += Plan.optimizarIMRT(plan);
            TB_Output.Text += Plan.calcularMovimientoLaminas(plan);
            TB_Output.Text += Plan.calcularDosis(plan);
            TB_Output.Text += salvarPaciente();
            TB_Output.Text += cerrarPaciente();
        }
    }
}
