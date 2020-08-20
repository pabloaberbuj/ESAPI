using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class Mineria
    {
        public struct Caso
        {
            public string pacienteID;
            public Patient paciente;
            public string planID;
            public PlanSetup plan;
            public string nombrePlantilla;
            public Plantilla plantilla;
        }
        public static List<string> leerArchivos()
        {
            return Directory.GetFiles(@"C:\Users\Varian\Desktop\rep pros").ToList();
        }
        public static Caso leerCaso(string nombreArchivo)
        {
            string[] aux = (Path.GetFileName(nombreArchivo)).Split('_');
            Caso caso = new Caso()
            {
                pacienteID = aux[0],
                planID = aux[2],
                nombrePlantilla = aux[3],
            };
            return caso;
        }

        public static List<Caso> buscarPlantilla(Plantilla plantilla)
        {
            List<Caso> casos = new List<Caso>();
            List<string> archivos = leerArchivos();
            foreach (string archivo in archivos)
            {
                string[] aux = archivo.Split('_');
                if (aux[3].Equals(plantilla.nombre))
                {
                    Caso caso = leerCaso(archivo);
                    caso.plantilla = plantilla;
                    casos.Add(caso);
                }
            }
            return casos;
        }

        public static void aplicarPlantilla(Caso caso)
        {
            foreach (IRestriccion restriccion in caso.plantilla.listaRestricciones)
            {
                Structure estructuraEc = Estructura.asociarConLista(restriccion.estructura.nombresPosibles, Estructura.listaEstructuras(caso.plan));
                if (restriccion.dosisEstaEnPorcentaje())
                {
                    restriccion.prescripcionEstructura = caso.plan.TotalPrescribedDose.Dose;
                }
                if (estructuraEc!= null)
                {
                    restriccion.analizarPlanEstructura(caso.plan, estructuraEc);
                }
                
            }
        }

        public static void extraerDePaciente(Caso caso)
        {

        }
    }
}
