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

namespace PruebaImagenes
{
    public partial class Form1 : Form
    {
        Patient paciente;
        Course curso;
        PlanSetup plan;
        VMS.TPS.Common.Model.API.Application app;

        public Form1()
        {
            InitializeComponent();
            try
            {
                app = VMS.TPS.Common.Model.API.Application.CreateApplication(null, null);
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
                MessageBox.Show("El paciente no existe");
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

        public PlanSetup abrirPlan(Course curso, string nombrePlan)
        {
            return curso.PlanSetups.Where(p => p.Id == nombrePlan).FirstOrDefault();
        }

        public void Imagen(Patient paciente, PlanSetup plan)
        {
            VMS.TPS.Common.Model.API.Image imagen = plan.Beams.First().ReferenceImage;
            int x = imagen.XSize;
            int y = imagen.YSize;
            int z = imagen.ZSize;
            int[,] matrizXY = new int[x, y];
            int[,] matrizXZ = new int[x, y];
            int[,] matrizYZ = new int[y, z];
            try
            {
                imagen.GetVoxels(0, matrizXY);
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño XY no es correcto");
            }

            try
            {
                imagen.GetVoxels(0, matrizXZ);
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño XZ no es correcto");
            }

            try
            {
                imagen.GetVoxels(0, matrizYZ);
            }
            catch (Exception)
            {

                MessageBox.Show("El tamaño YZ no es correcto");
            }


            Bitmap bitmapXY = new Bitmap(x, y);
            Bitmap bitmapXZ = new Bitmap(x, z);
            Bitmap bitmapYZ = new Bitmap(y, z);

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
