﻿namespace ExploracionPlanes
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NombrePlantilla = new System.Windows.Forms.TextBox();
            this.BT_GuardarPlantilla = new System.Windows.Forms.Button();
            this.CB_Estructura = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.CB_PrescripcionEstructura = new System.Windows.Forms.ComboBox();
            this.GB_PrescripcionEstructura = new System.Windows.Forms.GroupBox();
            this.BT_EliminarRestriccion = new System.Windows.Forms.Button();
            this.GB_NuevaRestriccion.SuspendLayout();
            this.GB_PrescripcionEstructura.SuspendLayout();
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
            this.CB_ValorEsperadoUnidades.SelectedIndexChanged += new System.EventHandler(this.CB_ValorEsperadoUnidades_SelectedIndexChanged);
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
            this.BT_AgregarALista.Location = new System.Drawing.Point(469, 126);
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
            this.GB_NuevaRestriccion.Controls.Add(this.GB_PrescripcionEstructura);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_Estructura);
            this.GB_NuevaRestriccion.Controls.Add(this.label2);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_TipoRestriccion);
            this.GB_NuevaRestriccion.Controls.Add(this.BT_AgregarALista);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_ValorEsperadoUnidades);
            this.GB_NuevaRestriccion.Controls.Add(this.L_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_ValorEsperado);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_MenorOMayor);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_CorrespAUnidades);
            this.GB_NuevaRestriccion.Location = new System.Drawing.Point(30, 53);
            this.GB_NuevaRestriccion.Name = "GB_NuevaRestriccion";
            this.GB_NuevaRestriccion.Size = new System.Drawing.Size(619, 168);
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
            // CB_Estructura
            // 
            this.CB_Estructura.FormattingEnabled = true;
            this.CB_Estructura.Location = new System.Drawing.Point(6, 42);
            this.CB_Estructura.Name = "CB_Estructura";
            this.CB_Estructura.Size = new System.Drawing.Size(100, 21);
            this.CB_Estructura.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "(donde 100% =";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(160, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Gy)";
            // 
            // CB_PrescripcionEstructura
            // 
            this.CB_PrescripcionEstructura.FormattingEnabled = true;
            this.CB_PrescripcionEstructura.Location = new System.Drawing.Point(90, 10);
            this.CB_PrescripcionEstructura.Name = "CB_PrescripcionEstructura";
            this.CB_PrescripcionEstructura.Size = new System.Drawing.Size(62, 21);
            this.CB_PrescripcionEstructura.TabIndex = 16;
            // 
            // GB_PrescripcionEstructura
            // 
            this.GB_PrescripcionEstructura.Controls.Add(this.label8);
            this.GB_PrescripcionEstructura.Controls.Add(this.CB_PrescripcionEstructura);
            this.GB_PrescripcionEstructura.Controls.Add(this.label9);
            this.GB_PrescripcionEstructura.Location = new System.Drawing.Point(388, 71);
            this.GB_PrescripcionEstructura.Name = "GB_PrescripcionEstructura";
            this.GB_PrescripcionEstructura.Size = new System.Drawing.Size(197, 37);
            this.GB_PrescripcionEstructura.TabIndex = 17;
            this.GB_PrescripcionEstructura.TabStop = false;
            this.GB_PrescripcionEstructura.Visible = false;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 372);
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
            this.GB_PrescripcionEstructura.ResumeLayout(false);
            this.GB_PrescripcionEstructura.PerformLayout();
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
        private System.Windows.Forms.GroupBox GB_PrescripcionEstructura;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox CB_PrescripcionEstructura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BT_EliminarRestriccion;
    }
}

