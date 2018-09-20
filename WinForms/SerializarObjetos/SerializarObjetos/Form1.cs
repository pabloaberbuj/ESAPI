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
                Serializador ser = new Serializador();
                ser.SerializeObject<Patient>(paciente, paciente.Id + ".txt");
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
            Serializador ser = new Serializador();
            Patient paciente = ser.DeSerializeObject<Patient>("1744538.txt");
            MessageBox.Show("terminó");
        }
    }
}
