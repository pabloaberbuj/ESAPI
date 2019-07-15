using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;

namespace ExploracionPlanes
{
    internal class Estilos
    {
        public static void definirEstilos(Document doc)
        {
            var texto = doc.AddStyle("Texto", StyleNames.Normal);
            texto.ParagraphFormat.Font.Name = "Arial";
            texto.ParagraphFormat.Font.Color = Colors.Black;
            texto.ParagraphFormat.Font.Size = 10;
            texto.ParagraphFormat.Font.Bold = false;
            texto.ParagraphFormat.Alignment = ParagraphAlignment.Left;
            texto.ParagraphFormat.SpaceAfter = 3;
            texto.ParagraphFormat.AddTabStop(90);

            var textoPrrafo = doc.AddStyle("Texto Parrafo", "Texto");
            texto.ParagraphFormat.Alignment = ParagraphAlignment.Justify;

            var textoNegrita = doc.AddStyle("Texto Negrita", "Texto");
            textoNegrita.ParagraphFormat.Font.Bold = true;

            var textoCentro = doc.AddStyle("Texto Centro", "Texto");
            textoCentro.ParagraphFormat.Alignment = ParagraphAlignment.Center;

            var titulo = doc.AddStyle("Titulo", "Texto");
            titulo.ParagraphFormat.Font.Size = 18;
            titulo.ParagraphFormat.Font.Bold = true;
            titulo.ParagraphFormat.Alignment = ParagraphAlignment.Center;
            titulo.ParagraphFormat.SpaceAfter = 26;

            var subtitulo = doc.AddStyle("Subtitulo", "Texto");
            subtitulo.ParagraphFormat.Font.Size = 13;
            subtitulo.ParagraphFormat.Font.Bold = true;
            subtitulo.ParagraphFormat.SpaceAfter = 10;

            var tabla = doc.AddStyle("Tabla", "Texto");
            tabla.ParagraphFormat.Font.Name = "Microsoft Sans Serif";
            tabla.ParagraphFormat.Font.Size = 8;
            tabla.ParagraphFormat.SpaceAfter = 2;

            var tablaHeader = doc.AddStyle("Tabla Header", "Tabla");
            tablaHeader.ParagraphFormat.Font.Bold = true;
            tablaHeader.ParagraphFormat.SpaceAfter = 2;
        }

        public static void formatearSeccion(Section seccion)
        {
            seccion.PageSetup.TopMargin = 20;
            seccion.PageSetup.BottomMargin = 20;
        }
        public static void formatearTabla(Table tabla)
        {
            tabla.Style = "Tabla";
            tabla.TopPadding = 2;
            tabla.BottomPadding = 2;

            tabla.Borders.Visible = true;
            tabla.Borders.Width = 0.25;
            tabla.Borders.Color = Colors.Gray;
            tabla.Format.Alignment = ParagraphAlignment.Right;
            tabla.Columns[0].Format.Alignment = ParagraphAlignment.Left;
            tabla.Columns[0].Shading.Color = new Color(238, 236, 225);
            tabla.Columns[1].Format.Alignment = ParagraphAlignment.Left;
            tabla.Rows[0].Format.Alignment = ParagraphAlignment.Center;
            tabla.Rows[0].Borders.Bottom.Width = 1;
            tabla.Rows[0].Borders.Bottom.Color = Colors.Black;
            tabla.Rows[0].Style = "Tabla Header";
            tabla.Rows[0].Format.Font.Size = 9;
            tabla.Columns[0].Style = "Tabla Header";
            for (int i=1; i<tabla.Rows.Count;i++)
            {
                tabla.Rows[i].Cells[0].Format.Font.Size = 9;
            }
        }

        public static void formatearTablaEncabezados(Table tabla)
        {
            tabla.Columns[0].Style = "Texto";
            tabla.Columns[1].Style = "Texto Negrita";
            tabla.Borders.Visible = false;
        }

        public static Paragraph etiquetaYValor(string etiqueta, string valor)
        {
            Paragraph parrafo = new Paragraph();
            parrafo.Style = "Texto";
            parrafo.AddFormattedText(etiqueta + ":", "Texto Negrita");
            parrafo.AddTab();
            parrafo.AddText(valor);
            return parrafo;
        }
    }
}
