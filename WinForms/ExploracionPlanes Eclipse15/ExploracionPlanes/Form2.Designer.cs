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
            this.DGV_Estructuras = new System.Windows.Forms.DataGridView();
            this.dePlantilla = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delPlan = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_Análisis = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.BT_Analizar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.DGV_Prescripciones = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_SeleccionarPlan = new System.Windows.Forms.Button();
            this.BT_Imprimir = new System.Windows.Forms.Button();
            this.BT_GuardarReporte = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.L_NombrePaciente = new System.Windows.Forms.Label();
            this.EstructuraCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volumen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ref = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VolumenDmax = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Estructuras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Análisis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Prescripciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // LB_Cursos
            // 
            this.LB_Cursos.FormattingEnabled = true;
            this.LB_Cursos.Location = new System.Drawing.Point(32, 162);
            this.LB_Cursos.Name = "LB_Cursos";
            this.LB_Cursos.Size = new System.Drawing.Size(119, 69);
            this.LB_Cursos.TabIndex = 1;
            this.LB_Cursos.SelectedIndexChanged += new System.EventHandler(this.LB_Cursos_SelectedIndexChanged);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(32, 30);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(119, 20);
            this.TB_ID.TabIndex = 2;
            this.TB_ID.TextChanged += new System.EventHandler(this.TB_ID_TextChanged);
            // 
            // BT_AbrirPaciente
            // 
            this.BT_AbrirPaciente.Enabled = false;
            this.BT_AbrirPaciente.Location = new System.Drawing.Point(32, 56);
            this.BT_AbrirPaciente.Name = "BT_AbrirPaciente";
            this.BT_AbrirPaciente.Size = new System.Drawing.Size(119, 33);
            this.BT_AbrirPaciente.TabIndex = 3;
            this.BT_AbrirPaciente.Text = "Abrir paciente";
            this.BT_AbrirPaciente.UseVisualStyleBackColor = true;
            this.BT_AbrirPaciente.Click += new System.EventHandler(this.BT_AbrirPaciente_Click);
            // 
            // LB_Planes
            // 
            this.LB_Planes.FormattingEnabled = true;
            this.LB_Planes.Location = new System.Drawing.Point(32, 272);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(119, 95);
            this.LB_Planes.TabIndex = 5;
            this.LB_Planes.SelectedIndexChanged += new System.EventHandler(this.LB_Planes_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "2. Seleccionar curso";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(29, 249);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(98, 13);
            this.Label3.TabIndex = 8;
            this.Label3.Text = "3. Seleccionar plan";
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
            this.DGV_Estructuras.Location = new System.Drawing.Point(179, 30);
            this.DGV_Estructuras.Name = "DGV_Estructuras";
            this.DGV_Estructuras.RowHeadersVisible = false;
            this.DGV_Estructuras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Estructuras.Size = new System.Drawing.Size(255, 529);
            this.DGV_Estructuras.TabIndex = 12;
            this.DGV_Estructuras.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_Estructuras_RowsAdded);
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
            this.delPlan.Width = 150;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(245, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "4. Asociar estructuras";
            // 
            // DGV_Análisis
            // 
            this.DGV_Análisis.AllowUserToAddRows = false;
            this.DGV_Análisis.AllowUserToDeleteRows = false;
            this.DGV_Análisis.AllowUserToResizeRows = false;
            this.DGV_Análisis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Análisis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EstructuraCol,
            this.Column3,
            this.Volumen,
            this.Column4,
            this.Column5,
            this.Ref,
            this.VolumenDmax});
            this.DGV_Análisis.Location = new System.Drawing.Point(688, 28);
            this.DGV_Análisis.Name = "DGV_Análisis";
            this.DGV_Análisis.RowHeadersVisible = false;
            this.DGV_Análisis.Size = new System.Drawing.Size(485, 531);
            this.DGV_Análisis.TabIndex = 16;
            this.DGV_Análisis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Análisis_CellContentClick);
            this.DGV_Análisis.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DGV_Análisis_RowsAdded);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(867, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "6. Analizar";
            // 
            // BT_Analizar
            // 
            this.BT_Analizar.Enabled = false;
            this.BT_Analizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Analizar.Location = new System.Drawing.Point(708, 565);
            this.BT_Analizar.Name = "BT_Analizar";
            this.BT_Analizar.Size = new System.Drawing.Size(109, 33);
            this.BT_Analizar.TabIndex = 18;
            this.BT_Analizar.Text = "Analizar";
            this.BT_Analizar.UseVisualStyleBackColor = true;
            this.BT_Analizar.Click += new System.EventHandler(this.BT_Analizar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(504, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "5. Ajustar prescripciones";
            // 
            // DGV_Prescripciones
            // 
            this.DGV_Prescripciones.AllowUserToAddRows = false;
            this.DGV_Prescripciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Prescripciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.DGV_Prescripciones.Location = new System.Drawing.Point(461, 28);
            this.DGV_Prescripciones.Name = "DGV_Prescripciones";
            this.DGV_Prescripciones.RowHeadersVisible = false;
            this.DGV_Prescripciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.DGV_Prescripciones.Size = new System.Drawing.Size(205, 164);
            this.DGV_Prescripciones.TabIndex = 21;
            this.DGV_Prescripciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_Prescripciones_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Estructura";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Prescripción (Gy)";
            this.Column2.Name = "Column2";
            // 
            // BT_SeleccionarPlan
            // 
            this.BT_SeleccionarPlan.Enabled = false;
            this.BT_SeleccionarPlan.Location = new System.Drawing.Point(32, 376);
            this.BT_SeleccionarPlan.Name = "BT_SeleccionarPlan";
            this.BT_SeleccionarPlan.Size = new System.Drawing.Size(119, 51);
            this.BT_SeleccionarPlan.TabIndex = 22;
            this.BT_SeleccionarPlan.Text = "Seleccionar plan";
            this.BT_SeleccionarPlan.UseVisualStyleBackColor = true;
            this.BT_SeleccionarPlan.Click += new System.EventHandler(this.BT_SeleccionarPlan_Click);
            // 
            // BT_Imprimir
            // 
            this.BT_Imprimir.Enabled = false;
            this.BT_Imprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Imprimir.Location = new System.Drawing.Point(972, 565);
            this.BT_Imprimir.Name = "BT_Imprimir";
            this.BT_Imprimir.Size = new System.Drawing.Size(109, 33);
            this.BT_Imprimir.TabIndex = 23;
            this.BT_Imprimir.Text = "Imprimir";
            this.BT_Imprimir.UseVisualStyleBackColor = true;
            this.BT_Imprimir.Click += new System.EventHandler(this.BT_Imprimir_Click);
            // 
            // BT_GuardarReporte
            // 
            this.BT_GuardarReporte.Enabled = false;
            this.BT_GuardarReporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_GuardarReporte.Location = new System.Drawing.Point(829, 565);
            this.BT_GuardarReporte.Name = "BT_GuardarReporte";
            this.BT_GuardarReporte.Size = new System.Drawing.Size(131, 33);
            this.BT_GuardarReporte.TabIndex = 24;
            this.BT_GuardarReporte.Text = "Guardar Reporte";
            this.BT_GuardarReporte.UseVisualStyleBackColor = true;
            this.BT_GuardarReporte.Click += new System.EventHandler(this.BT_GuardarReporte_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "1. Elegir paciente\r\n";
            // 
            // L_NombrePaciente
            // 
            this.L_NombrePaciente.AutoSize = true;
            this.L_NombrePaciente.Location = new System.Drawing.Point(29, 104);
            this.L_NombrePaciente.Name = "L_NombrePaciente";
            this.L_NombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.L_NombrePaciente.TabIndex = 26;
            this.L_NombrePaciente.Text = "Nombre Paciente";
            this.L_NombrePaciente.Visible = false;
            // 
            // EstructuraCol
            // 
            this.EstructuraCol.HeaderText = "Estructura";
            this.EstructuraCol.Name = "EstructuraCol";
            this.EstructuraCol.Width = 60;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Métrica";
            this.Column3.Name = "Column3";
            this.Column3.Width = 60;
            // 
            // Volumen
            // 
            this.Volumen.HeaderText = "Vol [cm3]";
            this.Volumen.Name = "Volumen";
            this.Volumen.Width = 60;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "En Plan";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Esperado";
            this.Column5.Name = "Column5";
            // 
            // Ref
            // 
            this.Ref.HeaderText = "Ref.";
            this.Ref.Name = "Ref";
            this.Ref.Width = 40;
            // 
            // VolumenDmax
            // 
            this.VolumenDmax.HeaderText = "";
            this.VolumenDmax.Name = "VolumenDmax";
            this.VolumenDmax.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.VolumenDmax.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.VolumenDmax.Width = 30;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 610);
            this.Controls.Add(this.L_NombrePaciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_GuardarReporte);
            this.Controls.Add(this.BT_Imprimir);
            this.Controls.Add(this.BT_SeleccionarPlan);
            this.Controls.Add(this.DGV_Prescripciones);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BT_Analizar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DGV_Análisis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_Estructuras);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.BT_AbrirPaciente);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.LB_Cursos);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form2_FormClosing);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_Análisis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button BT_Analizar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView DGV_Prescripciones;
        private System.Windows.Forms.Button BT_SeleccionarPlan;
        private System.Windows.Forms.Button BT_Imprimir;
        private System.Windows.Forms.Button BT_GuardarReporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn dePlantilla;
        private System.Windows.Forms.DataGridViewComboBoxColumn delPlan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_NombrePaciente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstructuraCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volumen;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ref;
        private System.Windows.Forms.DataGridViewButtonColumn VolumenDmax;
    }
}