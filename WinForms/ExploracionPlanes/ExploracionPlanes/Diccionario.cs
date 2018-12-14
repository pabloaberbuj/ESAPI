using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class Diccionario
    {
        public static Dictionary<DoseValuePresentation, string> unidadDosis = new Dictionary<DoseValuePresentation, string>()
        {
            {DoseValuePresentation.Absolute, "Gy" },
            {DoseValuePresentation.Relative, "%" },
        };
        public static Dictionary<VolumePresentation, string> unidadVolumen = new Dictionary<VolumePresentation, string>()
        {
            {VolumePresentation.AbsoluteCm3, "cm3" },
            {VolumePresentation.Relative, "%" },
        };

     //   public Dictionary<string, Structure> estructura = new Dictionary<string, Structure>()
        
    }
    

}
