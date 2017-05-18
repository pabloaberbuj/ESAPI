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

namespace WinForm2
{
    public partial class Form1 : Form
    {
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("pa", "123qwe");
        Course curso;
        Patient paciente;
        public Form1()
        {
            InitializeComponent();
        }

        
        public Patient abrirPaciente(string ID)
        {
            return app.OpenPatientById(ID);
        }

        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public void llenarListaPlanes(Course curso, ListBox lb)
        {
            foreach (PlanSetup p in curso.PlanSetups)
            {
                lb.Items.Add(p.Id);
            }
        }

        public void llenarListaEstructura(PlanSetup plan, ListBox lb)
        {
            foreach (Structure s in plan.StructureSet.Structures)
            {
                lb.Items.Add(s.Id);
            }
        }

        public void escribirNombreCurso(Course curso, Label label)
        {
            label.Text = curso.Id;
        }

        public void escribirEstadoPlan (PlanSetup plan, Label label)
        {
            label.Text = plan.ApprovalStatus.ToString();
        }

        public void escribirNumCampos (PlanSetup plan, Label label)
        {
            label.Text = plan.Beams.Count().ToString();
        }

        public void escribirUMTotales (PlanSetup plan, Label label)
        {
            double auxUM = 0;
            foreach (Beam b in plan.Beams)
            {
                auxUM += b.Meterset.Value;
            }
            label.Text = auxUM.ToString();
        }

        public void escribirVolumen(Structure estructura, Label label)
        {
            label.Text = estructura.Volume.ToString();
        }

        private void BT_Buscar_Click(object sender, EventArgs e)
        {
            paciente = abrirPaciente(TB_HC.Text);
            curso = abrirCurso(paciente, "C1");
            escribirNombreCurso(curso, L_Curso);
            llenarListaPlanes(curso, LB_Planes);
        }

        private void LB_Planes_SelectedIndexChanged(object sender, EventArgs e)
        {
            PlanSetup plan = curso.PlanSetups.ElementAt(LB_Planes.SelectedIndex);
            escribirEstadoPlan(plan, L_EstadoPlan);
            escribirNumCampos(plan, L_NumCampos);
            escribirUMTotales(plan, L_UMTotales);
            llenarListaEstructura(plan, LB_Estructuras);
        }

        private void LB_Estructuras_SelectedIndexChanged(object sender, EventArgs e)
        {
            Structure estrucura = curso.PlanSetups.ElementAt(LB_Planes.SelectedIndex).StructureSet.Structures.ElementAt(LB_Estructuras.SelectedIndex);
            escribirVolumen(estrucura, L_Volumen);
        }
    }
}
