using System;
using System.IO;
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
    public partial class Form3 : Form
    {
        public static string pathDestino = Configuracion.pathExportados();
        Patient paciente;
        Course curso;
        PlanningItem plan;
        Plantilla plantilla;
        int pacienteNro = 0;
        VMS.TPS.Common.Model.API.Application app;

        public Form3(Plantilla _plantilla)
        {
            InitializeComponent();
            plantilla = _plantilla;
            this.Text = plantilla.nombre;
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
                L_NombrePaciente.Visible = false;
                return false;
            }
        }

        

        public void cerrarPaciente()
        {
            app.ClosePatient();
            L_NombrePaciente.Visible = false;
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
                return null;
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
                return null;
            }
        }

        public List<Course> listaCursos(Patient paciente)
        {
            return new List<Course>(paciente.Courses.ToList());
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



        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            if (abrirPaciente(TB_ID.Text))
            {
                L_NombrePaciente.Text = paciente.LastName + ", " + paciente.FirstName;
                L_NombrePaciente.Visible = true;
                LB_Cursos.Items.Clear();
                foreach (Course curso in listaCursos(paciente))
                {
                    LB_Cursos.Items.Add(curso);
                }
                if (LB_Cursos.Items.Count>0)
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
            if (LB_Planes.Items.Count>0)
            {
                LB_Planes.SelectedIndex = 0;
            }
        }

        private void llenarDGVEstructuras()
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
            DGV_Estructuras.Columns[0].ReadOnly = true;
            DGV_Estructuras.Columns[1].ReadOnly = false;
        }

        private void llenarDGVPrescripciones()
        {
            DGV_Prescripciones.Rows.Clear();
            DGV_Prescripciones.ColumnCount = 2;
            double prescripcion = 0;
            if (planSeleccionado().GetType() == typeof(PlanSetup))
            {
                prescripcion = ((PlanSetup)planSeleccionado()).TotalPrescribedDose.Dose / 100;
            }
            else
            {
                foreach (PlanSetup plan in ((PlanSum)planSeleccionado()).PlanSetups) //asumo que todos los planes suman con peso 1. Más adelante se puede mejorar con PlanSumComponents
                {
                    prescripcion += plan.TotalPrescribedDose.Dose / 100;
                }
            }
            foreach (Estructura estructura in plantilla.estructurasParaPrescribir())
            {
                DGV_Prescripciones.Rows.Add();
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[0].Value = estructura.nombre;
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[1].Value = prescripcion;
            }
            DGV_Prescripciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            DGV_Prescripciones.Columns[0].ReadOnly = true;
            DGV_Prescripciones.Columns[1].ReadOnly = false;
        }

        private void aplicarPrescripciones()
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

        private bool incluirVolumenesEstructuras()
        {
            return CHB_VolumenEstructuras.Checked;
        }

        private void llenarDGVAnalisis()
        {
            DGV_Análisis.ReadOnly = true;
            if (pacienteNro==0)
            {
                DGV_Análisis.Rows.Clear();
                DGV_Análisis.ColumnCount = 2;
                for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
                {
                    IRestriccion restriccion = plantilla.listaRestricciones[i];
                    DGV_Análisis.Rows.Add();
                    DGV_Análisis.Rows[i].Cells[0].Value = restriccion.etiquetaInicio;
                }
            }
            else
            {
                DGV_Análisis.ColumnCount++;
            }
            int indicePaciente = pacienteNro;
            if (incluirVolumenesEstructuras())
            {
                indicePaciente = pacienteNro * 2;
                DGV_Análisis.ColumnCount++;
                DGV_Análisis.Columns[indicePaciente + 2].HeaderText = paciente.Id + "\nVolumen";
            }
            DGV_Análisis.Columns[indicePaciente + 1].HeaderText = paciente.Id + "\n" + planSeleccionado().Id;

            for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
            {
                IRestriccion restriccion = plantilla.listaRestricciones[i];
                Structure estructura = estructuraCorrespondiente(restriccion.estructura.nombre);
                if (estructura != null)
                {
                    restriccion.analizarPlanEstructura(planSeleccionado(), estructura);
                    if (restriccion.chequearSamplingCoverage(planSeleccionado(), estructura))
                    {
                        MessageBox.Show("La estructura " + estructura.Id + " no tiene el suficiente Sampling Coverage.\nNo se puede realizar el análisis");
                    }
                    else
                    {
                        DGV_Análisis.Rows[i].Cells[indicePaciente + 1].Value = restriccion.valorMedido + restriccion.unidadValor;
                    }
                    if (incluirVolumenesEstructuras())
                    {
                        DGV_Análisis.Rows[i].Cells[indicePaciente + 2].Value = Math.Round(estructura.Volume,2);
                    }
                }
            }
            DGV_Análisis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private Structure estructuraCorrespondiente(string nombreEstructura)
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
        }

        private void BT_Analizar_Click(object sender, EventArgs e)
        {
            if (estructurasSinAsociar() && MessageBox.Show("¿Hay estructuras sin asociar, desea continuar?", "Estructuras sin asociar", MessageBoxButtons.YesNo) == DialogResult.No)
            {

            }
            else
            {
                aplicarPrescripciones();
                llenarDGVAnalisis();
                if (pacienteNro==0)
                {
                    CHB_VolumenEstructuras.Enabled = false;
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
        }

        private void BT_SeleccionarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                llenarDGVEstructuras();
                llenarDGVPrescripciones();
                if (pacienteNro==0)
                {
                    CHB_VolumenEstructuras.Enabled = true;
                }
            }
            catch (Exception exp)
            {
                File.WriteAllText("log.txt", exp.ToString());
            }

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (paciente!=null)
            {
                LB_Cursos.Items.Clear();
                LB_Planes.Items.Clear();
                cerrarPaciente();
            }
            app.Dispose();
        }

        private void BT_GuardarPaciente_Click(object sender, EventArgs e)
        {
            cerrarPaciente();
            TB_ID.Clear();
            LB_Cursos.Items.Clear();
            LB_Planes.Items.Clear();
            DGV_Estructuras.DataSource = null;
            DGV_Estructuras.Rows.Clear();
            DGV_Prescripciones.Rows.Clear();
            BT_GuardarPaciente.Enabled = false;
            pacienteNro++;
        }

        private void BT_Exportar_Click(object sender, EventArgs e)
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
            string nombre = IO.GetUniqueFilename(pathDestino, plantilla.nombre + "_" + DateTime.Today.ToShortDateString() + ".txt");
            File.WriteAllText(nombre, dataObject.GetText(TextDataFormat.CommaSeparatedValue));
            DGV_Análisis.ClearSelection();
            MessageBox.Show("Se ha guardado la exploración con el nombre: " + Path.GetFileName(nombre));
        }

        private void TB_ID_TextChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(!string.IsNullOrEmpty(TB_ID.Text), BT_AbrirPaciente);
        }

        private void LB_Planes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Metodos.habilitarBoton(LB_Planes.SelectedItems.Count == 1, BT_SeleccionarPlan);
        }

        private void DGV_Estructuras_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            Metodos.habilitarBoton(LB_Planes.SelectedItems.Count == 1 && DGV_Estructuras.RowCount > 0, BT_Analizar);
        }

        private void DGV_Análisis_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            BT_GuardarPaciente.Enabled = true;
            Metodos.habilitarBoton(DGV_Análisis.ColumnCount > 1, BT_Exportar);
        }
    }
}
