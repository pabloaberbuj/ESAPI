﻿using System;
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


        public Form2(Main main)
        {
            InitializeComponent();
            LB_Plantillas.DataSource = Plantilla.leerPlantillas();
            LB_Plantillas.DisplayMember = "nombre";
        }

        private Plantilla plantillaSeleccionada()
        {
            return (Plantilla)LB_Plantillas.SelectedItems[0];
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
            DGV_Estructuras.Rows.Clear();
            DGV_Estructuras.ColumnCount = 2;
            foreach (Estructura estructura in plantillaSeleccionada().estructuras())
            {
                DGV_Estructuras.Rows.Add();
                DGV_Estructuras.Rows[DGV_Estructuras.Rows.Count - 1].Cells[0].Value = estructura.nombre;
            }

            DataGridViewComboBoxColumn dgvCBCol = (DataGridViewComboBoxColumn)DGV_Estructuras.Columns[1];
            dgvCBCol.DataSource = Estructura.listaEstructurasID(Estructura.listaEstructuras(planSeleccionado()));
            asociarEstructuras();

        }

        private void asociarEstructuras()
        {
            for (int i = 0; i < DGV_Estructuras.Rows.Count; i++)
            {
                Structure estructura = Estructura.asociarConLista(plantillaSeleccionada().estructuras()[i].nombresPosibles, Estructura.listaEstructuras(planSeleccionado()));
                if (estructura!=null)
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
            DGV_Análisis.Rows.Clear();
            DGV_Análisis.ColumnCount = 3;
            for (int i=0; i<plantillaSeleccionada().listaRestricciones.Count;i++)
            {
                IRestriccion restriccion = plantillaSeleccionada().listaRestricciones[i];
                restriccion.analizarPlanEstructura(planSeleccionado(), estructuraCorrespondiente(restriccion.estructura.nombre));
                DGV_Análisis.Rows.Add();
                DGV_Análisis.Rows[i].Cells[0].Value = restriccion.etiqueta;
                DGV_Análisis.Rows[i].Cells[1].Value = restriccion.valorMedido();
                colorCelda(DGV_Análisis.Rows[i].Cells[1], restriccion.cumple());
                DGV_Análisis.Rows[i].Cells[2].Value = restriccion.valorEsperado();
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
            llenarDGVAnalisis();
        }

        private void colorCelda(DataGridViewCell celda, int comparacion)
        {
            if (comparacion==0)
            {
                celda.Style.BackColor = Color.LightGreen;
            }
            else if (comparacion==1)
            {
                celda.Style.BackColor = Color.LightYellow;
            }
            else
            {
                celda.Style.BackColor = Color.Red;
            }
        }
    }
}
