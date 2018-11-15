using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;


namespace PruebaReporte
{
    public static class Reporte
    {
        public static void exportarAPdf(string path, Document report)
        {
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = report;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(path);
        }

        public static Document crearReporte(Paciente paciente, Plantilla plantilla, DataGridView DGV)
        {
            var doc = new Document();
            Estilos.definirEstilos(doc);
            doc.Add(crearSeccion(paciente, plantilla, DGV));
            return doc;
        }

        private static Section crearSeccion(Paciente paciente, Plantilla plantilla, DataGridView DGV)
        {
            Section seccion = new Section();
            cargarEncabezado(seccion, paciente, plantilla);
            cargarTabla(seccion, paciente, plantilla, DGV);
            return seccion;
        }

        private static void cargarEncabezado(Section seccion, Patient paciente, Plantilla plantilla)
        {
            seccion.AddParagraph("Analisis de restricciones en plan de tratamiento", "Titulo");
            MigraDoc.DocumentObjectModel.Tables.Table tabla = new MigraDoc.DocumentObjectModel.Tables.Table();
            tabla.AddColumn(10);
            tabla.AddColumn();
            var fila1 = tabla.AddRow();
            var fila2 = tabla.AddRow();
            var fila3 = tabla.AddRow();
            fila1[0].AddParagraph("Paciente:");
            fila1[1].AddParagraph(apellidoPaciente, )



            seccion.AddParagraph("Plantilla: ", "Texto");
        }
        private static MigraDoc.DocumentObjectModel.Tables.Table convertirDGVaTabla(DataGridView DGV)
        {
            MigraDoc.DocumentObjectModel.Tables.Table tabla = new MigraDoc.DocumentObjectModel.Tables.Table();
            foreach (DataGridViewColumn columna in DGV.Columns)
            {
                tabla.AddColumn(columna.Width);
            }
            var filaHeadertabla = tabla.AddRow();
            foreach (DataGridViewRow filaDGV in DGV.Rows)
            {
                var tableFila = tabla.AddRow();
                for (int i = 0; i < DGV.ColumnCount; i++)
                {
                    tableFila.Cells[i].AddParagraph(filaDGV.Cells[i].Value.ToString());
                    tableFila.Cells[i].Shading.Color = colorDGVaTable(filaDGV.Cells[i].Style.BackColor);
                }
            }
            for (int i = 0; i < DGV.ColumnCount; i++)
            {
                tabla.Rows[0].Cells[i].AddParagraph(DGV.Columns[i].HeaderText);
            }
            Estilos.formatearTabla(tabla);
            return tabla;

        }

        public static MigraDoc.DocumentObjectModel.Color colorDGVaTable(System.Drawing.Color color)
        {
            return Color.FromArgb(color.A, color.R, color.G, color.B);
        }
    }
}
