namespace WinForm2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Curso = new System.Windows.Forms.Label();
            this.TB_HC = new System.Windows.Forms.TextBox();
            this.BT_Buscar = new System.Windows.Forms.Button();
            this.LB_Planes = new System.Windows.Forms.ListBox();
            this.L_Paciente = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.L_EstadoPlan = new System.Windows.Forms.Label();
            this.L_NumCampos = new System.Windows.Forms.Label();
            this.L_UMTotales = new System.Windows.Forms.Label();
            this.LB_Estructuras = new System.Windows.Forms.ListBox();
            this.L_Volumen = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "HC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Paciente:";
            // 
            // L_Curso
            // 
            this.L_Curso.AutoSize = true;
            this.L_Curso.Location = new System.Drawing.Point(101, 124);
            this.L_Curso.Name = "L_Curso";
            this.L_Curso.Size = new System.Drawing.Size(46, 13);
            this.L_Curso.TabIndex = 2;
            this.L_Curso.Text = "L_Curso";
            // 
            // TB_HC
            // 
            this.TB_HC.Location = new System.Drawing.Point(98, 30);
            this.TB_HC.Name = "TB_HC";
            this.TB_HC.Size = new System.Drawing.Size(100, 20);
            this.TB_HC.TabIndex = 3;
            // 
            // BT_Buscar
            // 
            this.BT_Buscar.Location = new System.Drawing.Point(98, 60);
            this.BT_Buscar.Name = "BT_Buscar";
            this.BT_Buscar.Size = new System.Drawing.Size(100, 23);
            this.BT_Buscar.TabIndex = 4;
            this.BT_Buscar.Text = "Buscar";
            this.BT_Buscar.UseVisualStyleBackColor = true;
            this.BT_Buscar.Click += new System.EventHandler(this.BT_Buscar_Click);
            // 
            // LB_Planes
            // 
            this.LB_Planes.FormattingEnabled = true;
            this.LB_Planes.Location = new System.Drawing.Point(46, 168);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(152, 108);
            this.LB_Planes.TabIndex = 5;
            this.LB_Planes.SelectedIndexChanged += new System.EventHandler(this.LB_Planes_SelectedIndexChanged);
            // 
            // L_Paciente
            // 
            this.L_Paciente.AutoSize = true;
            this.L_Paciente.Location = new System.Drawing.Point(101, 102);
            this.L_Paciente.Name = "L_Paciente";
            this.L_Paciente.Size = new System.Drawing.Size(61, 13);
            this.L_Paciente.TabIndex = 7;
            this.L_Paciente.Text = "L_Paciente";
            this.L_Paciente.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Curso:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nº de campos:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 288);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Estado del plan:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 338);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "UM totales:";
            // 
            // L_EstadoPlan
            // 
            this.L_EstadoPlan.AutoSize = true;
            this.L_EstadoPlan.Location = new System.Drawing.Point(137, 288);
            this.L_EstadoPlan.Name = "L_EstadoPlan";
            this.L_EstadoPlan.Size = new System.Drawing.Size(73, 13);
            this.L_EstadoPlan.TabIndex = 13;
            this.L_EstadoPlan.Text = "L_EstadoPlan";
            // 
            // L_NumCampos
            // 
            this.L_NumCampos.AutoSize = true;
            this.L_NumCampos.Location = new System.Drawing.Point(137, 310);
            this.L_NumCampos.Name = "L_NumCampos";
            this.L_NumCampos.Size = new System.Drawing.Size(79, 13);
            this.L_NumCampos.TabIndex = 12;
            this.L_NumCampos.Text = "L_NumCampos";
            // 
            // L_UMTotales
            // 
            this.L_UMTotales.AutoSize = true;
            this.L_UMTotales.Location = new System.Drawing.Point(137, 338);
            this.L_UMTotales.Name = "L_UMTotales";
            this.L_UMTotales.Size = new System.Drawing.Size(67, 13);
            this.L_UMTotales.TabIndex = 15;
            this.L_UMTotales.Text = "L_UMtotales";
            // 
            // LB_Estructuras
            // 
            this.LB_Estructuras.FormattingEnabled = true;
            this.LB_Estructuras.Location = new System.Drawing.Point(264, 168);
            this.LB_Estructuras.Name = "LB_Estructuras";
            this.LB_Estructuras.Size = new System.Drawing.Size(152, 160);
            this.LB_Estructuras.TabIndex = 16;
            this.LB_Estructuras.SelectedIndexChanged += new System.EventHandler(this.LB_Estructuras_SelectedIndexChanged);
            // 
            // L_Volumen
            // 
            this.L_Volumen.AutoSize = true;
            this.L_Volumen.Location = new System.Drawing.Point(355, 347);
            this.L_Volumen.Name = "L_Volumen";
            this.L_Volumen.Size = new System.Drawing.Size(35, 13);
            this.L_Volumen.TabIndex = 20;
            this.L_Volumen.Text = "label3";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(261, 347);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Volumen:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 448);
            this.Controls.Add(this.L_Volumen);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LB_Estructuras);
            this.Controls.Add(this.L_UMTotales);
            this.Controls.Add(this.L_EstadoPlan);
            this.Controls.Add(this.L_NumCampos);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.L_Paciente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.BT_Buscar);
            this.Controls.Add(this.TB_HC);
            this.Controls.Add(this.L_Curso);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Curso;
        private System.Windows.Forms.TextBox TB_HC;
        private System.Windows.Forms.Button BT_Buscar;
        private System.Windows.Forms.ListBox LB_Planes;
        private System.Windows.Forms.Label L_Paciente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label L_EstadoPlan;
        private System.Windows.Forms.Label L_NumCampos;
        private System.Windows.Forms.Label L_UMTotales;
        private System.Windows.Forms.ListBox LB_Estructuras;
        private System.Windows.Forms.Label L_Volumen;
        private System.Windows.Forms.Label label10;
    }
}

