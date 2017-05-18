namespace WindowsFormsApplication1
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
            this.TB_HC = new System.Windows.Forms.TextBox();
            this.BT_boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LB_Planes = new System.Windows.Forms.ListBox();
            this.LB_Curso = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_HC
            // 
            this.TB_HC.Location = new System.Drawing.Point(64, 27);
            this.TB_HC.Name = "TB_HC";
            this.TB_HC.Size = new System.Drawing.Size(100, 20);
            this.TB_HC.TabIndex = 0;
            // 
            // BT_boton
            // 
            this.BT_boton.Location = new System.Drawing.Point(64, 64);
            this.BT_boton.Name = "BT_boton";
            this.BT_boton.Size = new System.Drawing.Size(75, 23);
            this.BT_boton.TabIndex = 1;
            this.BT_boton.Text = "Buscar Paciente";
            this.BT_boton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "H.C.";
            // 
            // LB_Planes
            // 
            this.LB_Planes.FormattingEnabled = true;
            this.LB_Planes.Location = new System.Drawing.Point(64, 142);
            this.LB_Planes.Name = "LB_Planes";
            this.LB_Planes.Size = new System.Drawing.Size(100, 108);
            this.LB_Planes.TabIndex = 3;
            // 
            // LB_Curso
            // 
            this.LB_Curso.AutoSize = true;
            this.LB_Curso.Location = new System.Drawing.Point(61, 115);
            this.LB_Curso.Name = "LB_Curso";
            this.LB_Curso.Size = new System.Drawing.Size(34, 13);
            this.LB_Curso.TabIndex = 4;
            this.LB_Curso.Text = "Curso";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LB_Curso);
            this.Controls.Add(this.LB_Planes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BT_boton);
            this.Controls.Add(this.TB_HC);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_HC;
        private System.Windows.Forms.Button BT_boton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Planes;
        private System.Windows.Forms.Label LB_Curso;
    }
}

