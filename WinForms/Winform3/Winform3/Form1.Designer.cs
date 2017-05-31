namespace Winform3
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
            this.TB_AgregarHCALista = new System.Windows.Forms.TextBox();
            this.BT_AgregarHCALista = new System.Windows.Forms.Button();
            this.LB_ListaHC = new System.Windows.Forms.ListBox();
            this.TB_Estructura = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Dosis = new System.Windows.Forms.TextBox();
            this.CB_DosisUnidades = new System.Windows.Forms.ComboBox();
            this.TB_Volumen = new System.Windows.Forms.TextBox();
            this.Label_Resultados = new System.Windows.Forms.Label();
            this.BT_Analizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar HC:";
            // 
            // TB_AgregarHCALista
            // 
            this.TB_AgregarHCALista.Location = new System.Drawing.Point(35, 30);
            this.TB_AgregarHCALista.Name = "TB_AgregarHCALista";
            this.TB_AgregarHCALista.Size = new System.Drawing.Size(100, 20);
            this.TB_AgregarHCALista.TabIndex = 1;
            // 
            // BT_AgregarHCALista
            // 
            this.BT_AgregarHCALista.Location = new System.Drawing.Point(151, 28);
            this.BT_AgregarHCALista.Name = "BT_AgregarHCALista";
            this.BT_AgregarHCALista.Size = new System.Drawing.Size(75, 23);
            this.BT_AgregarHCALista.TabIndex = 2;
            this.BT_AgregarHCALista.Text = "Agregar";
            this.BT_AgregarHCALista.UseVisualStyleBackColor = true;
            this.BT_AgregarHCALista.Click += new System.EventHandler(this.BT_AgregarHCALista_Click);
            // 
            // LB_ListaHC
            // 
            this.LB_ListaHC.FormattingEnabled = true;
            this.LB_ListaHC.Location = new System.Drawing.Point(35, 57);
            this.LB_ListaHC.Name = "LB_ListaHC";
            this.LB_ListaHC.Size = new System.Drawing.Size(100, 134);
            this.LB_ListaHC.TabIndex = 3;
            // 
            // TB_Estructura
            // 
            this.TB_Estructura.Location = new System.Drawing.Point(96, 214);
            this.TB_Estructura.Name = "TB_Estructura";
            this.TB_Estructura.Size = new System.Drawing.Size(100, 20);
            this.TB_Estructura.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estructura:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Volumen correspondiente a una dosis de:";
            // 
            // TB_Dosis
            // 
            this.TB_Dosis.Location = new System.Drawing.Point(137, 280);
            this.TB_Dosis.Name = "TB_Dosis";
            this.TB_Dosis.Size = new System.Drawing.Size(100, 20);
            this.TB_Dosis.TabIndex = 6;
            // 
            // CB_DosisUnidades
            // 
            this.CB_DosisUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_DosisUnidades.FormattingEnabled = true;
            this.CB_DosisUnidades.Items.AddRange(new object[] {
            "cGy",
            "%"});
            this.CB_DosisUnidades.Location = new System.Drawing.Point(246, 279);
            this.CB_DosisUnidades.Name = "CB_DosisUnidades";
            this.CB_DosisUnidades.Size = new System.Drawing.Size(40, 21);
            this.CB_DosisUnidades.TabIndex = 8;
            // 
            // TB_Volumen
            // 
            this.TB_Volumen.Location = new System.Drawing.Point(137, 336);
            this.TB_Volumen.Name = "TB_Volumen";
            this.TB_Volumen.Size = new System.Drawing.Size(100, 20);
            this.TB_Volumen.TabIndex = 9;
            // 
            // Label_Resultados
            // 
            this.Label_Resultados.AutoSize = true;
            this.Label_Resultados.Location = new System.Drawing.Point(346, 28);
            this.Label_Resultados.Name = "Label_Resultados";
            this.Label_Resultados.Size = new System.Drawing.Size(63, 13);
            this.Label_Resultados.TabIndex = 11;
            this.Label_Resultados.Text = "Resultados:";
            // 
            // BT_Analizar
            // 
            this.BT_Analizar.Location = new System.Drawing.Point(137, 381);
            this.BT_Analizar.Name = "BT_Analizar";
            this.BT_Analizar.Size = new System.Drawing.Size(149, 36);
            this.BT_Analizar.TabIndex = 12;
            this.BT_Analizar.Text = "Analizar";
            this.BT_Analizar.UseVisualStyleBackColor = true;
            this.BT_Analizar.Click += new System.EventHandler(this.BT_Analizar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dosis correspondiente a un volumen de:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 429);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_Analizar);
            this.Controls.Add(this.Label_Resultados);
            this.Controls.Add(this.TB_Volumen);
            this.Controls.Add(this.CB_DosisUnidades);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Dosis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_Estructura);
            this.Controls.Add(this.LB_ListaHC);
            this.Controls.Add(this.BT_AgregarHCALista);
            this.Controls.Add(this.TB_AgregarHCALista);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_AgregarHCALista;
        private System.Windows.Forms.Button BT_AgregarHCALista;
        private System.Windows.Forms.ListBox LB_ListaHC;
        private System.Windows.Forms.TextBox TB_Estructura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Dosis;
        private System.Windows.Forms.ComboBox CB_DosisUnidades;
        private System.Windows.Forms.TextBox TB_Volumen;
        private System.Windows.Forms.Label Label_Resultados;
        private System.Windows.Forms.Button BT_Analizar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

