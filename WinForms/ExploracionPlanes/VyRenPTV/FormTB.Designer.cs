namespace ExploracionPlanes
{
    partial class FormTB
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
            this.TB_Llenar = new System.Windows.Forms.TextBox();
            this.BT_Aceptar = new System.Windows.Forms.Button();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.L_Texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TB_Llenar
            // 
            this.TB_Llenar.Location = new System.Drawing.Point(15, 37);
            this.TB_Llenar.Name = "TB_Llenar";
            this.TB_Llenar.Size = new System.Drawing.Size(183, 20);
            this.TB_Llenar.TabIndex = 0;
            this.TB_Llenar.TextChanged += new System.EventHandler(this.TB_Llenar_TextChanged);
            // 
            // BT_Aceptar
            // 
            this.BT_Aceptar.Enabled = false;
            this.BT_Aceptar.Location = new System.Drawing.Point(15, 72);
            this.BT_Aceptar.Name = "BT_Aceptar";
            this.BT_Aceptar.Size = new System.Drawing.Size(75, 23);
            this.BT_Aceptar.TabIndex = 1;
            this.BT_Aceptar.Text = "Aceptar";
            this.BT_Aceptar.UseVisualStyleBackColor = true;
            this.BT_Aceptar.Click += new System.EventHandler(this.BT_Aceptar_Click);
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.Location = new System.Drawing.Point(123, 72);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancelar.TabIndex = 2;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // L_Texto
            // 
            this.L_Texto.AutoSize = true;
            this.L_Texto.Location = new System.Drawing.Point(12, 9);
            this.L_Texto.Name = "L_Texto";
            this.L_Texto.Size = new System.Drawing.Size(35, 13);
            this.L_Texto.TabIndex = 3;
            this.L_Texto.Text = "label1";
            // 
            // FormTB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BT_Cancelar;
            this.ClientSize = new System.Drawing.Size(210, 107);
            this.Controls.Add(this.L_Texto);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.BT_Aceptar);
            this.Controls.Add(this.TB_Llenar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormTB";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "FormTB";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Llenar;
        private System.Windows.Forms.Button BT_Aceptar;
        private System.Windows.Forms.Button BT_Cancelar;
        private System.Windows.Forms.Label L_Texto;
    }
}