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
            this.CB_TipoRestriccion.Location = new System.Drawing.Point(118, 70);
            this.CB_TipoRestriccion.Name = "CB_TipoRestriccion";
            this.CB_TipoRestriccion.Size = new System.Drawing.Size(86, 21);
            this.CB_TipoRestriccion.TabIndex = 0;
            this.CB_TipoRestriccion.SelectedIndexChanged += new System.EventHandler(this.CB_TipoRestriccion_SelectedIndexChanged);
            // 
            // TB_Estructura
            // 
            this.TB_Estructura.Location = new System.Drawing.Point(12, 70);
            this.TB_Estructura.Name = "TB_Estructura";
            this.TB_Estructura.Size = new System.Drawing.Size(100, 20);
            this.TB_Estructura.TabIndex = 1;
            // 
            // L_CorrespA
            // 
            this.L_CorrespA.AutoSize = true;
            this.L_CorrespA.Location = new System.Drawing.Point(210, 68);
            this.L_CorrespA.Name = "L_CorrespA";
            this.L_CorrespA.Size = new System.Drawing.Size(35, 13);
            this.L_CorrespA.TabIndex = 2;
            this.L_CorrespA.Text = "label1";
            this.L_CorrespA.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estructura";
            // 
            // CB_CorrespAUnidades
            // 
            this.CB_CorrespAUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CorrespAUnidades.FormattingEnabled = true;
            this.CB_CorrespAUnidades.Location = new System.Drawing.Point(381, 71);
            this.CB_CorrespAUnidades.Name = "CB_CorrespAUnidades";
            this.CB_CorrespAUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_CorrespAUnidades.TabIndex = 7;
            // 
            // TB_CorrespA
            // 
            this.TB_CorrespA.Location = new System.Drawing.Point(306, 71);
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
            this.CB_MenorOMayor.Location = new System.Drawing.Point(428, 71);
            this.CB_MenorOMayor.Name = "CB_MenorOMayor";
            this.CB_MenorOMayor.Size = new System.Drawing.Size(41, 21);
            this.CB_MenorOMayor.TabIndex = 8;
            // 
            // CB_ValorEsperadoUnidades
            // 
            this.CB_ValorEsperadoUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ValorEsperadoUnidades.FormattingEnabled = true;
            this.CB_ValorEsperadoUnidades.Location = new System.Drawing.Point(550, 72);
            this.CB_ValorEsperadoUnidades.Name = "CB_ValorEsperadoUnidades";
            this.CB_ValorEsperadoUnidades.Size = new System.Drawing.Size(41, 21);
            this.CB_ValorEsperadoUnidades.TabIndex = 10;
            // 
            // TB_ValorEsperado
            // 
            this.TB_ValorEsperado.Location = new System.Drawing.Point(475, 72);
            this.TB_ValorEsperado.Name = "TB_ValorEsperado";
            this.TB_ValorEsperado.Size = new System.Drawing.Size(69, 20);
            this.TB_ValorEsperado.TabIndex = 9;
            // 
            // BT_AgregarALista
            // 
            this.BT_AgregarALista.Location = new System.Drawing.Point(428, 115);
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
            this.LB_listaRestricciones.Location = new System.Drawing.Point(15, 174);
            this.LB_listaRestricciones.Name = "LB_listaRestricciones";
            this.LB_listaRestricciones.Size = new System.Drawing.Size(230, 95);
            this.LB_listaRestricciones.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 403);
            this.Controls.Add(this.LB_listaRestricciones);
            this.Controls.Add(this.BT_AgregarALista);
            this.Controls.Add(this.CB_ValorEsperadoUnidades);
            this.Controls.Add(this.TB_ValorEsperado);
            this.Controls.Add(this.CB_MenorOMayor);
            this.Controls.Add(this.CB_CorrespAUnidades);
            this.Controls.Add(this.TB_CorrespA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_CorrespA);
            this.Controls.Add(this.TB_Estructura);
            this.Controls.Add(this.CB_TipoRestriccion);
            this.Name = "Form1";
            this.Text = "Form1";
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
    }
}

