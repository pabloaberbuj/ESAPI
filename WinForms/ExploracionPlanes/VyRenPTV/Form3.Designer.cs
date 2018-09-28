namespace ExploracionPlanes
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Cursos = new System.Windows.Forms.ListBox();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.BT_AbrirPaciente = new System.Windows.Forms.Button();
            this.LB_Planes = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.DGV_Estructuras = new System.Windows.Forms.DataGridView();
            this.dePlantilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delPlan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_Análisis = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Analizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_Prescripciones = new System.Windows.Forms.DataGridView();
            this.BT_SeleccionarPlan = new System.Windows.Forms.Button();
            this.BT_GuardarPaciente = new System.Windows.Forms.Button();
            this.BT_Exportar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estructuras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Análisis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prescripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // LB_Cursos
            // 
            this.LB_Cursos.FormattingEnabled = true;
            this.LB_Cursos.Location = new System.Drawing.Point(47, 125);
            this.LB_Cursos.Name = "LB_Cursos";
            this.LB_Cursos.Size = new System.Drawing.Size(104, 69);
            this.LB_Cursos.TabIndex = 1;
            this.LB_Cursos.SelectedIndexChanged += new System.EventHandler(this.LB_Cursos_SelectedIndexChanged);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(27, 15);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(119, 20);
            this.TB_ID.TabIndex = 2;
            // 
            // BT_AbrirPaciente
            // 
            this.BT_AbrirPaciente.Location = new System.Drawing.Point(46, 50);
            this.BT_AbrirPaciente.Name = "BT_AbrirPaciente";
            this.BT_AbrirPaciente.Size = new System.Drawing.Size(100, 23);
            this.BT_AbrirPaciente.TabIndex = 3;
            this.BT_AbrirPaciente.Text = "Abrir paciente";
            this.BT_AbrirPaciente.UseVisualStyleBackColor = true;
            this.BT_AbrirPaciente.Click += new System.EventHandler(this.BT_AbrirPaciente_Click);
            // 
            // LB_Planes
            // 
            this.LB_Planes.FormattingEnabled = true;
            this.LB_Planes.Location = new System.Drawing.Point(47, 203);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(104, 95);
            this.LB_Planes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cursos";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(3, 203);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Planes";
            // 
            // DGV_Estructuras
            // 
            this.DGV_Estructuras.AllowUserToAddRows = false;
            this.DGV_Estructuras.AllowUserToDeleteRows = false;
            this.DGV_Estructuras.AllowUserToResizeColumns = false;
            this.DGV_Estructuras.AllowUserToResizeRows = false;
            this.DGV_Estructuras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Estructuras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dePlantilla,
            this.delPlan});
            this.DGV_Estructuras.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.DGV_Estructuras.Location = new System.Drawing.Point(179, 33);
            this.DGV_Estructuras.Name = "DGV_Estructuras";
            this.DGV_Estructuras.RowHeadersVisible = false;
            this.DGV_Estructuras.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DGV_Estructuras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Estructuras.Size = new System.Drawing.Size(205, 191);
            this.DGV_Estructuras.TabIndex = 12;
            // 
            // dePlantilla
            // 
            this.dePlantilla.HeaderText = "Plantilla";
            this.dePlantilla.Name = "dePlantilla";
            // 
            // delPlan
            // 
            this.delPlan.AutoComplete = false;
            this.delPlan.HeaderText = "Plan";
            this.delPlan.Name = "delPlan";
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(3, 86);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(35, 13);
            this.L_ID.TabIndex = 13;
            this.L_ID.Text = "label5";
            this.L_ID.Visible = false;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(44, 86);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(35, 13);
            this.L_Nombre.TabIndex = 14;
            this.L_Nombre.Text = "label6";
            this.L_Nombre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Compatibilizar estructuras";
            // 
            // DGV_Análisis
            // 
            this.DGV_Análisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Análisis.Location = new System.Drawing.Point(475, 33);
            this.DGV_Análisis.Name = "DGV_Análisis";
            this.DGV_Análisis.RowHeadersVisible = false;
            this.DGV_Análisis.Size = new System.Drawing.Size(289, 348);
            this.DGV_Análisis.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Analizar";
            // 
            // BT_Analizar
            // 
            this.BT_Analizar.Location = new System.Drawing.Point(310, 246);
            this.BT_Analizar.Name = "BT_Analizar";
            this.BT_Analizar.Size = new System.Drawing.Size(109, 23);
            this.BT_Analizar.TabIndex = 18;
            this.BT_Analizar.Text = "Analizar";
            this.BT_Analizar.UseVisualStyleBackColor = true;
            this.BT_Analizar.Click += new System.EventHandler(this.BT_Analizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(176, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Ajustar prescripciones";
            // 
            // DGV_Prescripciones
            // 
            this.DGV_Prescripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Prescripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_Prescripciones.Location = new System.Drawing.Point(179, 307);
            this.DGV_Prescripciones.Name = "DGV_Prescripciones";
            this.DGV_Prescripciones.RowHeadersVisible = false;
            this.DGV_Prescripciones.Size = new System.Drawing.Size(205, 164);
            this.DGV_Prescripciones.TabIndex = 21;
            // 
            // BT_SeleccionarPlan
            // 
            this.BT_SeleccionarPlan.Location = new System.Drawing.Point(42, 307);
            this.BT_SeleccionarPlan.Name = "BT_SeleccionarPlan";
            this.BT_SeleccionarPlan.Size = new System.Drawing.Size(109, 23);
            this.BT_SeleccionarPlan.TabIndex = 22;
            this.BT_SeleccionarPlan.Text = "Seleccionar plan";
            this.BT_SeleccionarPlan.UseVisualStyleBackColor = true;
            this.BT_SeleccionarPlan.Click += new System.EventHandler(this.BT_SeleccionarPlan_Click);
            // 
            // BT_GuardarPaciente
            // 
            this.BT_GuardarPaciente.Location = new System.Drawing.Point(475, 398);
            this.BT_GuardarPaciente.Name = "BT_GuardarPaciente";
            this.BT_GuardarPaciente.Size = new System.Drawing.Size(109, 37);
            this.BT_GuardarPaciente.TabIndex = 23;
            this.BT_GuardarPaciente.Text = "Guardar y cerrar paciente";
            this.BT_GuardarPaciente.UseVisualStyleBackColor = true;
            this.BT_GuardarPaciente.Click += new System.EventHandler(this.BT_GuardarPaciente_Click);
            // 
            // BT_Exportar
            // 
            this.BT_Exportar.Location = new System.Drawing.Point(655, 398);
            this.BT_Exportar.Name = "BT_Exportar";
            this.BT_Exportar.Size = new System.Drawing.Size(109, 37);
            this.BT_Exportar.TabIndex = 24;
            this.BT_Exportar.Text = "Exportar información";
            this.BT_Exportar.UseVisualStyleBackColor = true;
            this.BT_Exportar.Click += new System.EventHandler(this.BT_Exportar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estructura";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prescripción";
            this.Column2.Name = "Column2";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 499);
            this.Controls.Add(this.BT_Exportar);
            this.Controls.Add(this.BT_GuardarPaciente);
            this.Controls.Add(this.BT_SeleccionarPlan);
            this.Controls.Add(this.DGV_Prescripciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BT_Analizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_Análisis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.L_ID);
            this.Controls.Add(this.DGV_Estructuras);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.BT_AbrirPaciente);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.LB_Cursos);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form3_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estructuras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Análisis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prescripciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Cursos;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.Button BT_AbrirPaciente;
        private System.Windows.Forms.ListBox LB_Planes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Label3;
        private System.Windows.Forms.DataGridView DGV_Estructuras;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_Análisis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Analizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_Prescripciones;
        private System.Windows.Forms.Button BT_SeleccionarPlan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dePlantilla;
        private System.Windows.Forms.DataGridViewComboBoxColumn delPlan;
        private System.Windows.Forms.Button BT_GuardarPaciente;
        private System.Windows.Forms.Button BT_Exportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}