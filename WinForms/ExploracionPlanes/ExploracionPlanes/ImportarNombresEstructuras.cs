using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public partial class ImportarNombresEstructuras : Form
    {
        Patient paciente;
        Course curso;
        PlanningItem plan;
        VMS.TPS.Common.Model.API.Application app;
        public List<string> nombresEstructurasSeleccionadas;
        public ImportarNombresEstructuras()
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
                L_NombrePaciente.Text = paciente.LastName + ", " + paciente.FirstName;
                L_NombrePaciente.Visible = true;
                this.Text += " - " + paciente.LastName + ", " + paciente.FirstName;
                return true;
            }
            else
            {
                MessageBox.Show("El paciente no existe");
                L_NombrePaciente.Visible = false;
                return false;
            }
        }

        public void cerrarPaciente()
        {
            app.ClosePatient();
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public PlanningItem abrirPlan(Course curso, string nombrePlan)
        {
            return curso.PlanSetups.Where(p => p.Id == nombrePlan).FirstOrDefault();
        }

        public Course cursoSeleccionado()
        {
            if (LB_Cursos.SelectedItems.Count == 1)
            {
                return (Course)LB_Cursos.SelectedItems[0];
            }
            else
            {
                return curso;
            }
        }

        public PlanningItem planSeleccionado()
        {
            if (LB_Planes.SelectedItems.Count == 1)
            {
                return (PlanningItem)LB_Planes.SelectedItems[0];
            }
            else
            {
                return plan;
            }
        }

        public List<Course> listaCursos(Patient paciente)
        {
            return paciente.Courses.ToList<Course>();
        }

        public List<PlanningItem> listaPlanes(Course curso)
        {
            List<PlanningItem> lista = new List<PlanningItem>();
            foreach (PlanSetup planSetup in curso.PlanSetups)
            {
                lista.Add(planSetup);
            }
            foreach (PlanSum planSum in curso.PlanSums)
            {
                lista.Add(planSum);
            }
            return lista;
        }

        public List<Structure> listaEstructuras(PlanningItem plan)
        {
            if (plan is PlanSetup)
            {
                return ((PlanSetup)plan).StructureSet.Structures.ToList();
            }
            else
            {
                return ((PlanSum)plan).StructureSet.Structures.ToList();
            }
          
        }

        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            if (abrirPaciente(TB_ID.Text))
            {
                LB_Cursos.Items.Clear();
                foreach (Course curso in listaCursos(paciente))
                {
                    LB_Cursos.Items.Add(curso);
                }
                if (LB_Cursos.Items.Count > 0)
                {
                    LB_Cursos.SelectedIndex = 0;
                }
            }

        }

        private void LB_Cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Planes.Items.Clear();
            foreach (PlanningItem plan in listaPlanes(cursoSeleccionado()))
            {
                LB_Planes.Items.Add(plan);
            }
            if (LB_Planes.Items.Count > 0)
            {
                LB_Planes.SelectedIndex = 0;
            }
        }

        private void BT_SeleccionarPlan_Click(object sender, EventArgs e)
        {
            List<Structure> lista = listaEstructuras(planSeleccionado());
            foreach (Structure estructura in lista)
            {
                CHLB_Estructuras.Items.Add(estructura.Id);
            }
        }

        public List<string> estructurasSeleccionadas()
        {
            return CHLB_Estructuras.CheckedItems.OfType<string>().ToList();
        }

        private void BT_Importar_Click(object sender, EventArgs e)
        {
            nombresEstructurasSeleccionadas = estructurasSeleccionadas();
            this.Close();
        }

        private void BT_SeleccionarTodas_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < CHLB_Estructuras.Items.Count; i++)
{
                CHLB_Estructuras.SetItemChecked(i, true);
            }
        }
    }


}
