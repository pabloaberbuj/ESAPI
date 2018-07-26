using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatedPlanning
{
    public class Configuracion
    {
        public static string archivo = "Configuracion.txt";
        public static string OptimizationAlgorithm { get; set; }
        public static string DoseCalculationAlgorithm { get; set; }
        public static string MlcId { get; set; }
        public static string LeafMotionCalculator { get; set; }
        public static int NumberOfIterationsForIMRTOptimization { get; set; }

        public static string[] cargar(string archivo)
        {
            try
            {
                return File.ReadAllLines(archivo);
            }
            catch (Exception e)
            {
                MessageBox.Show("No se ha podido abrir. Posiblemente el archivo esté en uso por otra aplicación" + e.ToString(), "Error abriendo el archivo");
                throw;
            }
        }

        public static string extraerString(string[] fid, int linea, char sep = '=')
        {
            string aux = fid[linea]; string[] aux2 = aux.Split(sep); string salida = aux2[1];
            return salida.Trim();
        }

        public static void extraerConfiguracion(string[] fid)
        {
            OptimizationAlgorithm = extraerString(fid, 0);
            DoseCalculationAlgorithm = extraerString(fid, 1);
            MlcId = extraerString(fid, 2);
            LeafMotionCalculator = extraerString(fid, 3);
            NumberOfIterationsForIMRTOptimization = Convert.ToInt32(extraerString(fid, 4));
        }

        public static void cargarConfiguracion()
        {
            string[] fid = cargar(archivo);
            extraerConfiguracion(fid);
        }
        //public  string DVHEstimationAlgorithm = "DVH Estimation Algorithm [13.6.15]";
        //public  string DVHEstimationModel = "WUSTL Prostate Model";
        //public int DefaultNumberOfFractions = 44;
        //public double DefaultDosePerFraction = 1.8;
        //public string PTVSubOARSId = "PTV";
        //public string ExpandedCTVId = "CTV+margin";
        //public  double MarginForJawFittingInMM = 5.0;
        //public  double CollimatorAngle = 0.0;
        //public  double PatientSupportAngle = 0.0;
    }
}
