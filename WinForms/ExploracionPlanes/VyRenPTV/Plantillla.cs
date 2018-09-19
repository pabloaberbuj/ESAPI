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
        public string path { get; set; }

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
            plantilla.path = fileName;
            IO.writeObjectAsJson(fileName, plantilla);
            MessageBox.Show("Se ha guardado la plantilla con el nombre: " + Path.GetFileName(fileName));
        }

        public static void eliminar(Plantilla plantilla)
        {
            if(MessageBox.Show("¿Desea eliminar la plantilla?", "Eliminar plantilla", MessageBoxButtons.YesNo)  ==DialogResult.Yes)
            {
                File.Delete(plantilla.path);
            }
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

        public List<Estructura> estructuras() //HACER QUE REVISE SOLO EL NOMBRE DE LA ESTRUCTURA
        {
            List<Estructura> estructuras = new List<Estructura>();
            foreach (IRestriccion restriccion in this.listaRestricciones)
            {
                if (!estructuras.Contains(restriccion.estructura))
                {
                    estructuras.Add(restriccion.estructura);
                }
            }
            return estructuras;
        }


    }
}
