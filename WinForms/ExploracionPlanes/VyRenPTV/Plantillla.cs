using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExploracionPlanes
{
    public class Plantilla
    {
        public static string pathDestino = Directory.GetCurrentDirectory() + @"\Plantillas\";
        public string nombre { get; set; }
        public bool esParaExtraccion { get; set; }
        public BindingList<IRestriccion> listaRestricciones { get; set; }

        public static Plantilla crear(string _nombre, bool _esParaExtraccion, BindingList<IRestriccion> _listaRestricciones)
        {
            return new Plantilla()
            {
                nombre = _nombre,
                esParaExtraccion = _esParaExtraccion,
                listaRestricciones = _listaRestricciones,
            };
        }

        public static void guardar(Plantilla plantilla)
        {
            if (!Directory.Exists(pathDestino))
            {
                Directory.CreateDirectory(pathDestino);
            }
            string fileName = IO.GetUniqueFilename(pathDestino, plantilla.nombre);
            IO.writeObjectAsJson(fileName, plantilla);
            MessageBox.Show("Se ha guardado la plantilla con el nombre: " + Path.GetFileName(fileName));
        }

        public static List<Plantilla> leerPlantillas()
        {
            List<Plantilla> lista = new List<Plantilla>();
            string[] plantillas = Directory.GetFiles(pathDestino);
            foreach(string plantilla in plantillas)
            {
                Plantilla p = IO.readJson<Plantilla>(plantilla);
                lista.Add(p);
            }
            return lista;
        }


    }
}
