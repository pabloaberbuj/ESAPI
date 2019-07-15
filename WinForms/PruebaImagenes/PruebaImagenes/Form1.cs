using System;
using System.Windows.Media.Media3D;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using VMS.CA.Scripting;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
//using AriaEntities;

namespace PruebaImagenes
{
    public partial class Form1 : Form
    {
        //AriaEntityContext AriaEntityContext = new AriaEntityContext();
        Patient paciente;
        //AriaEntities.Course curso;
        PlanSetup plan;
        VMS.TPS.Common.Model.API.Application app;
        //Application_ app2;

        public Form1()
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
                //paciente = AriaEntityContext.Patients.Where(p => p.PatientId == ID).FirstOrDefault();
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

        /*public Course abrirCurso(AriaEntities.Patient paciente, string nombreCurso)
        {
            //return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        //public AriaEntities.PlanSetup abrirPlan(Course curso, string nombrePlan)
        {
          //  return curso.PlanSetups.Where(p => p.Id == nombrePlan).FirstOrDefault();
        }*/

        public void Imagen(Patient paciente, PlanSetup plan)
        {
            foreach (Beam campo in plan.Beams)
            {
                MessageBox.Show("Se inicia campo " + campo.Id);
                try
                {
                    VMS.TPS.Common.Model.API.Image imagen = campo.ReferenceImage;
                    //Series serie = imagen.Series;
                    /*Frame frame = imagen.Frames[0];
                    foreach (GraphicAnnotation ga in frame.GraphicAnnotations)
                    {
                        if (ga.GraphicAnnotationType == GraphicAnnotationType.Graticule)
                        {
                            
                        }
                    }*/

                    //int x = imagen.XSize;
                    //int y = imagen.YSize;
                    //int[,] matrizXY = new int[x, y];
                    //double[,] matrizXY2 = new double[x, y];
                    //imagen.GetVoxels(0, matrizXY);

                    //MessageBox.Show("Se obtuvo la matriz");
                    //Bitmap bitmapXY = new Bitmap(x, y);
                    /*Bitmap bitmapXY2 = new Bitmap(x, y);

                    for (int i = 0; i < x; i++)
                    {
                        for (int j = 0; j < y; j++)
                        {
                            matrizXY2[i, j] = imagen.VoxelToDisplayValue(matrizXY[i, j]);
                            int valor = Convert.ToInt32(matrizXY[i, j] / imagen.Window * 255);
                            bitmapXY.SetPixel(i, j, Color.FromArgb(valor, valor, valor));
                            int valorDV = Convert.ToInt32(imagen.VoxelToDisplayValue(matrizXY[i, j]) * 255);
                            bitmapXY2.SetPixel(i, j, Color.FromArgb(valor, valor, valor));
                        }
                    }

                    bitmapXY.Save("drr_" + campo.Id + ".jpg", ImageFormat.Jpeg);
                    bitmapXY2.Save("drr2_" + campo.Id + ".jpg", ImageFormat.Jpeg);
                    MessageBox.Show("se guardó la imagen");
                    MessageBox.Show("Window" + imagen.Window.ToString());
                    MessageBox.Show("Level" + imagen.Level.ToString());

                    System.IO.StreamWriter streamWriter = new System.IO.StreamWriter("drr_" + campo.Id + ".txt");
                    string output = "";
                    for (int i = 0; i < matrizXY.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j < matrizXY.GetUpperBound(1); j++)
                        {
                            output += matrizXY[i, j].ToString() + "\t";
                        }
                        streamWriter.WriteLine(output);
                        output = "";
                    }
                    streamWriter.Close();

                    System.IO.StreamWriter streamWriter2 = new System.IO.StreamWriter("drr2_" + campo.Id + ".txt");
                    string output2 = "";
                    for (int i = 0; i < matrizXY2.GetUpperBound(0); i++)
                    {
                        for (int j = 0; j < matrizXY2.GetUpperBound(1); j++)
                        {
                            output2 += matrizXY2[i, j].ToString() + "\t";
                        }
                        streamWriter2.WriteLine(output2);
                        output2 = "";
                    }
                    streamWriter2.Close();*/
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
            VMS.TPS.Common.Model.API.Image imagen = plan.StructureSet.Image;
            var isoc = imagen.DicomToUser(imagen.Origin, plan);
            
            Beam campo = plan.Beams.First();
            
            //VVector iso = campo.IsocenterPosition.;
            
            foreach (Structure estructura in plan.StructureSet.Structures)
            {
                
                for (int z=0;z<120;z++)
                {
                    var contorno = estructura.GetContoursOnImagePlane(35);
                    /*if (contorno.Count()>0)
                    {
                        MessageBox.Show(z.ToString() + estructura.Id);
                    }*/
                }

            }
            Dose dose = plan.Dose;
            IEnumerable<Isodose> isodosis = dose.Isodoses;
            foreach (Isodose iso in isodosis)
            {
                var mesh = iso.MeshGeometry;
            }

            //plan = paciente.Courses.First().PlanSetups.Where(p => p.Id == "Plan2 #").FirstOrDefault();
        Imagen(paciente, plan);

    }
}
}
