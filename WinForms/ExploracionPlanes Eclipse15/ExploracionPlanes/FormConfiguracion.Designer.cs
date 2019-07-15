namespace ExploracionPlanes
{
    partial class FormConfiguracion
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
            this.TB_Ruta = new System.Windows.Forms.TextBox();
            this.TB_VolumenDM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.BT_SeleccionarRuta = new System.Windows.Forms.Button();
            this.BT_Guardar = new System.Windows.Forms.Button();
            this.BT_Cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ruta carpetas:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Volumen dosis máxima:";
            // 
            // TB_Ruta
            // 
            this.TB_Ruta.Location = new System.Drawing.Point(102, 38);
            this.TB_Ruta.Name = "TB_Ruta";
            this.TB_Ruta.Size = new System.Drawing.Size(248, 20);
            this.TB_Ruta.TabIndex = 2;
            // 
            // TB_VolumenDM
            // 
            this.TB_VolumenDM.Location = new System.Drawing.Point(134, 83);
            this.TB_VolumenDM.Name = "TB_VolumenDM";
            this.TB_VolumenDM.Size = new System.Drawing.Size(69, 20);
            this.TB_VolumenDM.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "[cm3]";
            // 
            // BT_SeleccionarRuta
            // 
            this.BT_SeleccionarRuta.Location = new System.Drawing.Point(356, 36);
            this.BT_SeleccionarRuta.Name = "BT_SeleccionarRuta";
            this.BT_SeleccionarRuta.Size = new System.Drawing.Size(96, 23);
            this.BT_SeleccionarRuta.TabIndex = 5;
            this.BT_SeleccionarRuta.Text = "Seleccionar";
            this.BT_SeleccionarRuta.UseVisualStyleBackColor = true;
            this.BT_SeleccionarRuta.Click += new System.EventHandler(this.BT_SeleccionarRuta_Click);
            // 
            // BT_Guardar
            // 
            this.BT_Guardar.Location = new System.Drawing.Point(102, 133);
            this.BT_Guardar.Name = "BT_Guardar";
            this.BT_Guardar.Size = new System.Drawing.Size(75, 23);
            this.BT_Guardar.TabIndex = 6;
            this.BT_Guardar.Text = "Guardar";
            this.BT_Guardar.UseVisualStyleBackColor = true;
            this.BT_Guardar.Click += new System.EventHandler(this.BT_Guardar_Click);
            // 
            // BT_Cancelar
            // 
            this.BT_Cancelar.Location = new System.Drawing.Point(275, 133);
            this.BT_Cancelar.Name = "BT_Cancelar";
            this.BT_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.BT_Cancelar.TabIndex = 7;
            this.BT_Cancelar.Text = "Cancelar";
            this.BT_Cancelar.UseVisualStyleBackColor = true;
            this.BT_Cancelar.Click += new System.EventHandler(this.BT_Cancelar_Click);
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 174);
            this.Controls.Add(this.BT_Cancelar);
            this.Controls.Add(this.BT_Guardar);
            this.Controls.Add(this.BT_SeleccionarRuta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_VolumenDM);
            this.Controls.Add(this.TB_Ruta);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormConfiguracion";
            this.Text = "Configuración";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Ruta;
        private System.Windows.Forms.TextBox TB_VolumenDM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BT_SeleccionarRuta;
        private System.Windows.Forms.Button BT_Guardar;
        private System.Windows.Forms.Button BT_Cancelar;
    }
}