namespace ExploracionPlanes
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CB_TipoRestriccion = new System.Windows.Forms.ComboBox();
            this.TB_Estructura = new System.Windows.Forms.TextBox();
            this.L_CorrespA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_CorrespAUnidades = new System.Windows.Forms.ComboBox();
            this.TB_CorrespA = new System.Windows.Forms.TextBox();
            this.CB_MenorOMayor = new System.Windows.Forms.ComboBox();
            this.CB_ValorEsperadoUnidades = new System.Windows.Forms.ComboBox();
            this.TB_ValorEsperado = new System.Windows.Forms.TextBox();
            this.BT_AgregarALista = new System.Windows.Forms.Button();
            this.LB_listaRestricciones = new System.Windows.Forms.ListBox();
            this.GB_NuevaRestriccion = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NombrePlantilla = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.BT_GuardarPlantilla = new System.Windows.Forms.Button();
            this.GB_NuevaRestriccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_TipoRestriccion
            // 
            this.CB_TipoRestriccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoRestriccion.FormattingEnabled = true;
            this.CB_TipoRestriccion.Items.AddRange(new object[] {
            "Dosis",
            "Dmedia",
            "Dmax",
            "Volumen"});
            this.CB_TipoRestriccion.Location = new System.Drawing.Point(112, 42);
            this.CB_TipoRestriccion.Name = "CB_TipoRestriccion";
            this.CB_TipoRestriccion.Size = new System.Drawing.Size(86, 21);
            this.CB_TipoRestriccion.TabIndex = 0;
            this.CB_TipoRestriccion.SelectedIndexChanged += new System.EventHandler(this.CB_TipoRestriccion_SelectedIndexChanged);
            // 
            // TB_Estructura
            // 
            this.TB_Estructura.Location = new System.Drawing.Point(6, 42);
            this.TB_Estructura.Name = "TB_Estructura";
            this.TB_Estructura.Size = new System.Drawing.Size(100, 20);
            this.TB_Estructura.TabIndex = 1;
            // 
            // L_CorrespA
            // 
            this.L_CorrespA.AutoSize = true;
            this.L_CorrespA.Location = new System.Drawing.Point(204, 40);
            this.L_CorrespA.Name = "L_CorrespA";
            this.L_CorrespA.Size = new System.Drawing.Size(35, 13);
            this.L_CorrespA.TabIndex = 2;
            this.L_CorrespA.Text = "label1";
            this.L_CorrespA.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estructura";
            // 
            // CB_CorrespAUnidades
            // 
            this.CB_CorrespAUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CorrespAUnidades.FormattingEnabled = true;
            this.CB_CorrespAUnidades.Location = new System.Drawing.Point(375, 43);
            this.CB_CorrespAUnidades.Name = "CB_CorrespAUnidades";
            this.CB_CorrespAUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_CorrespAUnidades.TabIndex = 7;
            // 
            // TB_CorrespA
            // 
            this.TB_CorrespA.Location = new System.Drawing.Point(300, 43);
            this.TB_CorrespA.Name = "TB_CorrespA";
            this.TB_CorrespA.Size = new System.Drawing.Size(69, 20);
            this.TB_CorrespA.TabIndex = 6;
            // 
            // CB_MenorOMayor
            // 
            this.CB_MenorOMayor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MenorOMayor.FormattingEnabled = true;
            this.CB_MenorOMayor.Items.AddRange(new object[] {
            "<",
            ">"});
            this.CB_MenorOMayor.Location = new System.Drawing.Point(422, 43);
            this.CB_MenorOMayor.Name = "CB_MenorOMayor";
            this.CB_MenorOMayor.Size = new System.Drawing.Size(41, 21);
            this.CB_MenorOMayor.TabIndex = 8;
            // 
            // CB_ValorEsperadoUnidades
            // 
            this.CB_ValorEsperadoUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ValorEsperadoUnidades.FormattingEnabled = true;
            this.CB_ValorEsperadoUnidades.Location = new System.Drawing.Point(544, 44);
            this.CB_ValorEsperadoUnidades.Name = "CB_ValorEsperadoUnidades";
            this.CB_ValorEsperadoUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_ValorEsperadoUnidades.TabIndex = 10;
            // 
            // TB_ValorEsperado
            // 
            this.TB_ValorEsperado.Location = new System.Drawing.Point(469, 44);
            this.TB_ValorEsperado.Name = "TB_ValorEsperado";
            this.TB_ValorEsperado.Size = new System.Drawing.Size(69, 20);
            this.TB_ValorEsperado.TabIndex = 9;
            // 
            // BT_AgregarALista
            // 
            this.BT_AgregarALista.Location = new System.Drawing.Point(482, 100);
            this.BT_AgregarALista.Name = "BT_AgregarALista";
            this.BT_AgregarALista.Size = new System.Drawing.Size(116, 23);
            this.BT_AgregarALista.TabIndex = 11;
            this.BT_AgregarALista.Text = "Agregar a la lista";
            this.BT_AgregarALista.UseVisualStyleBackColor = true;
            this.BT_AgregarALista.Click += new System.EventHandler(this.BT_AgregarALista_Click);
            // 
            // LB_listaRestricciones
            // 
            this.LB_listaRestricciones.FormattingEnabled = true;
            this.LB_listaRestricciones.Location = new System.Drawing.Point(21, 302);
            this.LB_listaRestricciones.Name = "LB_listaRestricciones";
            this.LB_listaRestricciones.Size = new System.Drawing.Size(230, 108);
            this.LB_listaRestricciones.TabIndex = 12;
            // 
            // GB_NuevaRestriccion
            // 
            this.GB_NuevaRestriccion.Controls.Add(this.label2);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_TipoRestriccion);
            this.GB_NuevaRestriccion.Controls.Add(this.BT_AgregarALista);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_Estructura);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_ValorEsperadoUnidades);
            this.GB_NuevaRestriccion.Controls.Add(this.L_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_ValorEsperado);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_MenorOMayor);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_CorrespAUnidades);
            this.GB_NuevaRestriccion.Location = new System.Drawing.Point(21, 150);
            this.GB_NuevaRestriccion.Name = "GB_NuevaRestriccion";
            this.GB_NuevaRestriccion.Size = new System.Drawing.Size(619, 129);
            this.GB_NuevaRestriccion.TabIndex = 13;
            this.GB_NuevaRestriccion.TabStop = false;
            this.GB_NuevaRestriccion.Text = "Nueva Restricción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre";
            // 
            // TB_NombrePlantilla
            // 
            this.TB_NombrePlantilla.Location = new System.Drawing.Point(97, 13);
            this.TB_NombrePlantilla.Name = "TB_NombrePlantilla";
            this.TB_NombrePlantilla.Size = new System.Drawing.Size(192, 20);
            this.TB_NombrePlantilla.TabIndex = 12;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(164, 46);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(55, 20);
            this.textBox2.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Prescripción";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(234, 46);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(55, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(234, 72);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(55, 20);
            this.textBox4.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(164, 72);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(55, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(234, 98);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(55, 20);
            this.textBox6.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(164, 98);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(55, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(234, 124);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(55, 20);
            this.textBox8.TabIndex = 18;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(164, 124);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(55, 20);
            this.textBox9.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Gy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Gy";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(295, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Gy";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(295, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Gy";
            // 
            // BT_GuardarPlantilla
            // 
            this.BT_GuardarPlantilla.Location = new System.Drawing.Point(283, 387);
            this.BT_GuardarPlantilla.Name = "BT_GuardarPlantilla";
            this.BT_GuardarPlantilla.Size = new System.Drawing.Size(116, 23);
            this.BT_GuardarPlantilla.TabIndex = 12;
            this.BT_GuardarPlantilla.Text = "Guardar plantilla";
            this.BT_GuardarPlantilla.UseVisualStyleBackColor = true;
            this.BT_GuardarPlantilla.Click += new System.EventHandler(this.BT_GuardarPlantilla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 438);
            this.Controls.Add(this.BT_GuardarPlantilla);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_NombrePlantilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_NuevaRestriccion);
            this.Controls.Add(this.LB_listaRestricciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GB_NuevaRestriccion.ResumeLayout(false);
            this.GB_NuevaRestriccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TipoRestriccion;
        private System.Windows.Forms.TextBox TB_Estructura;
        private System.Windows.Forms.Label L_CorrespA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_CorrespAUnidades;
        private System.Windows.Forms.TextBox TB_CorrespA;
        private System.Windows.Forms.ComboBox CB_MenorOMayor;
        private System.Windows.Forms.ComboBox CB_ValorEsperadoUnidades;
        private System.Windows.Forms.TextBox TB_ValorEsperado;
        private System.Windows.Forms.Button BT_AgregarALista;
        private System.Windows.Forms.ListBox LB_listaRestricciones;
        private System.Windows.Forms.GroupBox GB_NuevaRestriccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NombrePlantilla;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button BT_GuardarPlantilla;
    }
}

