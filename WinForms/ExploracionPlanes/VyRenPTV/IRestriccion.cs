using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExploracionPlanes
{
    public interface IRestriccion
    {
        void agregarALista(List<IRestriccion> lista);
    }
}
