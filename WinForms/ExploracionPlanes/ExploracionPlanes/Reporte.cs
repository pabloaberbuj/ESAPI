using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MigraDoc.DocumentObjectModel;
using MigraDoc.Rendering;
using MigraDoc.Rendering.Forms;


namespace ExploracionPlanes
{
    public static class Reporte
    {
        public static string pathDestino = Configuracion.pathReportes();

        public static void exportarAPdf(string apellidoPaciente, string nombrePaciente, string IDPaciente, string nombrePlan, string nombrePlantilla, Document report)
        {
            if (!Directory.Exists(pathDestino))
            {
                Directory.CreateDirectory(pathDestino);
            }
            string paciente="";
            string plan = "";
            if (apellidoPaciente != "" || nombrePaciente != "")
            {
                paciente = IDPaciente + "_" + apellidoPaciente + ", " + nombrePaciente + "_";
            }
            if (nombrePlan!="")
            {
                plan = nombrePlan + "_";
            }
            
            string nombre = paciente + plan + nombrePlantilla;
            string path = IO.GetUniqueFilename(pathDestino, nombre, "pdf");
            PdfDocumentRenderer pdfRenderer = new PdfDocumentRenderer();
            pdfRenderer.Document = report;
            pdfRenderer.RenderDocument();
            pdfRenderer.PdfDocument.Save(path);
            MessageBox.Show("Se ha guardado el reporte con el nombre: " + Path.GetFileName(path));
        }

        public static void imprimir(Document report)
        {
            DocumentRenderer documentRenderer = new DocumentRenderer(report);
            MigraDoc.Rendering.Printing.MigraDocPrintDocument printDocument = new MigraDoc.Rendering.Printing.MigraDocPrintDocument();
            printDocument.Renderer = documentRenderer;
          

        }

        public static Document crearReporte(string apellidoPaciente, string nombrePaciente, string IDPaciente, string nombrePlantilla, string notaPlantilla, string realizadoPor, DataGridView DGV)
        {
            var doc = new Document();
            Estilos.definirEstilos(doc);
            doc.Add(crearSeccion(apellidoPaciente, nombrePaciente, IDPaciente, nombrePlantilla, notaPlantilla, realizadoPor, DGV));
            return doc;
        }

        private static Section crearSeccion(string apellidoPaciente, string nombrePaciente, string IDPaciente, string nombrePlantilla, string notaPlantilla, string realizadoPor, DataGridView DGV)
        {
            Section seccion = new Section();
            Estilos.formatearSeccion(seccion);
            cargarEncabezado(seccion, apellidoPaciente, nombrePaciente, IDPaciente, nombrePlantilla, realizadoPor);
            seccion.Add(convertirDGVaTabla(DGV));
            seccion.AddParagraph("", "Texto");
            if (!string.IsNullOrEmpty(notaPlantilla))
            {
                string[] notaPlantillaArray = Regex.Split(notaPlantilla, "\r\n");
                foreach (string lineaNota in notaPlantillaArray)
                {
                    seccion.AddParagraph(lineaNota, "Texto Parrafo");
                }
            }
            return seccion;
        }

        private static void cargarEncabezado(Section seccion, string apellidoPaciente, string nombrePaciente, string IDPaciente, string nombrePlantilla, string realizadoPor)
        {
            seccion.AddParagraph("Analisis de restricciones en plan de tratamiento", "Titulo");
            string paciente="";
            string fecha = "";
            if (apellidoPaciente!="" || nombrePaciente != "")
            {
                paciente = apellidoPaciente + ", " + nombrePaciente;
                fecha = DateTime.Today.ToShortDateString();
            }
            seccion.Add(Estilos.etiquetaYValor("Paciente", paciente));
            seccion.Add(Estilos.etiquetaYValor("ID", IDPaciente));
            seccion.Add(Estilos.etiquetaYValor("Plantilla", nombrePlantilla));
            seccion.Add(Estilos.etiquetaYValor("Realizado por", realizadoPor));
            seccion.Add(Estilos.etiquetaYValor("Fecha", fecha));
        }


        private static MigraDoc.DocumentObjectModel.Tables.Table convertirDGVaTabla(DataGridView DGV)
        {
            MigraDoc.DocumentObjectModel.Tables.Table tabla = new MigraDoc.DocumentObjectModel.Tables.Table();
            foreach (DataGridViewColumn columna in DGV.Columns)
            {
                if (columna.Name != "VolumenDmax") //para que no agregue la columna de volúmen de dosis máxima
                {
                    tabla.AddColumn(columna.Width);
                }
            }
            var filaHeadertabla = tabla.AddRow();
            foreach (DataGridViewRow filaDGV in DGV.Rows)
            {
                var tableFila = tabla.AddRow();
                for (int i = 0; i < 4; i++) //-para que no agregue la columna de volúmen de dosis máxima
                {
                    string valor = "";
                    if (filaDGV.Cells[i].Value != null)
                    {
                        valor = filaDGV.Cells[i].Value.ToString();
                    }
                    tableFila.Cells[i].AddParagraph(valor);
                    tableFila.Cells[i].Shading.Color = colorDGVaTable(filaDGV.Cells[i].Style.BackColor);
                }
            }
            for (int i = 0; i < DGV.ColumnCount-1; i++)
            {
                tabla.Rows[0].Cells[i].AddParagraph(DGV.Columns[i].HeaderText);
            }
            Estilos.formatearTabla(tabla);
            return tabla;
        }

        public static MigraDoc.DocumentObjectModel.Color colorDGVaTable(System.Drawing.Color color)
        {
            return new Color(color.A, color.R, color.G, color.B);
        }
    }
}
