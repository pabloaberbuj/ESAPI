namespace ExploracionPlanes
{
    partial class ImportarNombresEstructuras
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
            this.L_NombrePaciente = new System.Windows.Forms.Label();
            this.BT_SeleccionarPlan = new System.Windows.Forms.Button();
            this.LB_Planes = new System.Windows.Forms.ListBox();
            this.BT_AbrirPaciente = new System.Windows.Forms.Button();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.LB_Cursos = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_SeleccionarTodas = new System.Windows.Forms.Button();
            this.CHLB_Estructuras = new System.Windows.Forms.CheckedListBox();
            this.BT_Importar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // L_NombrePaciente
            // 
            this.L_NombrePaciente.AutoSize = true;
            this.L_NombrePaciente.Location = new System.Drawing.Point(213, 19);
            this.L_NombrePaciente.Name = "L_NombrePaciente";
            this.L_NombrePaciente.Size = new System.Drawing.Size(89, 13);
            this.L_NombrePaciente.TabIndex = 36;
            this.L_NombrePaciente.Text = "Nombre Paciente";
            this.L_NombrePaciente.Visible = false;
            // 
            // BT_SeleccionarPlan
            // 
            this.BT_SeleccionarPlan.Location = new System.Drawing.Point(70, 283);
            this.BT_SeleccionarPlan.Name = "BT_SeleccionarPlan";
            this.BT_SeleccionarPlan.Size = new System.Drawing.Size(119, 22);
            this.BT_SeleccionarPlan.TabIndex = 34;
            this.BT_SeleccionarPlan.Text = "Seleccionar plan";
            this.BT_SeleccionarPlan.UseVisualStyleBackColor = true;
            this.BT_SeleccionarPlan.Click += new System.EventHandler(this.BT_SeleccionarPlan_Click);
            // 
            // LB_Planes
            // 
            this.LB_Planes.FormattingEnabled = true;
            this.LB_Planes.Location = new System.Drawing.Point(70, 175);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(119, 95);
            this.LB_Planes.TabIndex = 31;
            // 
            // BT_AbrirPaciente
            // 
            this.BT_AbrirPaciente.Location = new System.Drawing.Point(70, 42);
            this.BT_AbrirPaciente.Name = "BT_AbrirPaciente";
            this.BT_AbrirPaciente.Size = new System.Drawing.Size(119, 22);
            this.BT_AbrirPaciente.TabIndex = 30;
            this.BT_AbrirPaciente.Text = "Abrir paciente";
            this.BT_AbrirPaciente.UseVisualStyleBackColor = true;
            this.BT_AbrirPaciente.Click += new System.EventHandler(this.BT_AbrirPaciente_Click);
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(70, 16);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(119, 20);
            this.TB_ID.TabIndex = 29;
            // 
            // LB_Cursos
            // 
            this.LB_Cursos.FormattingEnabled = true;
            this.LB_Cursos.Location = new System.Drawing.Point(70, 71);
            this.LB_Cursos.Name = "LB_Cursos";
            this.LB_Cursos.Size = new System.Drawing.Size(119, 69);
            this.LB_Cursos.TabIndex = 28;
            this.LB_Cursos.SelectedIndexChanged += new System.EventHandler(this.LB_Cursos_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Cursos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Planes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(213, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Estructuras";
            this.label4.Visible = false;
            // 
            // BT_SeleccionarTodas
            // 
            this.BT_SeleccionarTodas.Location = new System.Drawing.Point(279, 283);
            this.BT_SeleccionarTodas.Name = "BT_SeleccionarTodas";
            this.BT_SeleccionarTodas.Size = new System.Drawing.Size(120, 21);
            this.BT_SeleccionarTodas.TabIndex = 41;
            this.BT_SeleccionarTodas.Text = "Seleccionar todas";
            this.BT_SeleccionarTodas.UseVisualStyleBackColor = true;
            this.BT_SeleccionarTodas.Click += new System.EventHandler(this.BT_SeleccionarTodas_Click);
            // 
            // CHLB_Estructuras
            // 
            this.CHLB_Estructuras.CheckOnClick = true;
            this.CHLB_Estructuras.FormattingEnabled = true;
            this.CHLB_Estructuras.Location = new System.Drawing.Point(279, 71);
            this.CHLB_Estructuras.Name = "CHLB_Estructuras";
            this.CHLB_Estructuras.Size = new System.Drawing.Size(120, 199);
            this.CHLB_Estructuras.TabIndex = 42;
            // 
            // BT_Importar
            // 
            this.BT_Importar.Location = new System.Drawing.Point(279, 317);
            this.BT_Importar.Name = "BT_Importar";
            this.BT_Importar.Size = new System.Drawing.Size(120, 29);
            this.BT_Importar.TabIndex = 43;
            this.BT_Importar.Text = "Importar";
            this.BT_Importar.UseVisualStyleBackColor = true;
            this.BT_Importar.Click += new System.EventHandler(this.BT_Importar_Click);
            // 
            // ImportarNombresEstructuras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 375);
            this.Controls.Add(this.BT_Importar);
            this.Controls.Add(this.CHLB_Estructuras);
            this.Controls.Add(this.BT_SeleccionarTodas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.L_NombrePaciente);
            this.Controls.Add(this.BT_SeleccionarPlan);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.BT_AbrirPaciente);
            this.Controls.Add(this.TB_ID);
            this.Controls.Add(this.LB_Cursos);
            this.Controls.Add(this.label1);
            this.Name = "ImportarNombresEstructuras";
            this.Text = "Importar nombres de estructuras";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_NombrePaciente;
        private System.Windows.Forms.Button BT_SeleccionarPlan;
        private System.Windows.Forms.ListBox LB_Planes;
        private System.Windows.Forms.Button BT_AbrirPaciente;
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.ListBox LB_Cursos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_SeleccionarTodas;
        private System.Windows.Forms.CheckedListBox CHLB_Estructuras;
        private System.Windows.Forms.Button BT_Importar;
    }
}