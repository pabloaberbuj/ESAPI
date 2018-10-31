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
            string[] aux = File.ReadAllLines("Configuracion.txt");
            return aux[0].Split('\t')[1] + @"\Plantillas\";
        }

        public static string pathExportados()
        {
            string[] aux = File.ReadAllLines("Configuracion.txt");
            return aux[1].Split('\t')[1] + @"\Exportados\";
        }

        public static bool hayArchivoConfiguracion()
        {
            return File.Exists("Configuracion.txt");
        }

        public static bool estaCompletoArchivoConfiguracion()
        {
            string[] auxS = File.ReadAllLines("Configuracion.txt");
            if (auxS.Length != 2)
            {
                return false;
            }
            else if (auxS[0].Split('\t').Length != 2 || auxS[1].Split('\t').Length != 2)
            {
                return false;
            }
            else if (String.IsNullOrEmpty(auxS[0].Split('\t')[1]) || String.IsNullOrEmpty(auxS[0].Split('\t')[1]))
            {
                return false;
            }
            return true;
        }
        public static void crearArchivoConfiguracion()
        {
            string[] configuracion = { "Plantillas" + "\t" + Directory.GetCurrentDirectory(), "Exportados" + "\t" + Directory.GetCurrentDirectory() };
            //File.Create("Configuracion.txt");
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
                MessageBox.Show("No se puede cargar correctamente el archivo de configuración");
                return false;
            }
            return true;
        }


    }
}
