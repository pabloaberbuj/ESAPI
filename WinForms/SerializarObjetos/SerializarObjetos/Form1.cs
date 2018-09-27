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
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                settings.IndentChars = ("\t");
                XmlWriter writer = XmlWriter.Create(paciente.Id + ".xml",settings);
                writer.WriteStartDocument();
                writer.WriteStartElement("Patient");
                paciente.WriteXml(writer);
                writer.WriteEndElement();
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
            //XmlTextReader xmlReader = new XmlTextReader("15-36292.xml");
            //XmlReader xmlReader = XmlReader.Create("15-36292.xml");
            PacientePablo paciente = new PacientePablo();
            /paciente.ReadXml(XmlReader.Create("15-36292.xml"));
            /*while (xmlReader.Read())
            {
                
            }*/
            //XmlReaderSettings settings = new XmlReaderSettings();
            //xmlReader.ReadContentAs(typeof(Patient), null);
            //paciente.ReadXml(xmlReader);
            
            //Serializador ser = new Serializador();
            //paciente = ser.DeSerializeObject<PacientePablo>("15-36292.xml");
            //MessageBox.Show(paciente.Id + paciente.Name + paciente.Courses.First().PlanSetups.First().Name);
        }
    }
}
