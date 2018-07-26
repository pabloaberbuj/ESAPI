namespace AutomatedPlanning
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_ID = new System.Windows.Forms.TextBox();
            this.TB_Plan = new System.Windows.Forms.TextBox();
            this.TB_Output = new System.Windows.Forms.TextBox();
            this.BT_AbrirPaciente = new System.Windows.Forms.Button();
            this.BT_Optimizar = new System.Windows.Forms.Button();
            this.TB_Curso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Paciente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Curso";
            // 
            // TB_ID
            // 
            this.TB_ID.Location = new System.Drawing.Point(129, 31);
            this.TB_ID.Name = "TB_ID";
            this.TB_ID.Size = new System.Drawing.Size(100, 20);
            this.TB_ID.TabIndex = 2;
            // 
            // TB_Plan
            // 
            this.TB_Plan.Location = new System.Drawing.Point(129, 103);
            this.TB_Plan.Name = "TB_Plan";
            this.TB_Plan.Size = new System.Drawing.Size(100, 20);
            this.TB_Plan.TabIndex = 3;
            // 
            // TB_Output
            // 
            this.TB_Output.Location = new System.Drawing.Point(63, 154);
            this.TB_Output.Multiline = true;
            this.TB_Output.Name = "TB_Output";
            this.TB_Output.Size = new System.Drawing.Size(183, 173);
            this.TB_Output.TabIndex = 4;
            // 
            // BT_AbrirPaciente
            // 
            this.BT_AbrirPaciente.Location = new System.Drawing.Point(262, 29);
            this.BT_AbrirPaciente.Name = "BT_AbrirPaciente";
            this.BT_AbrirPaciente.Size = new System.Drawing.Size(85, 23);
            this.BT_AbrirPaciente.TabIndex = 5;
            this.BT_AbrirPaciente.Text = "AbrirPaciente";
            this.BT_AbrirPaciente.UseVisualStyleBackColor = true;
            this.BT_AbrirPaciente.Click += new System.EventHandler(this.BT_AbrirPaciente_Click);
            // 
            // BT_Optimizar
            // 
            this.BT_Optimizar.Location = new System.Drawing.Point(262, 63);
            this.BT_Optimizar.Name = "BT_Optimizar";
            this.BT_Optimizar.Size = new System.Drawing.Size(85, 23);
            this.BT_Optimizar.TabIndex = 6;
            this.BT_Optimizar.Text = "Optimizar";
            this.BT_Optimizar.UseVisualStyleBackColor = true;
            this.BT_Optimizar.Click += new System.EventHandler(this.BT_Optimizar_Click);
            // 
            // TB_Curso
            // 
            this.TB_Curso.Location = new System.Drawing.Point(129, 66);
            this.TB_Curso.Name = "TB_Curso";
            this.TB_Curso.Size = new System.Drawing.Size(100, 20);
            this.TB_Curso.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Plan";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 375);
            this.Controls.Add(this.TB_Curso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BT_Optimizar);
            this.Controls.Add(this.BT_AbrirPaciente);
            this.Controls.Add(this.TB_Output);
            this.Controls.Add(this.TB_Plan);
            this.Controls.Add(this.TB_ID);
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
        private System.Windows.Forms.TextBox TB_ID;
        private System.Windows.Forms.TextBox TB_Plan;
        private System.Windows.Forms.TextBox TB_Output;
        private System.Windows.Forms.Button BT_AbrirPaciente;
        private System.Windows.Forms.Button BT_Optimizar;
        private System.Windows.Forms.TextBox TB_Curso;
        private System.Windows.Forms.Label label3;
    }
}

