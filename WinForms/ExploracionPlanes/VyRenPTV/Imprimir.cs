using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace ExploracionPlanes
{
    public class Imprimir
    {

        public static Font fuenteTitulo = new Font("Arial", 14, FontStyle.Bold);
        public static Font fuenteSubtitulo = new Font("Arial", 11, FontStyle.Bold);
        public static Font fuenteSubtitulo2 = new Font("Arial", 10, FontStyle.Bold);
        public static Font fuenteTexto = new Font("Arial", 9, FontStyle.Regular);
        public static Font fuenteSubindice = new Font("Arial", 5, FontStyle.Regular);
        public static Font fuenteTextoNegrita = new Font("Arial", 9, FontStyle.Bold);
        public static Font fuenteTabla = new Font("Microsoft Sans Serif", 8, FontStyle.Regular);
        public static Font fuenteTablaHeader = new Font("Microsoft Sans Serif", 8, FontStyle.Bold);
        public static SolidBrush negro = new SolidBrush(Color.Black);
        public static Pen penNegra = new Pen(Color.Black, 2);
        public static StringFormat centro = new StringFormat
        {
            Alignment = StringAlignment.Center,
            LineAlignment = StringAlignment.Center,
        };
        public static StringFormat izquierda = new StringFormat
        {
            Alignment = StringAlignment.Near,
            LineAlignment = StringAlignment.Center,
        };
        public static StringFormat derecha = new StringFormat
        {
            Alignment = StringAlignment.Far,
            LineAlignment = StringAlignment.Center,
        };

        public static int altoTexto { get; set; }
        public static int altoTitulo { get; set; }
        public static int altoSubtitulo { get; set; }
        public static int altoSubtitulo2 { get; set; }
        public static int anchoTotal { get; set; }
        public static int altoTotal { get; set; }
        public static int espacioParrafo = 5;
        public static int espacioTitulo = 10;


        public static PrintDocument cargarConfiguracion()
        {
            altoTexto = fuenteTexto.Height;
            altoTitulo = fuenteTitulo.Height;
            altoSubtitulo = fuenteSubtitulo.Height;
            altoSubtitulo2 = fuenteSubtitulo2.Height;

            PrintDocument printDocument1 = new PrintDocument();
            printDocument1.OriginAtMargins = true;
            printDocument1.DefaultPageSettings.Landscape = false;
            printDocument1.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.A4;
            printDocument1.DefaultPageSettings.Margins = new System.Drawing.Printing.Margins(100, 100, 50, 50);

            anchoTotal = Convert.ToInt32(printDocument1.DefaultPageSettings.PrintableArea.Width) - printDocument1.DefaultPageSettings.Margins.Left - printDocument1.DefaultPageSettings.Margins.Right;
            altoTotal = Convert.ToInt32(printDocument1.DefaultPageSettings.PrintableArea.Height) - printDocument1.DefaultPageSettings.Margins.Top - printDocument1.DefaultPageSettings.Margins.Bottom;

            return printDocument1;
        }

        public static int imprimirImagen(PrintPageEventArgs e, Image imagen, int x, int posicionlinea, Font fuente)
        {
            int alto = fuente.Height;
            int ancho = imagen.Width * alto / imagen.Height;
            Rectangle rect = new Rectangle(x, posicionlinea, ancho, alto);
            e.Graphics.DrawImage(imagen, rect);
            return x + ancho;
        }

        public static int imprimirTextoSubindice(PrintPageEventArgs e, string textoNormal, string textoSubindice, int posicionlinea, int x)
        {
            int largoTexto = Convert.ToInt32(e.Graphics.MeasureString(textoNormal, fuenteTexto).Width);
            Rectangle rectTexto = new Rectangle(0, posicionlinea, anchoTotal, altoTexto);
            e.Graphics.DrawString(textoNormal, fuenteTexto, negro, rectTexto);
            int largoSubindice = Convert.ToInt32(e.Graphics.MeasureString(textoSubindice, fuenteSubindice).Width);
            Rectangle rectSubindice = new Rectangle(largoTexto - 3, posicionlinea + 5, anchoTotal, altoTexto);
            e.Graphics.DrawString(textoSubindice, fuenteSubindice, negro, rectSubindice);
            return largoTexto + largoSubindice;
        }

        public static int imprimirSubti2Subindice(PrintPageEventArgs e, string textoNormal, string textoSubindice, int posicionlinea, int x)
        {
            int largoTexto = Convert.ToInt32(e.Graphics.MeasureString(textoNormal, fuenteSubtitulo2).Width);
            Rectangle rectTexto = new Rectangle(0, posicionlinea, anchoTotal, altoSubtitulo2);
            e.Graphics.DrawString(textoNormal, fuenteSubtitulo2, negro, rectTexto);
            int largoSubindice = Convert.ToInt32(e.Graphics.MeasureString(textoSubindice, fuenteSubindice).Width);
            Rectangle rectSubindice = new Rectangle(largoTexto - 3, posicionlinea + 5, anchoTotal, altoTexto);
            e.Graphics.DrawString(textoSubindice, fuenteSubindice, negro, rectSubindice);
            return largoTexto + largoSubindice;
        }

        public static void imprimirLinea(PrintPageEventArgs e, int posicionlinea)
        {
            e.Graphics.DrawLine(penNegra, new Point(0, posicionlinea), new Point(anchoTotal, posicionlinea));
        }

        public static int imprimirTitulo(PrintPageEventArgs e, string titulo, int posicionlinea, int numlineas)
        {
            Rectangle rect = new Rectangle(0, posicionlinea, anchoTotal, altoTitulo * numlineas);
            e.Graphics.DrawString(titulo, fuenteTitulo, negro, rect, centro);
            return posicionlinea + altoTitulo * numlineas + 2*espacioTitulo;
        }

        public static int imprimirSubtitulo(PrintPageEventArgs e, string subtitulo, int posicionlinea)
        {
            Rectangle rect = new Rectangle(0, posicionlinea, anchoTotal, altoSubtitulo);
            e.Graphics.DrawString(subtitulo, fuenteSubtitulo, negro, rect, izquierda);
            return posicionlinea + altoSubtitulo + espacioTitulo;
        }

        public static int imprimirSubtitulo2(PrintPageEventArgs e, string subtitulo2, int posicionlinea, int x = 0)
        {
            Rectangle rect = new Rectangle(x, posicionlinea, anchoTotal, altoSubtitulo2);
            e.Graphics.DrawString(subtitulo2, fuenteSubtitulo2, negro, rect, izquierda);
            return posicionlinea + altoSubtitulo2 + espacioTitulo;
        }

        public static int imprimirTexto(PrintPageEventArgs e, string texto, int posicionlinea, int numlineas, int x)
        {
            Rectangle rect = new Rectangle(x, posicionlinea, anchoTotal, altoTexto * numlineas);
            e.Graphics.DrawString(texto, fuenteTexto, negro, rect, izquierda);
            SizeF largoString = e.Graphics.MeasureString(texto, fuenteTexto);
            return Convert.ToInt32(largoString.Width) + 1;
        }



        public static int imprimirTextoNegrita(PrintPageEventArgs e, string texto, int posicionlinea, int numlineas, int x)
        {
            Rectangle rect = new Rectangle(x, posicionlinea, anchoTotal, altoTexto * numlineas);
            e.Graphics.DrawString(texto, fuenteTextoNegrita, negro, rect, izquierda);
            SizeF largoString = e.Graphics.MeasureString(texto, fuenteTextoNegrita);
            return Convert.ToInt32(largoString.Width) + 1;
        }

        public static int imprimirTextoNegritaDerecha(PrintPageEventArgs e, string texto, int posicionlinea, int numlineas, int x)
        {
            Rectangle rect = new Rectangle(x, posicionlinea, anchoTotal, altoTexto * numlineas);
            e.Graphics.DrawString(texto, fuenteTextoNegrita, negro, rect, derecha);
            SizeF largoString = e.Graphics.MeasureString(texto, fuenteTextoNegrita);
            return Convert.ToInt32(largoString.Width) + 1;
        }

        public static int imprimirEtiquetaYValor(PrintPageEventArgs e, int posicionlinea, string etiqueta, string valor, int x)
        {
            x += imprimirTextoNegrita(e, etiqueta, posicionlinea, 1, x);
            x += imprimirTexto(e, valor, posicionlinea, 1, x);
            return x;
        }

        public static int imprimirTextoDerecha(PrintPageEventArgs e, string texto, int posicionlinea, int numlineas, int x)
        {
            Rectangle rect = new Rectangle(x, posicionlinea, anchoTotal, altoTexto * numlineas);
            e.Graphics.DrawString(texto, fuenteTexto, negro, rect, derecha);
            SizeF largoString = e.Graphics.MeasureString(texto, fuenteTexto);
            return Convert.ToInt32(largoString.Width) + 1;
        }

        public static void imprimirtabla(PrintPageEventArgs e, DataGridView tabla, int anchohoja, int posicionlinea)
        {
            int x_valueFijo = 12;// (anchohoja - tabla.Width) / 2;
            int y_value = posicionlinea;
            int x_value = x_valueFijo;

            foreach (DataGridViewColumn dc in tabla.Columns)
            {
                e.Graphics.DrawString(dc.HeaderText, fuenteTablaHeader, negro, x_value, y_value, centro);
                x_value += dc.Width+ 30;
            }
            y_value += 10;
            for (int i = 0; i < tabla.RowCount; i++)
            {

                DataGridViewRow dr = tabla.Rows[i];
                x_value = x_valueFijo-5;// (anchohoja - tabla.Width) / 2;
                int j = 0;
                e.Graphics.DrawLine(Pens.Black, new Point(x_value - 35, y_value), new Point(x_value + tabla.Width - 10, y_value));
                foreach (DataGridViewColumn dc in tabla.Columns)
                {
                    string text;
                    if (tabla[j,i].Value!=null)
                    {
                        text = tabla[j, i].Value.ToString();
                    }
                    else
                    {
                        text = "";
                    }
                    

                    Rectangle rect = new Rectangle(x_value-15, y_value + 8, Convert.ToInt32(dc.Width)+5, Convert.ToInt32(fuenteTabla.Height)+2);
                    Brush color = new SolidBrush(tabla[j, i].Style.BackColor);
                    e.Graphics.FillRectangle(color, rect);
                    if (dc.Index==0)
                    {
                        e.Graphics.DrawString(text, fuenteTabla, negro, rect, izquierda);
                    }
                    else
                    {
                        e.Graphics.DrawString(text, fuenteTabla, negro, rect, centro);
                    }
                    x_value += dc.Width + 30;
                    j++;
                }
                y_value += 25;
                if (y_value>altoTotal)
                {
                    y_value = posicionlinea;
                    x_valueFijo = 70 + tabla.Width;
                    foreach (DataGridViewColumn dc in tabla.Columns)
                    {
                        e.Graphics.DrawString(dc.HeaderText, fuenteTablaHeader, negro, x_value, y_value, centro);
                        x_value += dc.Width + 30;
                    }
                    y_value += 10;
                }
            }
        }
        public static int imprimirCabeceraInforme(PrintPageEventArgs e, int anchohoja, int posicionlinea, string nombrePaciente, string infoPlan, string nombrePlantilla, string notaPlantilla, string realizadoPor)
        {
            
            posicionlinea = imprimirTitulo(e, "Título", posicionlinea, 1);
            posicionlinea = imprimirSubtitulo(e, "Paciente: " + nombrePaciente, posicionlinea);
            posicionlinea = imprimirSubtitulo(e, "Plan: " + infoPlan, posicionlinea);
            posicionlinea = imprimirSubtitulo(e, "Plantilla: " + nombrePlantilla, posicionlinea);
            int x_value = 10;
            if (!string.IsNullOrEmpty(notaPlantilla))
            {
                string[] notaPlantillaArray = Regex.Split(notaPlantilla, "\r\n");
                foreach (string lineaNota in notaPlantillaArray)
                {
                    imprimirTexto(e, lineaNota, posicionlinea, 1, x_value);
                    posicionlinea += altoTexto;
                }
                posicionlinea += altoTexto;
            }
            imprimirEtiquetaYValor(e, posicionlinea, "Realizado por: ", realizadoPor, x_value);
            posicionlinea += altoTexto;
            imprimirEtiquetaYValor(e, posicionlinea, "Fecha: ", DateTime.Today.ToShortDateString(), x_value);
            return posicionlinea += altoTexto*3;
        }

        public static void imprimirInforme(PrintPageEventArgs e, int anchohoja, int posicionlinea, string nombrePaciente, string infoPlan, string nombrePlantilla, string notaPlantilla, string realizadoPor, DataGridView tabla)
        {
            posicionlinea = imprimirCabeceraInforme(e, anchohoja, posicionlinea, nombrePaciente, infoPlan, nombrePlantilla, notaPlantilla, realizadoPor);
            imprimirtabla(e, tabla, anchohoja, posicionlinea);
        }

    }




}
