using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;

namespace ExploracionPlanes
{
    public class Estructura
    {
        public static Structure asociarExacto(string estructuraPlantilla, StructureSet set)
        {
            return set.Structures.Where(c => c.Name.Equals(estructuraPlantilla)).FirstOrDefault();
        }

        /*public static Structure asociarAprox(string estructuraPlantilla, StructureSet set)
        {
            set.Structures.Where(c=>c.Name.
        }*/
    }
}
