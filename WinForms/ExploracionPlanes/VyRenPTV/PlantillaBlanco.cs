﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Forms;


namespace ExploracionPlanes
{
    public partial class PlantillaBlanco : Form
    {
        Plantilla plantilla;
        public PlantillaBlanco(Plantilla _plantilla)
        {
            InitializeComponent();
            plantilla = _plantilla;
            llenarDGVAnalisis();
        }

        private void llenarDGVAnalisis()
        {
            DGV_Análisis.ReadOnly = true;
            DGV_Análisis.Rows.Clear();

            DGV_Análisis.Columns[3].Width = 10;
            for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
            {
                IRestriccion restriccion = plantilla.listaRestricciones[i];

                DGV_Análisis.Rows.Add();
                DGV_Análisis.Rows[i].Cells[0].Value = restriccion.etiquetaInicio;
                string menorOmayor;
                if (restriccion.esMenorQue)
                {
                    menorOmayor = "<";
                }
                else
                {
                    menorOmayor = ">";
                }
                DGV_Análisis.Rows[i].Cells[3].Value = menorOmayor + restriccion.valorEsperado + restriccion.unidadValor;
                DGV_Análisis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        #region Imprimir
        private Document reporte()
        {
            return Reporte.crearReporte("", "", "", plantilla.nombre, plantilla.nota, "", DGV_Análisis);
        }
        private void BT_GuardarReporte_Click(object sender, EventArgs e)
        {
            Reporte.exportarAPdf("", "", "", plantilla.nombre, reporte());
        }

        private void BT_Imprimir_Click(object sender, EventArgs e)
        {
            MigraDoc.Rendering.Printing.MigraDocPrintDocument pd = new MigraDoc.Rendering.Printing.MigraDocPrintDocument();
            var rendered = new DocumentRenderer(reporte());
            rendered.PrepareDocument();
            pd.Renderer = rendered;
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                pd.PrinterSettings = printDialog1.PrinterSettings;
                pd.Print();
            }

        }


        #endregion
    }
}