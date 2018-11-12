using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
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
            foreach (Beam campo in plan.Beams)
            {
                MessageBox.Show("Se inicia campo " + campo.Id);
                try
                {
                    VMS.TPS.Common.Model.API.Image imagen = campo.ReferenceImage;
                    int x = imagen.XSize;
                    int y = imagen.YSize;
                    int[,] matrizXY = new int[x, y];
                    int[,] matrizXY2 = new int[x, y];
                    imagen.GetVoxels(0, matrizXY);

                    MessageBox.Show("Se obtuvo la matriz");
                    Bitmap bitmapXY = new Bitmap(x, y);
                    Bitmap bitmapXY2 = new Bitmap(x, y);

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            int valor = Convert.ToInt32(matrizXY[i, j] / imagen.Window * 255);
                            bitmapXY.SetPixel(i, j, Color.FromArgb(valor, valor, valor));
                            int valorDV = Convert.ToInt32(imagen.VoxelToDisplayValue(matrizXY[i, j]) * 255);
                            bitmapXY2.SetPixel(i, j, Color.FromArgb(valor, valor, valor));
                        }
                    }
                    bitmapXY.Save("drr_" + campo.Id + ".jpg", ImageFormat.Jpeg);
                    bitmapXY2.Save("drr2_" + campo.Id + ".jpg", ImageFormat.Jpeg);
                    MessageBox.Show("se guardó la imagen");
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudo abrir la imagen");
                    throw;
                }
                
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abrirPaciente(textBox1.Text);
            plan = paciente.Courses.First().PlanSetups.First();
            Imagen(paciente, plan);

        }
    }
}
