using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExploracionPlanes
{
    public interface IRestriccion
    {
        Estructura estructura { get; set; }
        string etiqueta { get; set; }
        void agregarALista(BindingList<IRestriccion> lista);
        void crearEtiqueta();
        int cumple();
        //IRestriccion crear();
        /*/void editar(IRestriccion restriccion, string Estructura, List<string> nombresAlt, int tipoRest,
            double valorCorresp, bool esMenor, double valorEsperado, double valorTolerado,
            string unidadCorresp, string unidadEsperado);*/
    }
}
