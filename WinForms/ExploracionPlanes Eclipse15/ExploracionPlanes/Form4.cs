using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ExploracionPlanes
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            List<Plantilla> lista = Plantilla.leerPlantillas();
            string[] estructuras = new string[1000];
            int i = 0;
            foreach (Plantilla plantilla in lista)
            {
                foreach (IRestriccion restriccion in plantilla.listaRestricciones)
                {
                    estructuras[i] = restriccion.estructura.nombre;
                    i++;
                }
            }
            File.WriteAllLines("estructuras.txt", estructuras);
        }
    }
}
