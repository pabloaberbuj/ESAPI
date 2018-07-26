using System;
using System.Globalization;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos3D
{
    public class Tabla
    {


      /*  public static string tabla_TPRs = @"..\..\tabla_TPRs.txt";
        public static string tabla_camposEquivalentes = @"..\..\tabla_camposEquivalentes.txt";
        public static string tabla_factoresCampos = @"..\..\tabla_factoresCampos.txt";
        public static string tabla_factoresCuña = @"..\..\tabla_factoresCuña.txt";
        public static string[] Cargar(string archivo)
        {
            return File.ReadAllLines(archivo);
        }

        public static string[] extraerStringArray(string[] fid, int linea, char sepHeader = '=', char separador = '\t')
        {
            string aux = fid[linea]; string aux2 = aux.Split(sepHeader)[1];
            return aux2.Split(separador);
        }

        public static double[] extraerDoubleArray(string[] fid, int linea, char sepHeader = '=', char separador = '\t')
        {
            return extraerStringArray(fid, linea, sepHeader, separador).Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
        }

        public static double[,] extraerMatriz(string[] fid, int lineaI, int lineaF, int Tam1, int Tam2)
        {
            double[,] M = new double[Tam1, Tam2];
            for (int i = 0; i < Tam2; i++)
            {
                string[] stringLinea = fid[lineaI + i].Split('\t');
                double[] aux1 = stringLinea.Select(s => double.Parse(s, CultureInfo.InvariantCulture)).ToArray();
                for (int j = 0; j < Tam1; j++)
                {
                    M[j, i] = aux1[j];
                }
            }
            return M;
        }*/
    }
}
