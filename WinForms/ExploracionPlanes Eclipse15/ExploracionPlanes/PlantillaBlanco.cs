using System;
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
            this.Text = plantilla.nombre;
        }

        private void llenarDGVAnalisis()
        {
            DGV_Análisis.ReadOnly = true;
            DGV_Análisis.Rows.Clear();

            DGV_Análisis.Columns[4].Width = 10;
            for (int i = 0; i < plantilla.listaRestricciones.Count; i++)
            {
                IRestriccion restriccion = plantilla.listaRestricciones[i];

                DGV_Análisis.Rows.Add();
                DGV_Análisis.Rows[i].Cells[0].Value = restriccion.estructura.nombre;
                DGV_Análisis.Rows[i].Cells[1].Value = restriccion.metrica();
                DGV_Análisis.Rows[i].Cells[5].Value = restriccion.nota;
                string menorOmayor;
                if (restriccion.esMenorQue)
                {
                    menorOmayor = "<";
                }
                else
                {
                    menorOmayor = ">";
                }
                string valorEsperadoString = menorOmayor + restriccion.valorEsperado + restriccion.unidadValor;
                if (!Double.IsNaN(restriccion.valorTolerado))
                {
                    valorEsperadoString += " (" + restriccion.valorTolerado + restriccion.unidadValor + ")";
                }

                DGV_Análisis.Rows[i].Cells[4].Value = valorEsperadoString;
                DGV_Análisis.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
        }


        #region Imprimir
        private Document reporte()
        {
            return Reporte.crearReporte("", "", "", "",plantilla.nombre, plantilla.nota, "", "","",DGV_Análisis);
        }
        private void BT_GuardarReporte_Click(object sender, EventArgs e)
        {
            Reporte.exportarAPdf("", "", "", "", plantilla.nombre, reporte());
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