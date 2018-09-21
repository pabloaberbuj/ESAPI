using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializarObjetos
{
    class Clase1
    {
        Clase2 clase2 { get; set; }
        string nombre { get; set; }
        List<Clase2> lista { get; set; }
        double valor { get; set; }

        public Clase1 crear(Clase2 _clase, string _nombre, double _valor)
        {
            List<Clase2> lista = new List<Clase2>();
            lista.Add(_clase);
            return new Clase1()
            {
                clase2 = _clase,
                nombre = _nombre,
                lista = lista,
                valor = _valor,
            };
        }
    }
}
