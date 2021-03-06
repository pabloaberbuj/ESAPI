﻿//using AriaQ;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.CA.Scripting;
using VMS.CA.Scripting.Wizard;
using VMS.DV.PD.Scripting;

//using VMS.TPS.Common.Model.API;
//using VMS.TPS.Common.Model.Types;

namespace PruebaImagenes 
{
    public partial class Form2 : Form
    {
        Patient_ paciente = null;
        //Course curso;
        VMS.CA.Scripting.PlanSetup plan;
        //VMS.IRS.Scripting.Application app;
        public VMS.DV.PD.Scripting.Application app { get; private set; }
        //Application_ app2;

        public Form2()
        {
            InitializeComponent();
            try
            {
                app = VMS.DV.PD.Scripting.Application.CreateApplication(null, null);
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error in application");
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
            return false;


        }

        public void cerrarPaciente()
        {
            //app.ClosePatient();
        }

/*        public Course abrirCurso(Patient paciente, string nombreCurso)
        {
            return paciente.Courses.Where(c => c.Id == nombreCurso).FirstOrDefault();
        }

        public PlanSetup abrirPlan(Course curso, string nombrePlan)
        {
            return curso.PlanSetups.Where(p => p.Id == nombrePlan).FirstOrDefault();
        }*/

      /*  public void Imagen(Patient_ paciente, PlanSetup plan)
        {
            foreach (Beam campo in plan.Beams)
            {
                MessageBox.Show("Se inicia campo " + campo.Id);
                try
                {
                    VMS.CA.Scripting.Image imagen = campo.ReferenceImage;
                    Series serie = imagen.Series;
                    Frame frame = imagen.Frames[0];
                    foreach (GraphicAnnotation ga in frame.GraphicAnnotations)
                    {
                        if (ga.GraphicAnnotationType == GraphicAnnotationType.Graticule)
                        {

                        }
                    }

                    //int x = imagen.XSize;
                    //int y = imagen.YSize;
                    //int[,] matrizXY = new int[x, y];
                    //double[,] matrizXY2 = new double[x, y];
                    //imagen.GetVoxels(0, matrizXY);

                    MessageBox.Show("Se obtuvo la matriz");
                    //Bitmap bitmapXY = new Bitmap(x, y);
                    /*   Bitmap bitmapXY2 = new Bitmap(x, y);

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
                       streamWriter2.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudo abrir la imagen");
                    throw;
                }


            }
        }*/

        private void button1_Click(object sender, EventArgs e)
        {
            abrirPaciente(textBox1.Text);
            plan = paciente.Courses.First().PlanSetups.First();
            foreach (Beam beam in plan.Beams)
            {
                VMS.CA.Scripting.Image imagen = beam.ReferenceImage;
                Series serie = imagen.Series;
                Frame frame = imagen.Frames[0];
                foreach (GraphicAnnotation ga in frame.GraphicAnnotations)
                {
                    if (ga.GraphicAnnotationType == GraphicAnnotationType.Graticule)
                    {

                    }
                }
            }

          //  Imagen(paciente, plan);

        }
    }
}
