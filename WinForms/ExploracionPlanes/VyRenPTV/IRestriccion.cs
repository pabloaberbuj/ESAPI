using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExploracionPlanes
{
    public interface IRestriccion
    {
        string estructura { get; set; }
        string etiqueta { get; set; }
        void agregarALista(BindingList<IRestriccion> lista);
    }
}
