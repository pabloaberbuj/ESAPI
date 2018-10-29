using System;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;

namespace ExploracionPlanes
{
    public class Plantilla
    {
        public static string pathDestino = Directory.GetCurrentDirectory() + @"\Plantillas\";
        //ExploracionPlanes.
        public string nombre { get; set; }
        public string etiqueta { get; set; }
        public bool esParaExtraccion { get; set; }
        public BindingList<IRestriccion> listaRestricciones { get; set; }
        public string nota { get; set; }
        public string path { get; set; }

        public static Plantilla crear(string _nombre, bool _esParaExtraccion, BindingList<IRestriccion> _listaRestricciones, string _nota)
        {
            Plantilla plantilla = new Plantilla()
            {
                nombre = _nombre,
                etiqueta = _nombre,
                esParaExtraccion = _esParaExtraccion,
                listaRestricciones = _listaRestricciones,
                nota  = _nota,
            };
            if (_esParaExtraccion)
            {
                plantilla.etiqueta += " (para Extracción)";
            }
            return plantilla;
        }

        public void guardar(bool edita, Plantilla plantillaAEditar = null)
        {
            if (!Directory.Exists(pathDestino))
            {
                Directory.CreateDirectory(pathDestino);
            }
            if (edita)
            {
                File.Delete(plantillaAEditar.path);
            }
            string fileName = IO.GetUniqueFilename(pathDestino, nombre);
            path = fileName;
            IO.writeObjectAsJson(path, this);
            MessageBox.Show("Se ha guardado la plantilla con el nombre: " + Path.GetFileName(path));
        }

        public void actualizarPath(string _nuevoPath)
        {
            path = _nuevoPath;
            IO.writeObjectAsJson(path, this);
        }

        public void duplicar(string nombreNuevo)
        {
            Plantilla duplicada = crear(nombreNuevo, this.esParaExtraccion, this.listaRestricciones, this.nota);
            duplicada.guardar(false);

        }


        public static List<Plantilla> leerPlantillas()
        {
            List<Plantilla> lista = new List<Plantilla>();
            if (Directory.Exists(pathDestino))
            {
                string[] plantillasPath = Directory.GetFiles(pathDestino);
                foreach (string plantillaPath in plantillasPath)
                {
                    Plantilla p = IO.readJson<Plantilla>(plantillaPath);
                    if (p.path!=plantillaPath)
                    {
                        p.actualizarPath(plantillaPath);
                    }
                    lista.Add(p);
                }
            }
            else
            {
                Directory.CreateDirectory(pathDestino);
            }
            return lista;
        }

        public List<Estructura> estructuras()
        {
            List<Estructura> estructuras = new List<Estructura>();
            foreach (IRestriccion restriccion in this.listaRestricciones)
            {
                if (!estructuras.Any(e=>e.nombre==restriccion.estructura.nombre))
                {
                    estructuras.Add(restriccion.estructura);
                }
            }
            return estructuras;
        }

        public List<Estructura> estructurasParaPrescribir()
        {
            List<Estructura> estructuras = new List<Estructura>();
            foreach (IRestriccion restriccion in this.listaRestricciones)
            {
                if (restriccion.dosisEstaEnPorcentaje() && !estructuras.Any(e => e.nombre == restriccion.estructura.nombre))
                {
                    estructuras.Add(restriccion.estructura);
                }
            }
            return estructuras;
        }

        public void eliminar()
        {
            if (MessageBox.Show("¿Desea eliminar la plantilla?","Eliminar Plantilla",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                File.Delete(path);
            }
        }

        public void editar(TextBox TB_nombre, CheckBox CHB_esParaExtraer, BindingList<IRestriccion> ListaRestricciones, TextBox TB_notaPlantilla)
        {
            TB_nombre.Text = nombre;
            if (esParaExtraccion)
            {
                CHB_esParaExtraer.Checked = true;
            }
            foreach(IRestriccion restriccion in listaRestricciones)
            {
                ListaRestricciones.Add(restriccion);
            }
            TB_notaPlantilla.Text = nota;
            
        }
    }
}
