﻿using System;
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
        VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication(null, null);

        Patient paciente;
        Course curso;
        PlanSetup plan;
        Plantilla plantilla;
        int pacienteNro = 0;


        public Form3(Plantilla _plantilla)
        {
            InitializeComponent();
            plantilla = _plantilla;
        }

        public Patient abrirPaciente(string ID)
        {
            if (paciente != null)
            {
                cerrarPaciente();
            }
            try
            {
                return app.OpenPatientById(ID);
            }
            catch (Exception)
            {
                MessageBox.Show("El paciente no existe");
                throw;
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
        }



        private void BT_AbrirPaciente_Click(object sender, EventArgs e)
        {
            paciente = abrirPaciente(TB_ID.Text);
            LB_Cursos.DataSource = listaCursos(paciente);
        }

        private void LB_Cursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LB_Planes.DataSource = null;
            LB_Planes.DataSource = listaPlanes(cursoSeleccionado());
        }

     /*   private void BT_SeleccionarPlantillas_Click(object sender, EventArgs e)
        {
            llenarDGVEstructuras();
        }*/

        private void llenarDGVEstructuras()
        {
            DGV_Estructuras.Rows.Clear();
            DGV_Estructuras.ColumnCount = 3;
            foreach (Estructura estructura in plantilla.estructuras())
            {
                DGV_Estructuras.Rows.Add();
                DGV_Estructuras.Rows[DGV_Estructuras.Rows.Count - 1].Cells[0].Value = estructura.nombre;
            }

            DataGridViewComboBoxColumn dgvCBCol = (DataGridViewComboBoxColumn)DGV_Estructuras.Columns[1];
            dgvCBCol.DataSource = Estructura.listaEstructurasID(Estructura.listaEstructuras(planSeleccionado()));
            asociarEstructuras();
        }

        private void llenarDGVPrescripciones()
        {
            DGV_Prescripciones.Rows.Clear();
            DGV_Prescripciones.ColumnCount = 2;
            double prescripcion = planSeleccionado().TotalPrescribedDose.Dose/100;
            foreach (Estructura estructura in plantilla.estructurasParaPrescribir())
            {
                DGV_Prescripciones.Rows.Add();
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[0].Value = estructura.nombre;
                DGV_Prescripciones.Rows[DGV_Prescripciones.Rows.Count - 1].Cells[1].Value = prescripcion;
            }
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

        private void llenarDGVAnalisis()
        {
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
            for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
            {
                IRestriccion restriccion = plantilla.listaRestricciones[i];
                restriccion.analizarPlanEstructura(planSeleccionado(), estructuraCorrespondiente(restriccion.estructura.nombre));
                DGV_Análisis.Rows[i].Cells[pacienteNro+1].Value = restriccion.valorMedido + " " + restriccion.unidadValor;
                DGV_Análisis.Columns[pacienteNro + 1].HeaderText = paciente.Id;
            }
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
            aplicarPrescripciones();
            llenarDGVAnalisis();
        }

        private void BT_SeleccionarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                llenarDGVEstructuras();
                llenarDGVPrescripciones();
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
                cerrarPaciente();
                app.Dispose();
            }
            
        }

        private void BT_GuardarPaciente_Click(object sender, EventArgs e)
        {
            cerrarPaciente();
            TB_ID.Clear();
            LB_Cursos.DataSource = null;
            //LB_Cursos.Items.Clear();
            LB_Planes.DataSource = null;
            //LB_Planes.Items.Clear();
            DGV_Estructuras.DataSource = null;
            DGV_Estructuras.Rows.Clear();
            DGV_Prescripciones.Rows.Clear();
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
            File.WriteAllText(plantilla.nombre + "_" + DateTime.Today.ToShortDateString() + ".txt", dataObject.GetText(TextDataFormat.CommaSeparatedValue));
        }
    }
}
