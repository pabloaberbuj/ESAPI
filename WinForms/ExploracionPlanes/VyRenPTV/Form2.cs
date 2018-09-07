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
    public partial class Form2 : Form
    {
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("pa", "123qwe");
        Patient paciente;
        Course curso;
        PlanSetup plan;
        

        public Form2()
        {
            InitializeComponent();
            LB_Plantillas.DataSource = Plantilla.leerPlantillas();
        }
        public Patient abrirPaciente(string ID)
        {
            Patient paciente = app.OpenPatientById(ID);
            return paciente;
        }

        public void cerrarPaciente()
        {
            app.ClosePatient();
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public PlanSetup abrirPlan(Course curso, string nombrePlan)
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

        public PlanSetup planSeleccionado()
        {
            if (LB_Planes.SelectedItems.Count == 1)
            {
                return (PlanSetup)LB_Planes.SelectedItems[0];
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

        public List<PlanSetup> listaPlanes(Course curso)
        {
            return curso.PlanSetups.ToList<PlanSetup>();
        }

        public List<Structure> listaEstructuras(PlanSetup plan)
        {
            return plan.StructureSet.Structures.ToList();
        }

        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            try
            {
                paciente = abrirPaciente(TB_ID.Text);
                LB_Cursos.DataSource = listaCursos(paciente);
            }
            catch (Exception)
            {
                MessageBox.Show("El paciente no existe");
                throw;
            }
        }

        private void LB_Cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Planes.DataSource = null;
            LB_Planes.DataSource = listaPlanes(cursoSeleccionado());
        }

        private void BT_SeleccionarPlantillas_Click(object sender, EventArgs e)
        {
            DataGridViewComboBoxCell dgvCBCell = new DataGridViewComboBoxCell();
            dgvCBCell.DataSource = listaEstructuras(planSeleccionado());
            DGV_Estructuras.ColumnCount = 2;
            for (int i=0;i<3;i++)
            {
                DGV_Estructuras.Rows.Add();
                DGV_Estructuras.Rows[i].Cells[1] = dgvCBCell;
            }
        }
    }
}
