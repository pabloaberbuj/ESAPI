namespace ExploracionPlanes
{
    partial class Main
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
            this.LB_Plantillas = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.BT_Nueva = new System.Windows.Forms.Button();
            this.BT_Editar = new System.Windows.Forms.Button();
            this.BT_Eliminar = new System.Windows.Forms.Button();
            this.BT_AplicarAUnPlan = new System.Windows.Forms.Button();
            this.BT_AplicarPorLote = new System.Windows.Forms.Button();
            this.BT_Duplicar = new System.Windows.Forms.Button();
            this.BT_Ver = new System.Windows.Forms.Button();
            this.BT_HabilitarEdicion = new System.Windows.Forms.Button();
            this.L_Editando = new System.Windows.Forms.Label();
            this.BT_Configuracion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Plantillas
            // 
            this.LB_Plantillas.FormattingEnabled = true;
            this.LB_Plantillas.Location = new System.Drawing.Point(12, 29);
            this.LB_Plantillas.Name = "LB_Plantillas";
            this.LB_Plantillas.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_Plantillas.Size = new System.Drawing.Size(198, 316);
            this.LB_Plantillas.TabIndex = 7;
            this.LB_Plantillas.SelectedIndexChanged += new System.EventHandler(this.LB_Plantillas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Plantillas";
            // 
            // BT_Nueva
            // 
            this.BT_Nueva.Location = new System.Drawing.Point(232, 198);
            this.BT_Nueva.Name = "BT_Nueva";
            this.BT_Nueva.Size = new System.Drawing.Size(134, 34);
            this.BT_Nueva.TabIndex = 1;
            this.BT_Nueva.Text = "Nueva Plantilla";
            this.BT_Nueva.UseVisualStyleBackColor = true;
            this.BT_Nueva.Click += new System.EventHandler(this.BT_Nueva_Click);
            // 
            // BT_Editar
            // 
            this.BT_Editar.Enabled = false;
            this.BT_Editar.Location = new System.Drawing.Point(232, 238);
            this.BT_Editar.Name = "BT_Editar";
            this.BT_Editar.Size = new System.Drawing.Size(134, 37);
            this.BT_Editar.TabIndex = 2;
            this.BT_Editar.Text = "Editar plantilla";
            this.BT_Editar.UseVisualStyleBackColor = true;
            this.BT_Editar.Click += new System.EventHandler(this.BT_Editar_Click);
            // 
            // BT_Eliminar
            // 
            this.BT_Eliminar.Enabled = false;
            this.BT_Eliminar.Location = new System.Drawing.Point(232, 325);
            this.BT_Eliminar.Name = "BT_Eliminar";
            this.BT_Eliminar.Size = new System.Drawing.Size(134, 34);
            this.BT_Eliminar.TabIndex = 4;
            this.BT_Eliminar.Text = "Eliminar plantilla/s";
            this.BT_Eliminar.UseVisualStyleBackColor = true;
            this.BT_Eliminar.Click += new System.EventHandler(this.BT_Eliminar_Click);
            // 
            // BT_AplicarAUnPlan
            // 
            this.BT_AplicarAUnPlan.Enabled = false;
            this.BT_AplicarAUnPlan.Location = new System.Drawing.Point(232, 29);
            this.BT_AplicarAUnPlan.Name = "BT_AplicarAUnPlan";
            this.BT_AplicarAUnPlan.Size = new System.Drawing.Size(134, 40);
            this.BT_AplicarAUnPlan.TabIndex = 5;
            this.BT_AplicarAUnPlan.Text = "Aplicar plantilla a un plan";
            this.BT_AplicarAUnPlan.UseVisualStyleBackColor = true;
            this.BT_AplicarAUnPlan.Click += new System.EventHandler(this.BT_AplicarAUnPlan_Click);
            // 
            // BT_AplicarPorLote
            // 
            this.BT_AplicarPorLote.Enabled = false;
            this.BT_AplicarPorLote.Location = new System.Drawing.Point(232, 123);
            this.BT_AplicarPorLote.Name = "BT_AplicarPorLote";
            this.BT_AplicarPorLote.Size = new System.Drawing.Size(134, 40);
            this.BT_AplicarPorLote.TabIndex = 6;
            this.BT_AplicarPorLote.Text = "Extraer información de varios planes";
            this.BT_AplicarPorLote.UseVisualStyleBackColor = true;
            this.BT_AplicarPorLote.Click += new System.EventHandler(this.BT_AplicarPorLote_Click);
            // 
            // BT_Duplicar
            // 
            this.BT_Duplicar.Enabled = false;
            this.BT_Duplicar.Location = new System.Drawing.Point(232, 281);
            this.BT_Duplicar.Name = "BT_Duplicar";
            this.BT_Duplicar.Size = new System.Drawing.Size(134, 37);
            this.BT_Duplicar.TabIndex = 3;
            this.BT_Duplicar.Text = "Duplicar plantilla";
            this.BT_Duplicar.UseVisualStyleBackColor = true;
            this.BT_Duplicar.Click += new System.EventHandler(this.BT_Duplicar_Click);
            // 
            // BT_Ver
            // 
            this.BT_Ver.Enabled = false;
            this.BT_Ver.Location = new System.Drawing.Point(232, 77);
            this.BT_Ver.Name = "BT_Ver";
            this.BT_Ver.Size = new System.Drawing.Size(134, 38);
            this.BT_Ver.TabIndex = 12;
            this.BT_Ver.Text = "Ver Plantilla";
            this.BT_Ver.UseVisualStyleBackColor = true;
            this.BT_Ver.Click += new System.EventHandler(this.BT_Ver_Click);
            // 
            // BT_HabilitarEdicion
            // 
            this.BT_HabilitarEdicion.Location = new System.Drawing.Point(232, 370);
            this.BT_HabilitarEdicion.Name = "BT_HabilitarEdicion";
            this.BT_HabilitarEdicion.Size = new System.Drawing.Size(132, 23);
            this.BT_HabilitarEdicion.TabIndex = 13;
            this.BT_HabilitarEdicion.Text = "Habiltar edición";
            this.BT_HabilitarEdicion.UseVisualStyleBackColor = true;
            this.BT_HabilitarEdicion.Click += new System.EventHandler(this.BT_HabilitarEdicion_Click);
            // 
            // L_Editando
            // 
            this.L_Editando.AutoSize = true;
            this.L_Editando.ForeColor = System.Drawing.Color.ForestGreen;
            this.L_Editando.Location = new System.Drawing.Point(161, 375);
            this.L_Editando.Name = "L_Editando";
            this.L_Editando.Size = new System.Drawing.Size(49, 13);
            this.L_Editando.TabIndex = 14;
            this.L_Editando.Text = "Editando";
            this.L_Editando.Visible = false;
            // 
            // BT_Configuracion
            // 
            this.BT_Configuracion.Location = new System.Drawing.Point(12, 370);
            this.BT_Configuracion.Name = "BT_Configuracion";
            this.BT_Configuracion.Size = new System.Drawing.Size(94, 23);
            this.BT_Configuracion.TabIndex = 15;
            this.BT_Configuracion.Text = "Configuración";
            this.BT_Configuracion.UseVisualStyleBackColor = true;
            this.BT_Configuracion.Click += new System.EventHandler(this.BT_Configuracion_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 399);
            this.Controls.Add(this.BT_Configuracion);
            this.Controls.Add(this.L_Editando);
            this.Controls.Add(this.BT_HabilitarEdicion);
            this.Controls.Add(this.BT_Ver);
            this.Controls.Add(this.BT_Duplicar);
            this.Controls.Add(this.BT_AplicarPorLote);
            this.Controls.Add(this.BT_AplicarAUnPlan);
            this.Controls.Add(this.BT_Eliminar);
            this.Controls.Add(this.BT_Editar);
            this.Controls.Add(this.BT_Nueva);
            this.Controls.Add(this.LB_Plantillas);
            this.Controls.Add(this.label4);
            this.Name = "Main";
            this.Text = "Exploración de planes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LB_Plantillas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BT_Nueva;
        private System.Windows.Forms.Button BT_Editar;
        private System.Windows.Forms.Button BT_Eliminar;
        private System.Windows.Forms.Button BT_AplicarAUnPlan;
        private System.Windows.Forms.Button BT_AplicarPorLote;
        private System.Windows.Forms.Button BT_Duplicar;
        private System.Windows.Forms.Button BT_Ver;
        private System.Windows.Forms.Button BT_HabilitarEdicion;
        private System.Windows.Forms.Label L_Editando;
        private System.Windows.Forms.Button BT_Configuracion;
    }
}