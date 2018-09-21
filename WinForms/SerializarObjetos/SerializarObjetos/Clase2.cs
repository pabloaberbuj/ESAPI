using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SerializarObjetos
{
    public class Clase2
    {
        string nombre { get; set; }
        string ID { get; set; }
        double[] numeros { get; set; }
        List<string> lista { get; set; }

        public Clase2 crear(string _nombre, string _ID, double _numero, string listaEl)
        {
            double[] numeros = { _numero, _numero };
            List<string> lista = new List<string>();
            lista.Add(listaEl);
            lista.Add(listaEl + "1");

            return new Clase2()
            {
                nombre = _nombre,
                ID = _ID,
                numeros = numeros,
                lista = lista,
            };
        }
    }
}
