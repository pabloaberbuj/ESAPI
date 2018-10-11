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



        public static List<Plantilla> leerPlantillas()
        {
            List<Plantilla> lista = new List<Plantilla>();
            if (Directory.Exists(pathDestino))
            {
                string[] plantillas = Directory.GetFiles(pathDestino);
                foreach (string plantilla in plantillas)
                {
                    Plantilla p = IO.readJson<Plantilla>(plantilla);
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

        public void editar(TextBox TB_nombre, CheckBox CHB_esParaExtraer, BindingList<IRestriccion> ListaRestricciones)
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
            
        }
    }
}
