using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExploracionPlanes
{
    public static class Metodos
    {
        public static void habilitarBoton(bool test, Button bt)
        {
            bt.Enabled = test;
        }

        public static double validarYConvertirADouble(string entrada)
        {
            CultureInfo alternative = (CultureInfo)CultureInfo.CurrentCulture.Clone();
            alternative.NumberFormat.NumberDecimalSeparator = ",";
            bool esNumero; double salida = Double.NaN;
            esNumero = Double.TryParse(entrada, out salida);
            if (!esNumero)
            {
                esNumero = Double.TryParse(entrada, NumberStyles.Float, alternative, out salida);
                if (!esNumero)
                {
                    MessageBox.Show("El formato de uno de los parámetros ingresados es incorrecto.\nSe esperaba un número");
                    salida = Double.NaN;
                }
            }
            return salida;
        }

        public static string validarYConvertirAString(double entrada)
        {
            if (Double.IsNaN(entrada))
            {
                return "";
            }
            else
            {
                return entrada.ToString();
            }
        }

    }
}
