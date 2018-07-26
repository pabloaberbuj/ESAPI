using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos3D
{
    public class Calcular
    {
        /*   public static double interpolar(double x1, double x2, double y1, double y2, double x)
           {
               double y;
               if (x == x1) { y = y1; }
               else if (x == x2) { y = y2; }

               else { y = y1 + (y2 - y1) / (x2 - x1) * (x - x1); }
               return y;
           }
           public static double buscatabla(double X, string Y, double[] etiquetasX, string[] etiquetasY, double[,] valores)
           {
               int iX = Array.IndexOf(etiquetasX, X);
               int iY = Array.IndexOf(etiquetasY, Y);
               double XY = valores[iX, iY]; //ver que es así y no al revés
               return XY;
           }

           public static double buscatabla(double X, double Y, double[] etiquetasX, double[] etiquetasY, double[,] valores)
           {
               int iX = Array.IndexOf(etiquetasX, X);
               int iY = Array.IndexOf(etiquetasY, Y);
               double XY = valores[iX, iY]; //ver que es así y no al revés
               return XY;
           }

           public static double interpolarLinea(double X, double[] etiquetasX, double[] valores)
           {
               double Y = Double.NaN;
               double X1 = 0; double Y1;
               double X2 = 0; double Y2;
               int iX = Array.IndexOf(etiquetasX, X);
               if (X > etiquetasX.Max())
               {
                   Console.WriteLine("El valor es mayor que todos los tabulados. No se puede interpolar");
               }
               else if (X < etiquetasX.Min())
               {
                   Console.WriteLine("El valor es menor que todos los tabulados. No se puede interpolar");
               }
               else
               {
                   if (iX != -1) //no hace falta interpolar
                   {
                       Y = valores[iX];
                   }
                   else
                   {
                       if (Math.Sign(etiquetasX[1] - etiquetasX[0]) == 1) //creciente
                       {
                           for (int i = 0; i < etiquetasX.Count(); i++)
                           {
                               if (etiquetasX[i] > X)
                               {
                                   X1 = etiquetasX[i - 1];
                                   X2 = etiquetasX[i];
                                   break;
                               }
                           }
                       }
                       else if (Math.Sign(etiquetasX[1] - etiquetasX[0]) == -1) //decreciente
                       {

                           for (int i = 0; i < etiquetasX.Count(); i++)
                           {
                               if (etiquetasX[i] < X)
                               {
                                   X1 = etiquetasX[i - 1];
                                   X2 = etiquetasX[i];
                                   break;
                               }
                           }
                       }
                       Y1 = valores[Array.IndexOf(etiquetasX, X1)];
                       Y2 = valores[Array.IndexOf(etiquetasX, X2)];
                       Y = interpolar(X1, X2, Y1, Y2, X);
                   }
               }
               return Y;
           }
           public static double interpolaryExtrapolarLinea(double X, double[] etiquetasX, double[] valores)
           {
               double Y = Double.NaN;
               double X1 = 0; double Y1;
               double X2 = 0; double Y2;
               int iX = Array.IndexOf(etiquetasX, X);
               if (iX != -1) //no hace falta interpolar
               {
                   Y = valores[iX];
               }
               else
               {
                   if (Math.Sign(etiquetasX[1] - etiquetasX[0]) == 1) //creciente
                   {
                       if (X > etiquetasX.Max())
                       {
                           Console.WriteLine("El valor es mayor que todos los tabulados. El resultado se obtendrá por extrapolación");
                           X1 = etiquetasX[etiquetasX.Count() - 2]; //anteulitmo
                           X2 = etiquetasX[etiquetasX.Count() - 1]; //ultimo
                       }
                       else if (X < etiquetasX.Min())
                       {
                           Console.WriteLine("El valor es menor que todos los tabulados. El resultado se obtendrá por extrapolación");
                           X1 = etiquetasX[0];
                           X2 = etiquetasX[1];
                       }
                       else
                       {
                           for (int i = 0; i < etiquetasX.Count(); i++)
                           {
                               if (etiquetasX[i] > X)
                               {
                                   X1 = etiquetasX[i - 1];
                                   X2 = etiquetasX[i];
                                   break;
                               }
                           }
                       }
                       Y1 = valores[Array.IndexOf(etiquetasX, X1)];
                       Y2 = valores[Array.IndexOf(etiquetasX, X2)];
                       Y = interpolar(X1, X2, Y1, Y2, X);
                   }
                   else if (Math.Sign(etiquetasX[1] - etiquetasX[0]) == -1) //decreciente
                   {
                       if (X > etiquetasX.Max())
                       {
                           Console.WriteLine("El valor es mayor que todos los tabulados. El resultado se obtendrá por extrapolación");
                           X1 = etiquetasX[0];
                           X2 = etiquetasX[1];
                       }
                       else if (X < etiquetasX.Min())
                       {
                           Console.WriteLine("El valor es menor que todos los tabulados. El resultado se obtendrá por extrapolación");
                           X1 = etiquetasX[etiquetasX.Count() - 2]; //anteulitmo
                           X2 = etiquetasX[etiquetasX.Count() - 1]; //ultimo
                       }
                       else
                       {
                           for (int i = 0; i < etiquetasX.Count(); i++)
                           {
                               if (etiquetasX[i] < X)
                               {
                                   X1 = etiquetasX[i - 1];
                                   X2 = etiquetasX[i];
                                   break;
                               }
                           }
                       }
                       Y1 = valores[Array.IndexOf(etiquetasX, X1)];
                       Y2 = valores[Array.IndexOf(etiquetasX, X2)];
                       Y = interpolar(X1, X2, Y1, Y2, X);
                   }
               }
               return Y;
           }

           public static double interpolatabla(double X, string Y, double[] etiquetasX, string[] etiquetasY, double[,] valores)
           {
               int iY = Array.IndexOf(etiquetasY, Y);
               double[] valoresLinea = new double[etiquetasX.Count()];
               for (int i = 0; i < etiquetasX.Count(); i++) //obtiene la fila en la cual interpolar
               {
                   valoresLinea[i] = valores[i, iY];
               }
               return interpolarLinea(X, etiquetasX, valoresLinea);
           }
       }*/
    }
}
