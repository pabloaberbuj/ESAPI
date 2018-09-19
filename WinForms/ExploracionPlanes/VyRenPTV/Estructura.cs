﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VMS.TPS.Common.Model.API;

namespace ExploracionPlanes
{
    public class Estructura
    {
        public string nombre { get; set; }
        public List<string> nombresAlt { get; set; }
        public static Structure asociarExacto(string nombreEstructura, List<Structure> set)
        {
            return set.Where(c => c.Name.Equals(nombreEstructura)).FirstOrDefault();
        }

        public static Structure asociarConLista(List<string> listaNombresAlt, List<Structure> set)
        {
            foreach (string nombre in listaNombresAlt)
            {
                Structure estructura = asociarExacto(nombre, set);
                if (estructura!=null)
                {
                    return estructura;
                }
            }
            return null;
        }
    }
}
