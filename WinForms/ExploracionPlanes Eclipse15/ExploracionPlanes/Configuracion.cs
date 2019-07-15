using System;
using System.Windows.Forms;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploracionPlanes
{
    public class Configuracion
    {
        public static string pathPlantilla()
        {
            //string[] aux = File.ReadAllLines("Configuracion.txt");
            //return @"\\ARIAMEVADB - SVR\va_data$" + @"\Plantillas\";
            return Properties.Settings.Default.Path + @"\Plantillas\";
        }

        public static string pathExportados()
        {
            //string[] aux = File.ReadAllLines("Configuracion.txt");
            //return @"\\ARIAMEVADB - SVR\va_data$" + @"\Exportados\";
            return Properties.Settings.Default.Path + @"\Exportados\";
        }

        public static string pathReportes()
        {
            //string[] aux = File.ReadAllLines("Configuracion.txt");
            //return "\\ARIAMEVADB - SVR\va_data$" + @"\Reportes\";
            return Properties.Settings.Default.Path + @"\Reportes\";
        }

        public static double volDosisMaxima()
        {
            //string[] aux = File.ReadAllLines("Configuracion.txt");
            return Properties.Settings.Default.VolDosisMax;
        }
      /*  public static bool hayArchivoConfiguracion()
        {
            return File.Exists("Configuracion.txt");
        }

        public static bool estaCompletoArchivoConfiguracion()
        {
            string[] auxS = File.ReadAllLines("Configuracion.txt");
            double salida;
            if (auxS.Length != 4)
            {
                return false;
            }
            else if (auxS[0].Split('\t').Length != 2 || auxS[1].Split('\t').Length != 2 || auxS[2].Split('\t').Length != 2 || auxS[3].Split('\t').Length != 2)
            {
                return false;
            }
            else if (String.IsNullOrEmpty(auxS[0].Split('\t')[1]) || String.IsNullOrEmpty(auxS[1].Split('\t')[1]) || String.IsNullOrEmpty(auxS[2].Split('\t')[1]) || !Double.TryParse(auxS[3].Split('\t')[1], out salida))
            {
                return false;
            }
            return true;
        }
        public static void crearArchivoConfiguracion()
        {
            string[] configuracion = { "Plantillas" + "\t" + "\\ARIAMEVADB - SVR\va_data$", "Exportados" + "\t" + "\\ARIAMEVADB - SVR\va_data$", "Reportes" + "\t" + "\\ARIAMEVADB - SVR\va_data$", "VolumenDosisMáxima[cm3]" + "\t" + "0.02"};
            File.WriteAllLines("Configuracion.txt", configuracion);
        }

        public static bool chequearConfiguracion()
        {
            if (!hayArchivoConfiguracion())
            {
                crearArchivoConfiguracion();
                return true;
            }
            else if (!estaCompletoArchivoConfiguracion())
            {
                if (MessageBox.Show("No se puede cargar correctamente el archivo de configuración\n¿Desea restaurar los valores por defecto?","Configuracion",MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    crearArchivoConfiguracion();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }*/


    }
}
