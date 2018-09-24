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
            this.Panel_esMenorque = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_ValorToleradoUnidades = new System.Windows.Forms.ComboBox();
            this.TB_ValorTolerado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EstructuraNombresAlt = new System.Windows.Forms.TextBox();
            this.CB_Estructura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NombrePlantilla = new System.Windows.Forms.TextBox();
            this.BT_GuardarPlantilla = new System.Windows.Forms.Button();
            this.BT_EliminarRestriccion = new System.Windows.Forms.Button();
            this.CHB_esParaExtraccion = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.GB_NuevaRestriccion.SuspendLayout();
            this.Panel_esMenorque.SuspendLayout();
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
            this.CB_MenorOMayor.Location = new System.Drawing.Point(17, 13);
            this.CB_MenorOMayor.Name = "CB_MenorOMayor";
            this.CB_MenorOMayor.Size = new System.Drawing.Size(41, 21);
            this.CB_MenorOMayor.TabIndex = 8;
            // 
            // CB_ValorEsperadoUnidades
            // 
            this.CB_ValorEsperadoUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ValorEsperadoUnidades.FormattingEnabled = true;
            this.CB_ValorEsperadoUnidades.Location = new System.Drawing.Point(139, 14);
            this.CB_ValorEsperadoUnidades.Name = "CB_ValorEsperadoUnidades";
            this.CB_ValorEsperadoUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_ValorEsperadoUnidades.TabIndex = 10;
            this.CB_ValorEsperadoUnidades.SelectedIndexChanged += new System.EventHandler(this.CB_ValorEsperadoUnidades_SelectedIndexChanged);
            // 
            // TB_ValorEsperado
            // 
            this.TB_ValorEsperado.Location = new System.Drawing.Point(64, 14);
            this.TB_ValorEsperado.Name = "TB_ValorEsperado";
            this.TB_ValorEsperado.Size = new System.Drawing.Size(69, 20);
            this.TB_ValorEsperado.TabIndex = 9;
            // 
            // BT_AgregarALista
            // 
            this.BT_AgregarALista.Location = new System.Drawing.Point(494, 136);
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
            this.LB_listaRestricciones.Location = new System.Drawing.Point(30, 246);
            this.LB_listaRestricciones.Name = "LB_listaRestricciones";
            this.LB_listaRestricciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LB_listaRestricciones.Size = new System.Drawing.Size(230, 108);
            this.LB_listaRestricciones.TabIndex = 12;
            // 
            // GB_NuevaRestriccion
            // 
            this.GB_NuevaRestriccion.Controls.Add(this.Panel_esMenorque);
            this.GB_NuevaRestriccion.Controls.Add(this.label3);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_EstructuraNombresAlt);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_Estructura);
            this.GB_NuevaRestriccion.Controls.Add(this.label2);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_TipoRestriccion);
            this.GB_NuevaRestriccion.Controls.Add(this.BT_AgregarALista);
            this.GB_NuevaRestriccion.Controls.Add(this.L_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_CorrespAUnidades);
            this.GB_NuevaRestriccion.Location = new System.Drawing.Point(30, 53);
            this.GB_NuevaRestriccion.Name = "GB_NuevaRestriccion";
            this.GB_NuevaRestriccion.Size = new System.Drawing.Size(619, 168);
            this.GB_NuevaRestriccion.TabIndex = 13;
            this.GB_NuevaRestriccion.TabStop = false;
            this.GB_NuevaRestriccion.Text = "Nueva Restricción";
            // 
            // Panel_esMenorque
            // 
            this.Panel_esMenorque.Controls.Add(this.label4);
            this.Panel_esMenorque.Controls.Add(this.CB_ValorToleradoUnidades);
            this.Panel_esMenorque.Controls.Add(this.CB_MenorOMayor);
            this.Panel_esMenorque.Controls.Add(this.TB_ValorEsperado);
            this.Panel_esMenorque.Controls.Add(this.TB_ValorTolerado);
            this.Panel_esMenorque.Controls.Add(this.CB_ValorEsperadoUnidades);
            this.Panel_esMenorque.Location = new System.Drawing.Point(420, 31);
            this.Panel_esMenorque.Name = "Panel_esMenorque";
            this.Panel_esMenorque.Size = new System.Drawing.Size(190, 68);
            this.Panel_esMenorque.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Tolerancia:";
            // 
            // CB_ValorToleradoUnidades
            // 
            this.CB_ValorToleradoUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ValorToleradoUnidades.FormattingEnabled = true;
            this.CB_ValorToleradoUnidades.Location = new System.Drawing.Point(139, 41);
            this.CB_ValorToleradoUnidades.Name = "CB_ValorToleradoUnidades";
            this.CB_ValorToleradoUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_ValorToleradoUnidades.TabIndex = 22;
            // 
            // TB_ValorTolerado
            // 
            this.TB_ValorTolerado.Location = new System.Drawing.Point(64, 41);
            this.TB_ValorTolerado.Name = "TB_ValorTolerado";
            this.TB_ValorTolerado.Size = new System.Drawing.Size(69, 20);
            this.TB_ValorTolerado.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres alternativos";
            // 
            // TB_EstructuraNombresAlt
            // 
            this.TB_EstructuraNombresAlt.Location = new System.Drawing.Point(6, 87);
            this.TB_EstructuraNombresAlt.Multiline = true;
            this.TB_EstructuraNombresAlt.Name = "TB_EstructuraNombresAlt";
            this.TB_EstructuraNombresAlt.Size = new System.Drawing.Size(100, 72);
            this.TB_EstructuraNombresAlt.TabIndex = 18;
            // 
            // CB_Estructura
            // 
            this.CB_Estructura.FormattingEnabled = true;
            this.CB_Estructura.Location = new System.Drawing.Point(6, 42);
            this.CB_Estructura.Name = "CB_Estructura";
            this.CB_Estructura.Size = new System.Drawing.Size(100, 21);
            this.CB_Estructura.TabIndex = 12;
            this.CB_Estructura.TextChanged += new System.EventHandler(this.CB_Estructura_TextChanged);
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
            // BT_GuardarPlantilla
            // 
            this.BT_GuardarPlantilla.Location = new System.Drawing.Point(283, 318);
            this.BT_GuardarPlantilla.Name = "BT_GuardarPlantilla";
            this.BT_GuardarPlantilla.Size = new System.Drawing.Size(128, 36);
            this.BT_GuardarPlantilla.TabIndex = 12;
            this.BT_GuardarPlantilla.Text = "Guardar plantilla";
            this.BT_GuardarPlantilla.UseVisualStyleBackColor = true;
            this.BT_GuardarPlantilla.Click += new System.EventHandler(this.BT_GuardarPlantilla_Click);
            // 
            // BT_EliminarRestriccion
            // 
            this.BT_EliminarRestriccion.Location = new System.Drawing.Point(283, 246);
            this.BT_EliminarRestriccion.Name = "BT_EliminarRestriccion";
            this.BT_EliminarRestriccion.Size = new System.Drawing.Size(128, 23);
            this.BT_EliminarRestriccion.TabIndex = 14;
            this.BT_EliminarRestriccion.Text = "Eliminar Restricciones";
            this.BT_EliminarRestriccion.UseVisualStyleBackColor = true;
            this.BT_EliminarRestriccion.Click += new System.EventHandler(this.BT_EliminarRestriccion_Click);
            // 
            // CHB_esParaExtraccion
            // 
            this.CHB_esParaExtraccion.AutoSize = true;
            this.CHB_esParaExtraccion.Location = new System.Drawing.Point(314, 13);
            this.CHB_esParaExtraccion.Name = "CHB_esParaExtraccion";
            this.CHB_esParaExtraccion.Size = new System.Drawing.Size(176, 17);
            this.CHB_esParaExtraccion.TabIndex = 15;
            this.CHB_esParaExtraccion.Text = "Es sólo para extraer información";
            this.CHB_esParaExtraccion.UseVisualStyleBackColor = true;
            this.CHB_esParaExtraccion.CheckedChanged += new System.EventHandler(this.CHB_esParaExtraccion_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Editar Restricciones";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 372);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CHB_esParaExtraccion);
            this.Controls.Add(this.BT_EliminarRestriccion);
            this.Controls.Add(this.BT_GuardarPlantilla);
            this.Controls.Add(this.TB_NombrePlantilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_NuevaRestriccion);
            this.Controls.Add(this.LB_listaRestricciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GB_NuevaRestriccion.ResumeLayout(false);
            this.GB_NuevaRestriccion.PerformLayout();
            this.Panel_esMenorque.ResumeLayout(false);
            this.Panel_esMenorque.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TipoRestriccion;
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
        private System.Windows.Forms.Button BT_GuardarPlantilla;
        private System.Windows.Forms.ComboBox CB_Estructura;
        private System.Windows.Forms.Button BT_EliminarRestriccion;
        private System.Windows.Forms.TextBox TB_EstructuraNombresAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_ValorToleradoUnidades;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_ValorTolerado;
        private System.Windows.Forms.CheckBox CHB_esParaExtraccion;
        private System.Windows.Forms.Panel Panel_esMenorque;
        private System.Windows.Forms.Button button1;
    }
}

