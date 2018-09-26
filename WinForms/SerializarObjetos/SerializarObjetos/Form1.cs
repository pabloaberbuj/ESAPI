using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using VMS.TPS.Common.Model.API;
using VMS.TPS.Common.Model.Types;
using System.Xml;


namespace SerializarObjetos
{
    public partial class Form1 : Form
    {
        Patient paciente;
        Course curso;
        PlanSetup plan;

        public Form1()
        {
            InitializeComponent();
        }

        public void abrirPaciente(string ID)
        {
            try
            {
                VMS.TPS.Common.Model.API.Application app = VMS.TPS.Common.Model.API.Application.CreateApplication("pa", "123qwe");
                Patient paciente = app.OpenPatientById(ID);
                XmlWriter writer = XmlWriter.Create(paciente.Id + ".xml");
                writer.WriteStartDocument();
                
                paciente.WriteXml(writer);
                writer.WriteEndDocument();
                MessageBox.Show("terminó");
                app.ClosePatient();
            }
            catch (Exception e)
            {
                File.WriteAllText("log.txt", e.ToString());
                throw;
            }
        }

         private void button1_Click(object sender, EventArgs e)
        {
            abrirPaciente(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create("1744538.xml");
            paciente.ReadXml(xmlReader);
            MessageBox.Show("terminó");
        }
    }
}
