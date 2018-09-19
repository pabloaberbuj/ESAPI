namespace ExploracionPlanes
{
    partial class Form2
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
            this.label4 = new System.Windows.Forms.Label();
            this.LB_Plantillas = new System.Windows.Forms.ListBox();
            this.BT_SeleccionarPlantillas = new System.Windows.Forms.Button();
            this.DGV_Estructuras = new System.Windows.Forms.DataGridView();
            this.dePlantilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delPlan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.L_ID = new System.Windows.Forms.Label();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_Análisis = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Analizar = new System.Windows.Forms.Button();
            this.BT_GuardarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estructuras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Análisis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // LB_Cursos
            // 
            this.LB_Cursos.FormattingEnabled = true;
            this.LB_Cursos.Location = new System.Drawing.Point(159, 33);
            this.LB_Cursos.Name = "LB_Cursos";
            this.LB_Cursos.Size = new System.Drawing.Size(94, 95);
            this.LB_Cursos.TabIndex = 1;
            this.LB_Cursos.SelectedIndexChanged += new System.EventHandler(this.LB_Cursos_SelectedIndexChanged);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(15, 33);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ID.TabIndex = 2;
            // 
            // BT_AbrirPaciente
            // 
            this.BT_AbrirPaciente.Location = new System.Drawing.Point(15, 76);
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
            this.LB_Planes.Location = new System.Drawing.Point(295, 33);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(104, 95);
            this.LB_Planes.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cursos";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(292, 17);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(39, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "Planes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Plantillas";
            // 
            // LB_Plantillas
            // 
            this.LB_Plantillas.FormattingEnabled = true;
            this.LB_Plantillas.Location = new System.Drawing.Point(12, 190);
            this.LB_Plantillas.Name = "LB_Plantillas";
            this.LB_Plantillas.Size = new System.Drawing.Size(120, 147);
            this.LB_Plantillas.TabIndex = 10;
            // 
            // BT_SeleccionarPlantillas
            // 
            this.BT_SeleccionarPlantillas.Location = new System.Drawing.Point(12, 358);
            this.BT_SeleccionarPlantillas.Name = "BT_SeleccionarPlantillas";
            this.BT_SeleccionarPlantillas.Size = new System.Drawing.Size(120, 23);
            this.BT_SeleccionarPlantillas.TabIndex = 11;
            this.BT_SeleccionarPlantillas.Text = "Seleccionar";
            this.BT_SeleccionarPlantillas.UseVisualStyleBackColor = true;
            this.BT_SeleccionarPlantillas.Click += new System.EventHandler(this.BT_SeleccionarPlantillas_Click);
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
            this.DGV_Estructuras.Location = new System.Drawing.Point(159, 190);
            this.DGV_Estructuras.Name = "DGV_Estructuras";
            this.DGV_Estructuras.Size = new System.Drawing.Size(240, 191);
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
            this.delPlan.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // L_ID
            // 
            this.L_ID.AutoSize = true;
            this.L_ID.Location = new System.Drawing.Point(12, 102);
            this.L_ID.Name = "L_ID";
            this.L_ID.Size = new System.Drawing.Size(35, 13);
            this.L_ID.TabIndex = 13;
            this.L_ID.Text = "label5";
            this.L_ID.Visible = false;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Location = new System.Drawing.Point(12, 124);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(35, 13);
            this.L_Nombre.TabIndex = 14;
            this.L_Nombre.Text = "label6";
            this.L_Nombre.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(156, 170);
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
            this.DGV_Análisis.Size = new System.Drawing.Size(239, 348);
            this.DGV_Análisis.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(472, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Compatibilizar estructuras";
            // 
            // BT_Analizar
            // 
            this.BT_Analizar.Location = new System.Drawing.Point(360, 148);
            this.BT_Analizar.Name = "BT_Analizar";
            this.BT_Analizar.Size = new System.Drawing.Size(109, 23);
            this.BT_Analizar.TabIndex = 18;
            this.BT_Analizar.Text = "Analizar";
            this.BT_Analizar.UseVisualStyleBackColor = true;
            // 
            // BT_GuardarPaciente
            // 
            this.BT_GuardarPaciente.Location = new System.Drawing.Point(65, 134);
            this.BT_GuardarPaciente.Name = "BT_GuardarPaciente";
            this.BT_GuardarPaciente.Size = new System.Drawing.Size(100, 23);
            this.BT_GuardarPaciente.TabIndex = 19;
            this.BT_GuardarPaciente.Text = "Guardar Paciente";
            this.BT_GuardarPaciente.UseVisualStyleBackColor = true;
            this.BT_GuardarPaciente.Click += new System.EventHandler(this.BT_GuardarPaciente_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 410);
            this.Controls.Add(this.BT_GuardarPaciente);
            this.Controls.Add(this.BT_Analizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_Análisis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.L_ID);
            this.Controls.Add(this.DGV_Estructuras);
            this.Controls.Add(this.BT_SeleccionarPlantillas);
            this.Controls.Add(this.LB_Plantillas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.BT_AbrirPaciente);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.LB_Cursos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estructuras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Análisis)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox LB_Plantillas;
        private System.Windows.Forms.Button BT_SeleccionarPlantillas;
        private System.Windows.Forms.DataGridView DGV_Estructuras;
        private System.Windows.Forms.Label L_ID;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_Análisis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Analizar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dePlantilla;
        private System.Windows.Forms.DataGridViewComboBoxColumn delPlan;
        private System.Windows.Forms.Button BT_GuardarPaciente;
    }
}