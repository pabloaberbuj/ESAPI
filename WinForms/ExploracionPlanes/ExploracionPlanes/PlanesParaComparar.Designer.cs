namespace ExploracionPlanes
{
    partial class PlanesParaComparar
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
            this.LB_PlanesComparar = new System.Windows.Forms.ListBox();
            this.BT_Selecccionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccionarel plan para comparar";
            // 
            // LB_PlanesComparar
            // 
            this.LB_PlanesComparar.FormattingEnabled = true;
            this.LB_PlanesComparar.Location = new System.Drawing.Point(25, 44);
            this.LB_PlanesComparar.Name = "LB_PlanesComparar";
            this.LB_PlanesComparar.Size = new System.Drawing.Size(173, 173);
            this.LB_PlanesComparar.TabIndex = 1;
            // 
            // BT_Selecccionar
            // 
            this.BT_Selecccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Selecccionar.Location = new System.Drawing.Point(47, 237);
            this.BT_Selecccionar.Name = "BT_Selecccionar";
            this.BT_Selecccionar.Size = new System.Drawing.Size(123, 30);
            this.BT_Selecccionar.TabIndex = 2;
            this.BT_Selecccionar.Text = "Seleccionar";
            this.BT_Selecccionar.UseVisualStyleBackColor = true;
            this.BT_Selecccionar.Click += new System.EventHandler(this.BT_Selecccionar_Click);
            // 
            // PlanesParaComparar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(223, 279);
            this.Controls.Add(this.BT_Selecccionar);
            this.Controls.Add(this.LB_PlanesComparar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MinimizeBox = false;
            this.Name = "PlanesParaComparar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selección Plan para comparar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_PlanesComparar;
        private System.Windows.Forms.Button BT_Selecccionar;
    }
}