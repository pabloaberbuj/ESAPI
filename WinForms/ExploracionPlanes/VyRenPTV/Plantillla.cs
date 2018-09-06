using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace ExploracionPlanes
{
    public class Plantilla
    {
        public static string pathDestino = Directory.GetCurrentDirectory() + @"\Plantillas\";
        public string nombre { get; set; }
        public BindingList<IRestriccion> listaRestricciones { get; set; }

        public static Plantilla crear(string _nombre, BindingList<IRestriccion> _listaRestricciones)
        {
            return new Plantilla()
            {
                nombre = _nombre,
                listaRestricciones = _listaRestricciones,
            };
        }

        public static void guardar(Plantilla plantilla)
        {
            string fileName = IO.GetUniqueFilename(pathDestino, plantilla.nombre);
            IO.writeObjectAsJson(fileName, plantilla);
        }

        public static List<Plantilla> leerPlantillas()
        {
            List<Plantilla> lista = new List<Plantilla>();
            string[] plantillas = Directory.GetFiles(pathDestino);
            foreach(string plantilla in plantillas)
            {
                //Plantilla p = IO.readJson<Plantilla>(plantilla);
                Plantilla p = JsonConvert.DeserializeObject<Plantilla>(plantilla);
                lista.Add(p);
            }
            return lista;
        }
    }
}
