namespace ExploracionPlanes
{
    partial class Form1_ext
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
            this.CB_TipoRestriccion = new System.Windows.Forms.ComboBox();
            this.L_CorrespA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CB_CorrespAUnidades = new System.Windows.Forms.ComboBox();
            this.TB_CorrespA = new System.Windows.Forms.TextBox();
            this.CB_MenorOMayor = new System.Windows.Forms.ComboBox();
            this.BT_AgregarALista = new System.Windows.Forms.Button();
            this.LB_listaRestricciones = new System.Windows.Forms.ListBox();
            this.GB_NuevaRestriccion = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_NotaRestriccion = new System.Windows.Forms.TextBox();
            this.Panel_esMenorque = new System.Windows.Forms.Panel();
            this.DGV_restricciones = new System.Windows.Forms.DataGridView();
            this.CB_ValorEsperadoUnidades = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_EstructuraNombresAlt = new System.Windows.Forms.TextBox();
            this.CB_Estructura = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TB_NombrePlantilla = new System.Windows.Forms.TextBox();
            this.BT_GuardarPlantilla = new System.Windows.Forms.Button();
            this.BT_EliminarRestriccion = new System.Windows.Forms.Button();
            this.CHB_esParaExtraccion = new System.Windows.Forms.CheckBox();
            this.BT_EditarRestriccion = new System.Windows.Forms.Button();
            this.TB_NotaPlantilla = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GB_Condiciones = new System.Windows.Forms.GroupBox();
            this.L_VolPTVcc = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LB_ListaCondiciones = new System.Windows.Forms.ListBox();
            this.TB_Cond2 = new System.Windows.Forms.TextBox();
            this.TB_Cond1 = new System.Windows.Forms.TextBox();
            this.CB_cond1 = new System.Windows.Forms.ComboBox();
            this.BT_EliminarCondicion = new System.Windows.Forms.Button();
            this.LB_Condiciones = new System.Windows.Forms.ListBox();
            this.BT_AgregarCondicion = new System.Windows.Forms.Button();
            this.BT_IniciarCargaRestricciones = new System.Windows.Forms.Button();
            this.BT_FinalizarCargaRestricciones = new System.Windows.Forms.Button();
            this.BT_RestriccionAbajo = new System.Windows.Forms.Button();
            this.BT_RestriccionArriba = new System.Windows.Forms.Button();
            this.BT_CargarDesdePaciente = new System.Windows.Forms.Button();
            this.GB_NuevaRestriccion.SuspendLayout();
            this.Panel_esMenorque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_restricciones)).BeginInit();
            this.GB_Condiciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // CB_TipoRestriccion
            // 
            this.CB_TipoRestriccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_TipoRestriccion.FormattingEnabled = true;
            this.CB_TipoRestriccion.Items.AddRange(new object[] {
            "Dosis",
            "Dmedia",
            "Dmax",
            "Volumen",
            "IC"});
            this.CB_TipoRestriccion.Location = new System.Drawing.Point(112, 42);
            this.CB_TipoRestriccion.Name = "CB_TipoRestriccion";
            this.CB_TipoRestriccion.Size = new System.Drawing.Size(86, 21);
            this.CB_TipoRestriccion.TabIndex = 3;
            this.CB_TipoRestriccion.SelectedIndexChanged += new System.EventHandler(this.CB_TipoRestriccion_SelectedIndexChanged);
            // 
            // L_CorrespA
            // 
            this.L_CorrespA.AutoSize = true;
            this.L_CorrespA.Location = new System.Drawing.Point(204, 40);
            this.L_CorrespA.Name = "L_CorrespA";
            this.L_CorrespA.Size = new System.Drawing.Size(35, 13);
            this.L_CorrespA.TabIndex = 2;
            this.L_CorrespA.Text = "label1";
            this.L_CorrespA.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Estructura";
            // 
            // CB_CorrespAUnidades
            // 
            this.CB_CorrespAUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_CorrespAUnidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_CorrespAUnidades.FormattingEnabled = true;
            this.CB_CorrespAUnidades.Location = new System.Drawing.Point(376, 43);
            this.CB_CorrespAUnidades.Name = "CB_CorrespAUnidades";
            this.CB_CorrespAUnidades.Size = new System.Drawing.Size(50, 21);
            this.CB_CorrespAUnidades.TabIndex = 5;
            // 
            // TB_CorrespA
            // 
            this.TB_CorrespA.Location = new System.Drawing.Point(300, 43);
            this.TB_CorrespA.Name = "TB_CorrespA";
            this.TB_CorrespA.Size = new System.Drawing.Size(69, 20);
            this.TB_CorrespA.TabIndex = 4;
            this.TB_CorrespA.TextChanged += new System.EventHandler(this.actualizarBotones);
            // 
            // CB_MenorOMayor
            // 
            this.CB_MenorOMayor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_MenorOMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_MenorOMayor.FormattingEnabled = true;
            this.CB_MenorOMayor.Items.AddRange(new object[] {
            "≤",
            "≥"});
            this.CB_MenorOMayor.Location = new System.Drawing.Point(9, 17);
            this.CB_MenorOMayor.Name = "CB_MenorOMayor";
            this.CB_MenorOMayor.Size = new System.Drawing.Size(50, 23);
            this.CB_MenorOMayor.TabIndex = 6;
            // 
            // BT_AgregarALista
            // 
            this.BT_AgregarALista.Enabled = false;
            this.BT_AgregarALista.Location = new System.Drawing.Point(694, 166);
            this.BT_AgregarALista.Name = "BT_AgregarALista";
            this.BT_AgregarALista.Size = new System.Drawing.Size(116, 23);
            this.BT_AgregarALista.TabIndex = 11;
            this.BT_AgregarALista.Text = "Agregar a la lista";
            this.BT_AgregarALista.UseVisualStyleBackColor = true;
            this.BT_AgregarALista.Click += new System.EventHandler(this.BT_AgregarALista_Click);
            // 
            // LB_listaRestricciones
            // 
            this.LB_listaRestricciones.FormattingEnabled = true;
            this.LB_listaRestricciones.Location = new System.Drawing.Point(30, 398);
            this.LB_listaRestricciones.Name = "LB_listaRestricciones";
            this.LB_listaRestricciones.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_listaRestricciones.Size = new System.Drawing.Size(309, 186);
            this.LB_listaRestricciones.TabIndex = 12;
            this.LB_listaRestricciones.SelectedIndexChanged += new System.EventHandler(this.actualizarBotones);
            // 
            // GB_NuevaRestriccion
            // 
            this.GB_NuevaRestriccion.Controls.Add(this.BT_CargarDesdePaciente);
            this.GB_NuevaRestriccion.Controls.Add(this.label6);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_NotaRestriccion);
            this.GB_NuevaRestriccion.Controls.Add(this.Panel_esMenorque);
            this.GB_NuevaRestriccion.Controls.Add(this.label3);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_EstructuraNombresAlt);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_Estructura);
            this.GB_NuevaRestriccion.Controls.Add(this.label2);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_TipoRestriccion);
            this.GB_NuevaRestriccion.Controls.Add(this.BT_AgregarALista);
            this.GB_NuevaRestriccion.Controls.Add(this.L_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.TB_CorrespA);
            this.GB_NuevaRestriccion.Controls.Add(this.CB_CorrespAUnidades);
            this.GB_NuevaRestriccion.Enabled = false;
            this.GB_NuevaRestriccion.Location = new System.Drawing.Point(30, 162);
            this.GB_NuevaRestriccion.Name = "GB_NuevaRestriccion";
            this.GB_NuevaRestriccion.Size = new System.Drawing.Size(819, 204);
            this.GB_NuevaRestriccion.TabIndex = 13;
            this.GB_NuevaRestriccion.TabStop = false;
            this.GB_NuevaRestriccion.Text = "3. Nueva Restricción";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(259, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Nota/Referencia";
            // 
            // TB_NotaRestriccion
            // 
            this.TB_NotaRestriccion.Location = new System.Drawing.Point(262, 174);
            this.TB_NotaRestriccion.Multiline = true;
            this.TB_NotaRestriccion.Name = "TB_NotaRestriccion";
            this.TB_NotaRestriccion.Size = new System.Drawing.Size(171, 30);
            this.TB_NotaRestriccion.TabIndex = 24;
            // 
            // Panel_esMenorque
            // 
            this.Panel_esMenorque.Controls.Add(this.DGV_restricciones);
            this.Panel_esMenorque.Controls.Add(this.CB_MenorOMayor);
            this.Panel_esMenorque.Controls.Add(this.CB_ValorEsperadoUnidades);
            this.Panel_esMenorque.Location = new System.Drawing.Point(432, 26);
            this.Panel_esMenorque.Name = "Panel_esMenorque";
            this.Panel_esMenorque.Size = new System.Drawing.Size(381, 126);
            this.Panel_esMenorque.TabIndex = 23;
            // 
            // DGV_restricciones
            // 
            this.DGV_restricciones.AllowUserToAddRows = false;
            this.DGV_restricciones.AllowUserToDeleteRows = false;
            this.DGV_restricciones.AllowUserToResizeColumns = false;
            this.DGV_restricciones.AllowUserToResizeRows = false;
            this.DGV_restricciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_restricciones.Location = new System.Drawing.Point(66, 5);
            this.DGV_restricciones.Name = "DGV_restricciones";
            this.DGV_restricciones.Size = new System.Drawing.Size(308, 111);
            this.DGV_restricciones.TabIndex = 23;
            // 
            // CB_ValorEsperadoUnidades
            // 
            this.CB_ValorEsperadoUnidades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ValorEsperadoUnidades.FormattingEnabled = true;
            this.CB_ValorEsperadoUnidades.Location = new System.Drawing.Point(9, 66);
            this.CB_ValorEsperadoUnidades.Name = "CB_ValorEsperadoUnidades";
            this.CB_ValorEsperadoUnidades.Size = new System.Drawing.Size(50, 21);
            this.CB_ValorEsperadoUnidades.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Nombres alternativos";
            // 
            // TB_EstructuraNombresAlt
            // 
            this.TB_EstructuraNombresAlt.Location = new System.Drawing.Point(6, 87);
            this.TB_EstructuraNombresAlt.Multiline = true;
            this.TB_EstructuraNombresAlt.Name = "TB_EstructuraNombresAlt";
            this.TB_EstructuraNombresAlt.Size = new System.Drawing.Size(100, 72);
            this.TB_EstructuraNombresAlt.TabIndex = 10;
            // 
            // CB_Estructura
            // 
            this.CB_Estructura.FormattingEnabled = true;
            this.CB_Estructura.Location = new System.Drawing.Point(6, 42);
            this.CB_Estructura.Name = "CB_Estructura";
            this.CB_Estructura.Size = new System.Drawing.Size(100, 21);
            this.CB_Estructura.TabIndex = 2;
            this.CB_Estructura.SelectedIndexChanged += new System.EventHandler(this.actualizarBotones);
            this.CB_Estructura.TextChanged += new System.EventHandler(this.CB_Estructura_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "1. Nombre Plantilla:";
            // 
            // TB_NombrePlantilla
            // 
            this.TB_NombrePlantilla.Location = new System.Drawing.Point(128, 6);
            this.TB_NombrePlantilla.Name = "TB_NombrePlantilla";
            this.TB_NombrePlantilla.Size = new System.Drawing.Size(192, 20);
            this.TB_NombrePlantilla.TabIndex = 1;
            this.TB_NombrePlantilla.TextChanged += new System.EventHandler(this.actualizarBotones);
            // 
            // BT_GuardarPlantilla
            // 
            this.BT_GuardarPlantilla.Enabled = false;
            this.BT_GuardarPlantilla.Location = new System.Drawing.Point(538, 548);
            this.BT_GuardarPlantilla.Name = "BT_GuardarPlantilla";
            this.BT_GuardarPlantilla.Size = new System.Drawing.Size(128, 36);
            this.BT_GuardarPlantilla.TabIndex = 12;
            this.BT_GuardarPlantilla.Text = "Guardar plantilla";
            this.BT_GuardarPlantilla.UseVisualStyleBackColor = true;
            this.BT_GuardarPlantilla.Click += new System.EventHandler(this.BT_GuardarPlantilla_Click);
            // 
            // BT_EliminarRestriccion
            // 
            this.BT_EliminarRestriccion.Enabled = false;
            this.BT_EliminarRestriccion.Location = new System.Drawing.Point(345, 398);
            this.BT_EliminarRestriccion.Name = "BT_EliminarRestriccion";
            this.BT_EliminarRestriccion.Size = new System.Drawing.Size(79, 37);
            this.BT_EliminarRestriccion.TabIndex = 14;
            this.BT_EliminarRestriccion.Text = "Eliminar Restricciones";
            this.BT_EliminarRestriccion.UseVisualStyleBackColor = true;
            this.BT_EliminarRestriccion.Click += new System.EventHandler(this.BT_EliminarRestriccion_Click);
            // 
            // CHB_esParaExtraccion
            // 
            this.CHB_esParaExtraccion.AutoSize = true;
            this.CHB_esParaExtraccion.Location = new System.Drawing.Point(377, 8);
            this.CHB_esParaExtraccion.Name = "CHB_esParaExtraccion";
            this.CHB_esParaExtraccion.Size = new System.Drawing.Size(154, 17);
            this.CHB_esParaExtraccion.TabIndex = 15;
            this.CHB_esParaExtraccion.Text = "Es una plantilla de métricas";
            this.CHB_esParaExtraccion.UseVisualStyleBackColor = true;
            this.CHB_esParaExtraccion.CheckedChanged += new System.EventHandler(this.CHB_esParaExtraccion_CheckedChanged);
            // 
            // BT_EditarRestriccion
            // 
            this.BT_EditarRestriccion.Enabled = false;
            this.BT_EditarRestriccion.Location = new System.Drawing.Point(345, 441);
            this.BT_EditarRestriccion.Name = "BT_EditarRestriccion";
            this.BT_EditarRestriccion.Size = new System.Drawing.Size(79, 39);
            this.BT_EditarRestriccion.TabIndex = 16;
            this.BT_EditarRestriccion.Text = "Editar Restricción";
            this.BT_EditarRestriccion.UseVisualStyleBackColor = true;
            this.BT_EditarRestriccion.Click += new System.EventHandler(this.BT_EditarRestriccion_Click);
            // 
            // TB_NotaPlantilla
            // 
            this.TB_NotaPlantilla.Location = new System.Drawing.Point(450, 398);
            this.TB_NotaPlantilla.Multiline = true;
            this.TB_NotaPlantilla.Name = "TB_NotaPlantilla";
            this.TB_NotaPlantilla.Size = new System.Drawing.Size(216, 112);
            this.TB_NotaPlantilla.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(447, 382);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "3. Nota (opcional):";
            // 
            // GB_Condiciones
            // 
            this.GB_Condiciones.Controls.Add(this.L_VolPTVcc);
            this.GB_Condiciones.Controls.Add(this.label4);
            this.GB_Condiciones.Controls.Add(this.LB_ListaCondiciones);
            this.GB_Condiciones.Controls.Add(this.TB_Cond2);
            this.GB_Condiciones.Controls.Add(this.TB_Cond1);
            this.GB_Condiciones.Controls.Add(this.CB_cond1);
            this.GB_Condiciones.Controls.Add(this.BT_EliminarCondicion);
            this.GB_Condiciones.Controls.Add(this.LB_Condiciones);
            this.GB_Condiciones.Controls.Add(this.BT_AgregarCondicion);
            this.GB_Condiciones.Location = new System.Drawing.Point(30, 44);
            this.GB_Condiciones.Name = "GB_Condiciones";
            this.GB_Condiciones.Size = new System.Drawing.Size(553, 112);
            this.GB_Condiciones.TabIndex = 25;
            this.GB_Condiciones.TabStop = false;
            this.GB_Condiciones.Text = "2. Condiciones";
            // 
            // L_VolPTVcc
            // 
            this.L_VolPTVcc.AutoSize = true;
            this.L_VolPTVcc.Location = new System.Drawing.Point(16, 83);
            this.L_VolPTVcc.Name = "L_VolPTVcc";
            this.L_VolPTVcc.Size = new System.Drawing.Size(79, 13);
            this.L_VolPTVcc.TabIndex = 21;
            this.L_VolPTVcc.Text = "(VolPTV en cc)";
            this.L_VolPTVcc.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(12, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "y";
            this.label4.Visible = false;
            // 
            // LB_ListaCondiciones
            // 
            this.LB_ListaCondiciones.FormattingEnabled = true;
            this.LB_ListaCondiciones.Location = new System.Drawing.Point(262, 21);
            this.LB_ListaCondiciones.Name = "LB_ListaCondiciones";
            this.LB_ListaCondiciones.Size = new System.Drawing.Size(145, 82);
            this.LB_ListaCondiciones.TabIndex = 19;
            this.LB_ListaCondiciones.SelectedIndexChanged += new System.EventHandler(this.LB_ListaCondiciones_SelectedIndexChanged);
            // 
            // TB_Cond2
            // 
            this.TB_Cond2.Enabled = false;
            this.TB_Cond2.Location = new System.Drawing.Point(205, 50);
            this.TB_Cond2.Name = "TB_Cond2";
            this.TB_Cond2.Size = new System.Drawing.Size(51, 20);
            this.TB_Cond2.TabIndex = 18;
            // 
            // TB_Cond1
            // 
            this.TB_Cond1.Location = new System.Drawing.Point(205, 21);
            this.TB_Cond1.Name = "TB_Cond1";
            this.TB_Cond1.Size = new System.Drawing.Size(52, 20);
            this.TB_Cond1.TabIndex = 16;
            // 
            // CB_cond1
            // 
            this.CB_cond1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_cond1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_cond1.FormattingEnabled = true;
            this.CB_cond1.Location = new System.Drawing.Point(122, 19);
            this.CB_cond1.Name = "CB_cond1";
            this.CB_cond1.Size = new System.Drawing.Size(76, 21);
            this.CB_cond1.TabIndex = 15;
            this.CB_cond1.SelectedIndexChanged += new System.EventHandler(this.CB_cond1_SelectedIndexChanged);
            // 
            // BT_EliminarCondicion
            // 
            this.BT_EliminarCondicion.Location = new System.Drawing.Point(420, 21);
            this.BT_EliminarCondicion.Name = "BT_EliminarCondicion";
            this.BT_EliminarCondicion.Size = new System.Drawing.Size(113, 21);
            this.BT_EliminarCondicion.TabIndex = 14;
            this.BT_EliminarCondicion.Text = "Eliminar condición";
            this.BT_EliminarCondicion.UseVisualStyleBackColor = true;
            this.BT_EliminarCondicion.Click += new System.EventHandler(this.BT_EliminarCondicion_Click);
            // 
            // LB_Condiciones
            // 
            this.LB_Condiciones.FormattingEnabled = true;
            this.LB_Condiciones.Location = new System.Drawing.Point(9, 19);
            this.LB_Condiciones.Name = "LB_Condiciones";
            this.LB_Condiciones.Size = new System.Drawing.Size(107, 56);
            this.LB_Condiciones.TabIndex = 13;
            this.LB_Condiciones.SelectedIndexChanged += new System.EventHandler(this.LB_Condiciones_SelectedIndexChanged);
            // 
            // BT_AgregarCondicion
            // 
            this.BT_AgregarCondicion.Location = new System.Drawing.Point(140, 83);
            this.BT_AgregarCondicion.Name = "BT_AgregarCondicion";
            this.BT_AgregarCondicion.Size = new System.Drawing.Size(116, 23);
            this.BT_AgregarCondicion.TabIndex = 12;
            this.BT_AgregarCondicion.Text = "Agregar condición";
            this.BT_AgregarCondicion.UseVisualStyleBackColor = true;
            this.BT_AgregarCondicion.Click += new System.EventHandler(this.BT_AgregarCondicion_Click);
            // 
            // BT_IniciarCargaRestricciones
            // 
            this.BT_IniciarCargaRestricciones.Location = new System.Drawing.Point(589, 54);
            this.BT_IniciarCargaRestricciones.Name = "BT_IniciarCargaRestricciones";
            this.BT_IniciarCargaRestricciones.Size = new System.Drawing.Size(113, 41);
            this.BT_IniciarCargaRestricciones.TabIndex = 20;
            this.BT_IniciarCargaRestricciones.Text = "Iniciar carga de restricciones";
            this.BT_IniciarCargaRestricciones.UseVisualStyleBackColor = true;
            this.BT_IniciarCargaRestricciones.Click += new System.EventHandler(this.BT_IniciarCargaRestricciones_Click);
            // 
            // BT_FinalizarCargaRestricciones
            // 
            this.BT_FinalizarCargaRestricciones.Enabled = false;
            this.BT_FinalizarCargaRestricciones.Location = new System.Drawing.Point(589, 115);
            this.BT_FinalizarCargaRestricciones.Name = "BT_FinalizarCargaRestricciones";
            this.BT_FinalizarCargaRestricciones.Size = new System.Drawing.Size(113, 41);
            this.BT_FinalizarCargaRestricciones.TabIndex = 26;
            this.BT_FinalizarCargaRestricciones.Text = "Finalizar carga de restricciones";
            this.BT_FinalizarCargaRestricciones.UseVisualStyleBackColor = true;
            this.BT_FinalizarCargaRestricciones.Click += new System.EventHandler(this.BT_FinalizarCargaRestricciones_Click);
            // 
            // BT_RestriccionAbajo
            // 
            this.BT_RestriccionAbajo.BackgroundImage = global::ExploracionPlanes.Properties.Resources.icons8_abajo_en_círculo_2_50;
            this.BT_RestriccionAbajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_RestriccionAbajo.Enabled = false;
            this.BT_RestriccionAbajo.Location = new System.Drawing.Point(345, 526);
            this.BT_RestriccionAbajo.Name = "BT_RestriccionAbajo";
            this.BT_RestriccionAbajo.Size = new System.Drawing.Size(35, 34);
            this.BT_RestriccionAbajo.TabIndex = 18;
            this.BT_RestriccionAbajo.UseVisualStyleBackColor = true;
            this.BT_RestriccionAbajo.Click += new System.EventHandler(this.BT_RestriccionAbajo_Click);
            // 
            // BT_RestriccionArriba
            // 
            this.BT_RestriccionArriba.BackgroundImage = global::ExploracionPlanes.Properties.Resources.icons8_arriba_en_círculo_2_50;
            this.BT_RestriccionArriba.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BT_RestriccionArriba.Enabled = false;
            this.BT_RestriccionArriba.Location = new System.Drawing.Point(345, 486);
            this.BT_RestriccionArriba.Name = "BT_RestriccionArriba";
            this.BT_RestriccionArriba.Size = new System.Drawing.Size(35, 34);
            this.BT_RestriccionArriba.TabIndex = 17;
            this.BT_RestriccionArriba.UseVisualStyleBackColor = true;
            this.BT_RestriccionArriba.Click += new System.EventHandler(this.BT_RestriccionArriba_Click);
            // 
            // BT_CargarDesdePaciente
            // 
            this.BT_CargarDesdePaciente.Location = new System.Drawing.Point(112, 120);
            this.BT_CargarDesdePaciente.Name = "BT_CargarDesdePaciente";
            this.BT_CargarDesdePaciente.Size = new System.Drawing.Size(86, 39);
            this.BT_CargarDesdePaciente.TabIndex = 27;
            this.BT_CargarDesdePaciente.Text = "Cargar desde un paciente";
            this.BT_CargarDesdePaciente.UseVisualStyleBackColor = true;
            this.BT_CargarDesdePaciente.Click += new System.EventHandler(this.BT_CargarDesdePaciente_Click);
            // 
            // Form1_ext
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 600);
            this.Controls.Add(this.BT_FinalizarCargaRestricciones);
            this.Controls.Add(this.BT_IniciarCargaRestricciones);
            this.Controls.Add(this.GB_Condiciones);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TB_NotaPlantilla);
            this.Controls.Add(this.BT_RestriccionAbajo);
            this.Controls.Add(this.BT_RestriccionArriba);
            this.Controls.Add(this.BT_EditarRestriccion);
            this.Controls.Add(this.CHB_esParaExtraccion);
            this.Controls.Add(this.BT_EliminarRestriccion);
            this.Controls.Add(this.BT_GuardarPlantilla);
            this.Controls.Add(this.TB_NombrePlantilla);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GB_NuevaRestriccion);
            this.Controls.Add(this.LB_listaRestricciones);
            this.Name = "Form1_ext";
            this.Text = "Creación de plantillas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_ext_FormClosing);
            this.GB_NuevaRestriccion.ResumeLayout(false);
            this.GB_NuevaRestriccion.PerformLayout();
            this.Panel_esMenorque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_restricciones)).EndInit();
            this.GB_Condiciones.ResumeLayout(false);
            this.GB_Condiciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_TipoRestriccion;
        private System.Windows.Forms.Label L_CorrespA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CB_CorrespAUnidades;
        private System.Windows.Forms.TextBox TB_CorrespA;
        private System.Windows.Forms.ComboBox CB_MenorOMayor;
        private System.Windows.Forms.Button BT_AgregarALista;
        private System.Windows.Forms.ListBox LB_listaRestricciones;
        private System.Windows.Forms.GroupBox GB_NuevaRestriccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_NombrePlantilla;
        private System.Windows.Forms.Button BT_GuardarPlantilla;
        private System.Windows.Forms.ComboBox CB_Estructura;
        private System.Windows.Forms.Button BT_EliminarRestriccion;
        private System.Windows.Forms.TextBox TB_EstructuraNombresAlt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CHB_esParaExtraccion;
        private System.Windows.Forms.Panel Panel_esMenorque;
        private System.Windows.Forms.Button BT_EditarRestriccion;
        private System.Windows.Forms.Button BT_RestriccionArriba;
        private System.Windows.Forms.Button BT_RestriccionAbajo;
        private System.Windows.Forms.TextBox TB_NotaPlantilla;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_NotaRestriccion;
        private System.Windows.Forms.ComboBox CB_ValorEsperadoUnidades;
        private System.Windows.Forms.GroupBox GB_Condiciones;
        private System.Windows.Forms.Button BT_EliminarCondicion;
        private System.Windows.Forms.ListBox LB_Condiciones;
        private System.Windows.Forms.Button BT_AgregarCondicion;
        private System.Windows.Forms.ListBox LB_ListaCondiciones;
        private System.Windows.Forms.TextBox TB_Cond2;
        private System.Windows.Forms.TextBox TB_Cond1;
        private System.Windows.Forms.ComboBox CB_cond1;
        private System.Windows.Forms.DataGridView DGV_restricciones;
        private System.Windows.Forms.Button BT_IniciarCargaRestricciones;
        private System.Windows.Forms.Button BT_FinalizarCargaRestricciones;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label L_VolPTVcc;
        private System.Windows.Forms.Button BT_CargarDesdePaciente;
    }
}

