namespace ExploracionPlanes
{
    partial class Form_ListaRestricciones
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
            this.LB_ListaRestricciones = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_ListaRestricciones
            // 
            this.LB_ListaRestricciones.FormattingEnabled = true;
            this.LB_ListaRestricciones.Location = new System.Drawing.Point(43, 44);
            this.LB_ListaRestricciones.Name = "LB_ListaRestricciones";
            this.LB_ListaRestricciones.Size = new System.Drawing.Size(226, 238);
            this.LB_ListaRestricciones.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Elegir una restricción de la lista";
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Location = new System.Drawing.Point(194, 288);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BT_Aceptar.TabIndex = 2;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            this.BT_Aceptar.Click += new System.EventHandler(this.BT_Aceptar_Click);
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BT_Cancelar.Location = new System.Drawing.Point(43, 288);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancelar.TabIndex = 3;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            // 
            // Form_ListaRestricciones
            // 
            this.AcceptButton = this.BT_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BT_Cancelar;
            this.ClientSize = new System.Drawing.Size(322, 323);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.BT_Aceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LB_ListaRestricciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_ListaRestricciones";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ListaRestricciones";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_ListaRestricciones;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.Button BT_Cancelar;
    }
}