using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;

namespace ExploracionPlanes
{
    public class Estructura
    {
        public string nombre { get; set; }
        public List<string> nombresPosibles { get; set; }

        public static Estructura crear(string _nombre, List<string> _nombresAlt)
        {
            List<string> _nombresPosibles = _nombresAlt;
            _nombresPosibles.Insert(0, _nombre);
            return new Estructura()
            {
                nombre = _nombre,
                nombresPosibles = _nombresPosibles,
            };
        }
        public static string asociarExactoID(string nombreEstructura, List<string> listaEstructurasID)
        {
            return listaEstructurasID.Where(c => c.ToLower().Equals(nombreEstructura.ToLower())).FirstOrDefault();
        }

        public static Structure asociarConLista(List<string> listaNombres, List<Structure> listaEstructura)
        {
            foreach (string nombre in listaNombres)
            {
                string estructuraID = asociarExactoID(nombre, listaEstructurasID(listaEstructura));
                if (!string.IsNullOrEmpty(estructuraID))
                {
                    return listaEstructura.Where(c => c.Id.Equals(estructuraID)).FirstOrDefault();
                }
            }
            return null;
        }

        public static List<Structure> listaEstructuras(PlanningItem plan) //CHEQUEAR FILTRAR POR TIPO
        {
            List<Structure> sinFiltrar = new List<Structure>();
            List<Structure> filtradas = new List<Structure>();

            if (plan.GetType() == typeof(PlanSetup))
            {
                sinFiltrar = ((PlanSetup)plan).StructureSet.Structures.ToList();
                MessageBox.Show("Hay " + sinFiltrar.Count + "estructuras sin filtrar");
            }
            else //(plan.GetType() == typeof(PlanSum))
            {
                sinFiltrar = ((PlanSum)plan).StructureSet.Structures.ToList();
                MessageBox.Show("Hay " + sinFiltrar.Count + "estructuras sin filtrar");
            }
            foreach (Structure estructura in sinFiltrar)
            {
                if (estructura.DicomType != "SUPPORT" && !estructura.IsEmpty)
                {
                    filtradas.Add(estructura);
                }
            }
            MessageBox.Show("Hay " + filtradas.Count + "estructuras filtradas");
            return filtradas;
        }

        public static List<string> listaEstructurasID(List<Structure> lista)
        {
            List<string> listaS = lista.Select(e => e.Id).ToList<string>();
            listaS.Add("");
            MessageBox.Show("Hay " + listaS.Count + "ID de estructuras");
            return listaS;
        }


    }
}