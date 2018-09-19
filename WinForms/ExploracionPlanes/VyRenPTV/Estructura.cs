using System;
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
        public static Structure asociarExacto(string nombreEstructura, List<Structure> set)
        {
            return set.Where(c => c.Name.Equals(nombreEstructura)).FirstOrDefault();
        }

        public static Structure asociarConLista(List<string> listaNombres, List<Structure> set)
        {
            foreach (string nombre in listaNombres)
            {
                Structure estructura = asociarExacto(nombre, set);
                if (estructura!=null)
                {
                    return estructura;
                }
            }
            return null;
        }

        public static List<Structure> listaEstructuras(PlanSetup plan) //CHEQUEAR FILTRAR POR TIPO
        {
            List<Structure> sinFiltrar = plan.StructureSet.Structures.ToList();
            List<Structure> filtradas = new List<Structure>();
            foreach (Structure estructura in sinFiltrar)
            {
                if (estructura.DicomType != "BODY" && estructura.DicomType != "Support")
                {
                    filtradas.Add(estructura);
                }
            }
            return filtradas;
        }
    }
}
