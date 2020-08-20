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
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("paberbuj", "123qwe");
        Course curso;
        Patient paciente;
        PlanSetup plan;
        Structure estructura;
        string volumenDeDosis;
        string volumenEstructura;
        string dosisPrescripta;
        //static string[] HCaux = File.ReadAllLines("lista.txt");
        //string[] datosAExportar = new string[HCaux.Count()];


        public Form1()
        {
            InitializeComponent();

            Patient paciente = app.OpenPatientById("1-89080-0");
            //Patient paciente = app.OpenPatientById("1-83694-0");
            string texto = "";
            Course curso = paciente.Courses.Where(C => C.Id.Contains("C0")).First();
            //Course curso = paciente.Courses.Where(C => C.Id.Contains("C2")).First();
            foreach (PlanSetup plan in curso.PlanSetups)
            {
                //PlanSetup plan = curso.PlanSetups.Where(p => p.Id.Contains("falla")).First();
                texto += "\n" + plan.Id;
                foreach (Beam campo in plan.Beams)
                {
                    bool hayDiferencia = false;
                    if (campo.ControlPoints.Count > 2)
                    {
                        float[] valores = new float[campo.ControlPoints.Count()];
                        double[] valoresDif = new double[campo.ControlPoints.Count()-1];
                        
                        for (int i = 0; i < 60; i++)
                        {
                            for (int j = 0; j < 2; j++)
                            {
                                for (int cp = 0; cp < campo.ControlPoints.Count(); cp++)
                                {
                                    valores[cp] = Math.Abs(campo.ControlPoints[cp].LeafPositions[j, i]);
                                    if (cp!=0)
                                    {
                                        valoresDif[cp - 1] = Math.Abs(Math.Round(valores[cp] - valores[cp - 1],2));
                                    }
                                }
                                var max = valores.Max();
                                var min = valores.Min();
                                if (valores.Max()>0)
                                {
                                    //if (valoresDif.Max() > 1)
                                    if (Math.Round(max - min, 5) >= 1)
                                    {
                                        hayDiferencia = true;
                                        texto += "\n" + campo.Id + "hay movimiento de más de 1mm en lámina (" + j.ToString() + "," + i.ToString() + ") " + Math.Round(max - min, 5).ToString();
                                        break;
                                    }
                                }
                                if (Math.Round(max - min,1) > 1)
                                {

                                }
                                
                            }
                            if (hayDiferencia)
                            {
                                break;
                            }
                        }
                        if (!hayDiferencia)
                            
                        {
                            texto += "\n" + campo.Id + " no hay movimiento de láminas";
                        }
                        
                        
                    }
                    else
                    {
                        texto += "\n" + campo.Id + "tiene menos de dos controlPoints";
                    }
                }

            }
            MessageBox.Show(texto);

        }
    }
}
