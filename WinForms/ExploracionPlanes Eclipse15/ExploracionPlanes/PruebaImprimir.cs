﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Forms;


namespace ExploracionPlanes
{
    public partial class PruebaImprimir : Form
    {
        public static string pathDestino = Properties.Settings.Default.Path + @"\Exportados\";
        Patient paciente;
        Course curso;
        PlanSetup plan;
        Plantilla plantilla;
        VMS.TPS.Common.Model.API.Application app;


        public PruebaImprimir(Plantilla _plantilla)
        {

            InitializeComponent();
            plantilla = _plantilla;
            this.Text = plantilla.nombre;
            /*try
            {
                app = VMS.TPS.Common.Model.API.Application.CreateApplication(null, null);
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede acceder a Eclipse.\n Compruebe que está en una PC con acceso al TPS");
            }*/
        }

        /* public bool abrirPaciente(string ID)
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
         }*/



        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            /*if (abrirPaciente(TB_ID.Text))
            {
                LB_Cursos.DataSource = listaCursos(paciente);
                L_NombrePaciente.Text = paciente.Name;
                L_NombrePaciente.Visible = true;
                this.Text += " - " + paciente.Name;
            }*/

        }

        private void LB_Cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*LB_Planes.DataSource = null;
            LB_Planes.DataSource = listaPlanes(cursoSeleccionado());*/
        }

        /*private void llenarDGVEstructuras()
        {
            DGV_Estructuras.Rows.Clear();
            DGV_Estructuras.ColumnCount = 2;
            foreach (Estructura estructura in plantilla.estructuras())
            {
                DGV_Estructuras.Rows.Add();
                DGV_Estructuras.Rows[DGV_Estructuras.Rows.Count - 1].Cells[0].Value = estructura.nombre;
            }

            DataGridViewComboBoxColumn dgvCBCol = (DataGridViewComboBoxColumn)DGV_Estructuras.Columns[1];
            dgvCBCol.DataSource = Estructura.listaEstructurasID(Estructura.listaEstructuras(planSeleccionado()));
            asociarEstructuras();
            DGV_Estructuras.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }*/

        /*private void llenarDGVPrescripciones()
        {
            DGV_Prescripciones.Rows.Clear();
            DGV_Prescripciones.ColumnCount = 2;
            double prescripcion = planSeleccionado().TotalPrescribedDose.Dose / 100;
            foreach (Estructura estructura in plantilla.estructurasParaPrescribir())
            {
                DGV_Prescripciones.Rows.Add();
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[0].Value = estructura.nombre;
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[1].Value = prescripcion;
            }
            DGV_Prescripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }*/

        /* private void aplicarPrescripciones()
         {
             foreach (IRestriccion restriccion in plantilla.listaRestricciones)
             {
                 if (restriccion.dosisEstaEnPorcentaje())
                 {
                     foreach (DataGridViewRow fila in DGV_Prescripciones.Rows)
                     {
                         if (restriccion.estructura.nombre.Equals(fila.Cells[0].Value))
                         {
                             restriccion.prescripcionEstructura = Convert.ToDouble(fila.Cells[1].Value);
                             break;
                         }
                     }
                 }
             }

         }

         private void asociarEstructuras()
         {
             for (int i = 0; i < DGV_Estructuras.Rows.Count; i++)
             {
                 Structure estructura = Estructura.asociarConLista(plantilla.estructuras()[i].nombresPosibles, Estructura.listaEstructuras(planSeleccionado()));
                 if (estructura != null)
                 {
                     (DGV_Estructuras.Rows[i].Cells[1]).Value = estructura.Id;
                 }
                 else
                 {
                     (DGV_Estructuras.Rows[i].Cells[1]).Value = "";
                 }
             }
         }

         private bool estructurasSinAsociar()
         {
             bool aux = false;
             foreach (DataGridViewRow fila in DGV_Estructuras.Rows)
             {
                 if (string.IsNullOrEmpty((string)fila.Cells[1].Value))
                 {
                     aux = true;
                 }
             }
             return aux;
         }*/

        private void llenarDGVAnalisis()
        {
            DGV_Análisis.Rows.Clear();
            DGV_Análisis.ColumnCount = 4;

            DataGridViewButtonColumn button = (DataGridViewButtonColumn)DGV_Análisis.Columns[3];


            DGV_Análisis.Columns[3].Width = 10;
            DGV_Análisis.Columns[3].DefaultCellStyle.Padding = new Padding(11);
            DGV_Análisis.Columns[2].HeaderText = "casa\ncasa";
            DGV_Análisis.Columns[3].HeaderText = "casa\ncasa";

            //DGV_Análisis.Columns.Add(new DataGridViewButtonColumn());
            //int j = 0;
            for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
            {
                IRestriccion restriccion = plantilla.listaRestricciones[i];

                DGV_Análisis.Rows.Add();
                DGV_Análisis.Rows[i].Cells[0].Value = restriccion.etiquetaInicio;
                DGV_Análisis.Rows[i].Cells[2].Value = restriccion.valorEsperado + restriccion.unidadValor;
                if (restriccion.GetType() == typeof(RestriccionDosisMax))
                {
                    DataGridViewButtonCell bt = (DataGridViewButtonCell)DGV_Análisis.Rows[i].Cells[3];
                    bt.FlatStyle = FlatStyle.System;
                    bt.Style.BackColor = System.Drawing.Color.LightGray;
                    bt.Style.ForeColor = System.Drawing.Color.Black;
                    bt.Style.SelectionBackColor = System.Drawing.Color.LightGray;
                    bt.Style.SelectionForeColor = System.Drawing.Color.Black;
                    bt.Value = RestriccionDosisMax.volumenDosisMaxima.ToString();
                    DGV_Análisis.Rows[i].Cells[3].Style.Padding = new Padding(0, 0, 0, 1);

                }
                /*if (estructuraCorrespondiente(restriccion.estructura.nombre) != null)
                {
                    restriccion.analizarPlanEstructura(planSeleccionado(), estructuraCorrespondiente(restriccion.estructura.nombre));
                    DGV_Análisis.Rows[i].Cells[1].Value = restriccion.valorMedido + " " + restriccion.unidadValor;
                    colorCelda(DGV_Análisis.Rows[i].Cells[1], restriccion.cumple());
                }*/
            }
            DGV_Análisis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }


        /*private Structure estructuraCorrespondiente(string nombreEstructura)
        {
            foreach (DataGridViewRow fila in DGV_Estructuras.Rows)
            {
                if (fila.Cells[0].Value.Equals(nombreEstructura))
                {
                    string estructuraID = (string)(fila.Cells[1].Value);
                    return Estructura.listaEstructuras(planSeleccionado()).Where(s => s.Id.Equals(estructuraID)).FirstOrDefault();
                }
            }
            return null;
        }*/

        private void BT_Analizar_Click(object sender, EventArgs e)
        {
            /*   if (estructurasSinAsociar() && MessageBox.Show("¿Hay estructuras sin asociar, desea continuar?", "Estructuras sin asociar", MessageBoxButtons.YesNo) == DialogResult.No)
               {

               }
               else
               {*/
            // aplicarPrescripciones();
            llenarDGVAnalisis();
            //}
        }

        /*private void colorCelda(DataGridViewCell celda, int comparacion)
        {
            if (comparacion == 0)
            {
                celda.Style.BackColor = Color.LightGreen;
            }
            else if (comparacion == 1)
            {
                celda.Style.BackColor = Color.LightYellow;
            }
            else
            {
                celda.Style.BackColor = Color.Red;
            }
        }*/

        private void BT_SeleccionarPlan_Click(object sender, EventArgs e)
        {
            /*   try
               {
                   llenarDGVEstructuras();
                   llenarDGVPrescripciones();
                   L_EstatusAprobacion.Text = planSeleccionado().ApprovalStatus.ToString();
               }
               catch (Exception exp)
               {
                   File.WriteAllText("log.txt", exp.ToString());
               }*/
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            /* if (paciente != null)
             {
                 LB_Cursos.DataSource = null;
                 LB_Planes.DataSource = null;
                 cerrarPaciente();
                 app.Dispose();
             }*/
        }



        private void TB_ID_TextChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(!string.IsNullOrEmpty(TB_ID.Text), BT_AbrirPaciente);
        }


        private void LB_Planes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(LB_Planes.SelectedItems.Count == 1, BT_SeleccionarPlan);
        }

        private void DGV_Análisis_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Metodos.habilitarBoton(DGV_Análisis.Rows.Count > 0, BT_VistaPrevia);
            Metodos.habilitarBoton(DGV_Análisis.Rows.Count > 0, BT_Imprimir);
        }

        private void DGV_Estructuras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Metodos.habilitarBoton(LB_Planes.SelectedItems.Count == 1 && DGV_Estructuras.RowCount > 0, BT_Analizar);
        }




        #region Imprimir
        private void BT_VistaPrevia_Click(object sender, EventArgs e)
        {
            /*PrintDocument pd = new PrintDocument();
            pd = Imprimir.cargarConfiguracion();
            printPreviewDialog1.Document = pd;
            pd.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage_1);
            
            printPreviewDialog1.ShowDialog();*/
            Reporte.exportarAPdf("APELLIDO", "Nombre", "12-34567", "plan", plantilla.nombre, Reporte.crearReporte("APELLIDO", "Nombre", "12-34567", "equipo",plantilla.nombre, plantilla.nota, "pa", "","",DGV_Análisis));
            MessageBox.Show("Se creó");
        }

        private void BT_Imprimir_Click(object sender, EventArgs e)
        {
            // Choose whether to write header. Use EnableWithoutHeaderText instead to omit header.
            DGV_Análisis.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            // Select all the cells
            DGV_Análisis.SelectAll();
            // Copy selected cells to DataObject
            DataObject dataObject = DGV_Análisis.GetClipboardContent();
            // Get the text of the DataObject, and serialize it to a file
            if (!Directory.Exists(pathDestino))
            {
                Directory.CreateDirectory(pathDestino);
            }
            string nombre = IO.GetUniqueFilename(pathDestino, plantilla.nombre + "_" + DateTime.Today.ToString("dd-MM-yyyy"));

            string aux = dataObject.GetText(TextDataFormat.CommaSeparatedValue);
            aux = aux.Replace('\n', ' ');
            aux = aux.Replace("\r", "\r\n");
                
            File.WriteAllText(nombre, aux);
            DGV_Análisis.ClearSelection();
            MessageBox.Show("Se ha guardado la exploración con el nombre: " + Path.GetFileName(nombre));
        }
        private Document reporte()
        {
            return Reporte.crearReporte("Apellido", "Nombre", "12-34567", "equipo",plantilla.nombre, plantilla.nota, "pa","","", DGV_Análisis);
        }


        #endregion

        private void DGV_Análisis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                FormTB formTb = new FormTB(RestriccionDosisMax.volumenDosisMaxima.ToString());
                formTb.Text = "Volumen dosis maxima";
                formTb.Controls.OfType<Label>().FirstOrDefault().Text = "Definir un nuevo volumen para el \ncálculo de la dosis máxima [cm3]";
                formTb.ShowDialog();

                if (formTb.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("Se ha elegido " + formTb.salida + "\n" + "en la fila" + e.RowIndex.ToString());
                    (senderGrid.Rows[e.RowIndex].Cells[e.ColumnIndex]).Value = formTb.salida;
                }
            }
        }
    }
}
