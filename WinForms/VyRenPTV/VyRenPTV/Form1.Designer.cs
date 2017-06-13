namespace VyRenPTV
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
            this.BT_AgregarALista = new System.Windows.Forms.Button();
            this.TB_Agregar = new System.Windows.Forms.TextBox();
            this.LB_HCs = new System.Windows.Forms.ListBox();
            this.L_Reporte = new System.Windows.Forms.Label();
            this.BT_Analizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BT_AgregarALista
            // 
            this.BT_AgregarALista.Location = new System.Drawing.Point(159, 31);
            this.BT_AgregarALista.Name = "BT_AgregarALista";
            this.BT_AgregarALista.Size = new System.Drawing.Size(75, 23);
            this.BT_AgregarALista.TabIndex = 2;
            this.BT_AgregarALista.Text = "Agregar";
            this.BT_AgregarALista.UseVisualStyleBackColor = true;
            this.BT_AgregarALista.Click += new System.EventHandler(this.BT_AgregarALista_Click);
            // 
            // TB_Agregar
            // 
            this.TB_Agregar.Location = new System.Drawing.Point(38, 31);
            this.TB_Agregar.Name = "TB_Agregar";
            this.TB_Agregar.Size = new System.Drawing.Size(100, 20);
            this.TB_Agregar.TabIndex = 1;
            // 
            // LB_HCs
            // 
            this.LB_HCs.FormattingEnabled = true;
            this.LB_HCs.Location = new System.Drawing.Point(38, 68);
            this.LB_HCs.Name = "LB_HCs";
            this.LB_HCs.Size = new System.Drawing.Size(100, 121);
            this.LB_HCs.TabIndex = 3;
            // 
            // L_Reporte
            // 
            this.L_Reporte.AutoSize = true;
            this.L_Reporte.Location = new System.Drawing.Point(313, 31);
            this.L_Reporte.Name = "L_Reporte";
            this.L_Reporte.Size = new System.Drawing.Size(35, 13);
            this.L_Reporte.TabIndex = 3;
            this.L_Reporte.Text = "label1";
            // 
            // BT_Analizar
            // 
            this.BT_Analizar.Location = new System.Drawing.Point(38, 217);
            this.BT_Analizar.Name = "BT_Analizar";
            this.BT_Analizar.Size = new System.Drawing.Size(121, 40);
            this.BT_Analizar.TabIndex = 4;
            this.BT_Analizar.Text = "Analizar";
            this.BT_Analizar.UseVisualStyleBackColor = true;
            this.BT_Analizar.Click += new System.EventHandler(this.BT_Analizar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 403);
            this.Controls.Add(this.BT_Analizar);
            this.Controls.Add(this.L_Reporte);
            this.Controls.Add(this.LB_HCs);
            this.Controls.Add(this.TB_Agregar);
            this.Controls.Add(this.BT_AgregarALista);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_AgregarALista;
        private System.Windows.Forms.TextBox TB_Agregar;
        private System.Windows.Forms.ListBox LB_HCs;
        private System.Windows.Forms.Label L_Reporte;
        private System.Windows.Forms.Button BT_Analizar;
    }
}

