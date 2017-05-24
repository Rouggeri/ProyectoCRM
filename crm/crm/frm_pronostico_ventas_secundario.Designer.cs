﻿namespace crm
{
    partial class frm_pronostico_ventas_secundario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_pronostico_ventas_secundario));
            DevExpress.XtraCharts.SwiftPlotDiagram swiftPlotDiagram1 = new DevExpress.XtraCharts.SwiftPlotDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            DevExpress.XtraCharts.SwiftPlotSeriesView swiftPlotSeriesView1 = new DevExpress.XtraCharts.SwiftPlotSeriesView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.dgv_detalle = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_seleccionar_clasificacion = new System.Windows.Forms.RadioButton();
            this.rbt_todos_clasificacion = new System.Windows.Forms.RadioButton();
            this.cmb_clasificacion = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_seleccionar_categoria = new System.Windows.Forms.RadioButton();
            this.rbt_todos_categoria = new System.Windows.Forms.RadioButton();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_siguiente_mes = new System.Windows.Forms.RadioButton();
            this.rbt_sig_trimestre = new System.Windows.Forms.RadioButton();
            this.rbt_sig_anio = new System.Windows.Forms.RadioButton();
            this.btn_pronosticar = new DevExpress.XtraEditors.SimpleButton();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbt_clasificacion_p_movil = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.cmb_clasificacion_p_movil = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbt_categoria_p_movil = new System.Windows.Forms.RadioButton();
            this.rbt_categproa_p_movil_todos = new System.Windows.Forms.RadioButton();
            this.cmb_categoria_p_movil = new System.Windows.Forms.ComboBox();
            this.btn_promedio_moviles = new DevExpress.XtraEditors.SimpleButton();
            this.dgv_complemento = new System.Windows.Forms.DataGridView();
            this.dgv_tabla_result = new System.Windows.Forms.DataGridView();
            this.dgv_consulta_negos_ventas = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmb_metodo = new System.Windows.Forms.ComboBox();
            this.ctc_pronostico = new DevExpress.XtraCharts.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_complemento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_negos_ventas)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctc_pronostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.groupControl2);
            this.groupControl1.Controls.Add(this.xtraTabControl1);
            this.groupControl1.Controls.Add(this.dgv_complemento);
            this.groupControl1.Controls.Add(this.dgv_tabla_result);
            this.groupControl1.Controls.Add(this.dgv_consulta_negos_ventas);
            this.groupControl1.Controls.Add(this.groupBox4);
            this.groupControl1.Controls.Add(this.ctc_pronostico);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1230, 609);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Proyecciones";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.dgv_detalle);
            this.groupControl2.Location = new System.Drawing.Point(864, 125);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(467, 473);
            this.groupControl2.TabIndex = 30;
            this.groupControl2.Text = "Detalles de Ventas";
            // 
            // dgv_detalle
            // 
            this.dgv_detalle.Location = new System.Drawing.Point(0, 20);
            this.dgv_detalle.MainView = this.gridView1;
            this.dgv_detalle.Name = "dgv_detalle";
            this.dgv_detalle.Size = new System.Drawing.Size(467, 453);
            this.dgv_detalle.TabIndex = 29;
            this.dgv_detalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.dgv_detalle;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsPrint.AutoWidth = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Location = new System.Drawing.Point(44, 102);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(814, 207);
            this.xtraTabControl1.TabIndex = 28;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.groupBox1);
            this.xtraTabPage1.Controls.Add(this.groupBox3);
            this.xtraTabPage1.Controls.Add(this.groupBox2);
            this.xtraTabPage1.Controls.Add(this.btn_pronosticar);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(808, 179);
            this.xtraTabPage1.Text = "Minimos Cuadrados";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_seleccionar_clasificacion);
            this.groupBox1.Controls.Add(this.rbt_todos_clasificacion);
            this.groupBox1.Controls.Add(this.cmb_clasificacion);
            this.groupBox1.Location = new System.Drawing.Point(23, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clasificación";
            // 
            // rbt_seleccionar_clasificacion
            // 
            this.rbt_seleccionar_clasificacion.AutoSize = true;
            this.rbt_seleccionar_clasificacion.Location = new System.Drawing.Point(6, 30);
            this.rbt_seleccionar_clasificacion.Name = "rbt_seleccionar_clasificacion";
            this.rbt_seleccionar_clasificacion.Size = new System.Drawing.Size(79, 17);
            this.rbt_seleccionar_clasificacion.TabIndex = 0;
            this.rbt_seleccionar_clasificacion.TabStop = true;
            this.rbt_seleccionar_clasificacion.Text = "Seleccionar";
            this.rbt_seleccionar_clasificacion.UseVisualStyleBackColor = true;
            this.rbt_seleccionar_clasificacion.CheckedChanged += new System.EventHandler(this.rbt_seleccionar_clasificacion_CheckedChanged);
            // 
            // rbt_todos_clasificacion
            // 
            this.rbt_todos_clasificacion.AutoSize = true;
            this.rbt_todos_clasificacion.Location = new System.Drawing.Point(107, 30);
            this.rbt_todos_clasificacion.Name = "rbt_todos_clasificacion";
            this.rbt_todos_clasificacion.Size = new System.Drawing.Size(54, 17);
            this.rbt_todos_clasificacion.TabIndex = 1;
            this.rbt_todos_clasificacion.TabStop = true;
            this.rbt_todos_clasificacion.Text = "Todos";
            this.rbt_todos_clasificacion.UseVisualStyleBackColor = true;
            this.rbt_todos_clasificacion.Visible = false;
            this.rbt_todos_clasificacion.CheckedChanged += new System.EventHandler(this.rbt_todos_clasificacion_CheckedChanged);
            // 
            // cmb_clasificacion
            // 
            this.cmb_clasificacion.FormattingEnabled = true;
            this.cmb_clasificacion.Items.AddRange(new object[] {
            "",
            "Negocios",
            "Ventas"});
            this.cmb_clasificacion.Location = new System.Drawing.Point(7, 54);
            this.cmb_clasificacion.Name = "cmb_clasificacion";
            this.cmb_clasificacion.Size = new System.Drawing.Size(187, 21);
            this.cmb_clasificacion.TabIndex = 2;
            this.cmb_clasificacion.SelectedIndexChanged += new System.EventHandler(this.cmb_clasificacion_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_seleccionar_categoria);
            this.groupBox3.Controls.Add(this.rbt_todos_categoria);
            this.groupBox3.Controls.Add(this.cmb_categoria);
            this.groupBox3.Location = new System.Drawing.Point(247, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 100);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Categoria";
            // 
            // rbt_seleccionar_categoria
            // 
            this.rbt_seleccionar_categoria.AutoSize = true;
            this.rbt_seleccionar_categoria.Location = new System.Drawing.Point(6, 30);
            this.rbt_seleccionar_categoria.Name = "rbt_seleccionar_categoria";
            this.rbt_seleccionar_categoria.Size = new System.Drawing.Size(79, 17);
            this.rbt_seleccionar_categoria.TabIndex = 0;
            this.rbt_seleccionar_categoria.TabStop = true;
            this.rbt_seleccionar_categoria.Text = "Seleccionar";
            this.rbt_seleccionar_categoria.UseVisualStyleBackColor = true;
            this.rbt_seleccionar_categoria.CheckedChanged += new System.EventHandler(this.rbt_seleccionar_categoria_CheckedChanged);
            // 
            // rbt_todos_categoria
            // 
            this.rbt_todos_categoria.AutoSize = true;
            this.rbt_todos_categoria.Location = new System.Drawing.Point(107, 30);
            this.rbt_todos_categoria.Name = "rbt_todos_categoria";
            this.rbt_todos_categoria.Size = new System.Drawing.Size(54, 17);
            this.rbt_todos_categoria.TabIndex = 1;
            this.rbt_todos_categoria.TabStop = true;
            this.rbt_todos_categoria.Text = "Todos";
            this.rbt_todos_categoria.UseVisualStyleBackColor = true;
            this.rbt_todos_categoria.CheckedChanged += new System.EventHandler(this.rbt_todos_categoria_CheckedChanged);
            // 
            // cmb_categoria
            // 
            this.cmb_categoria.FormattingEnabled = true;
            this.cmb_categoria.Location = new System.Drawing.Point(7, 54);
            this.cmb_categoria.Name = "cmb_categoria";
            this.cmb_categoria.Size = new System.Drawing.Size(187, 21);
            this.cmb_categoria.TabIndex = 2;
            this.cmb_categoria.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_siguiente_mes);
            this.groupBox2.Controls.Add(this.rbt_sig_trimestre);
            this.groupBox2.Controls.Add(this.rbt_sig_anio);
            this.groupBox2.Location = new System.Drawing.Point(453, 29);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 100);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tiempo";
            // 
            // rbt_siguiente_mes
            // 
            this.rbt_siguiente_mes.AutoSize = true;
            this.rbt_siguiente_mes.Location = new System.Drawing.Point(6, 30);
            this.rbt_siguiente_mes.Name = "rbt_siguiente_mes";
            this.rbt_siguiente_mes.Size = new System.Drawing.Size(91, 17);
            this.rbt_siguiente_mes.TabIndex = 3;
            this.rbt_siguiente_mes.TabStop = true;
            this.rbt_siguiente_mes.Tag = "";
            this.rbt_siguiente_mes.Text = "Siguiente mes";
            this.rbt_siguiente_mes.UseVisualStyleBackColor = true;
            // 
            // rbt_sig_trimestre
            // 
            this.rbt_sig_trimestre.AutoSize = true;
            this.rbt_sig_trimestre.Location = new System.Drawing.Point(106, 30);
            this.rbt_sig_trimestre.Name = "rbt_sig_trimestre";
            this.rbt_sig_trimestre.Size = new System.Drawing.Size(115, 17);
            this.rbt_sig_trimestre.TabIndex = 4;
            this.rbt_sig_trimestre.TabStop = true;
            this.rbt_sig_trimestre.Tag = "";
            this.rbt_sig_trimestre.Text = "Siguiente trimestre";
            this.rbt_sig_trimestre.UseVisualStyleBackColor = true;
            // 
            // rbt_sig_anio
            // 
            this.rbt_sig_anio.AutoSize = true;
            this.rbt_sig_anio.Location = new System.Drawing.Point(234, 30);
            this.rbt_sig_anio.Name = "rbt_sig_anio";
            this.rbt_sig_anio.Size = new System.Drawing.Size(90, 17);
            this.rbt_sig_anio.TabIndex = 5;
            this.rbt_sig_anio.TabStop = true;
            this.rbt_sig_anio.Tag = "";
            this.rbt_sig_anio.Text = "Siguiente año";
            this.rbt_sig_anio.UseVisualStyleBackColor = true;
            // 
            // btn_pronosticar
            // 
            this.btn_pronosticar.Location = new System.Drawing.Point(336, 135);
            this.btn_pronosticar.Name = "btn_pronosticar";
            this.btn_pronosticar.Size = new System.Drawing.Size(105, 39);
            this.btn_pronosticar.TabIndex = 18;
            this.btn_pronosticar.Text = "Minimos Cuadrados";
            this.btn_pronosticar.Click += new System.EventHandler(this.btn_pronosticar_Click);
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.groupBox5);
            this.xtraTabPage2.Controls.Add(this.groupBox6);
            this.xtraTabPage2.Controls.Add(this.btn_promedio_moviles);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(808, 179);
            this.xtraTabPage2.Text = "Promedio Movil";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbt_clasificacion_p_movil);
            this.groupBox5.Controls.Add(this.radioButton2);
            this.groupBox5.Controls.Add(this.cmb_clasificacion_p_movil);
            this.groupBox5.Location = new System.Drawing.Point(12, 15);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 100);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Clasificación";
            // 
            // rbt_clasificacion_p_movil
            // 
            this.rbt_clasificacion_p_movil.AutoSize = true;
            this.rbt_clasificacion_p_movil.Location = new System.Drawing.Point(6, 30);
            this.rbt_clasificacion_p_movil.Name = "rbt_clasificacion_p_movil";
            this.rbt_clasificacion_p_movil.Size = new System.Drawing.Size(79, 17);
            this.rbt_clasificacion_p_movil.TabIndex = 0;
            this.rbt_clasificacion_p_movil.TabStop = true;
            this.rbt_clasificacion_p_movil.Text = "Seleccionar";
            this.rbt_clasificacion_p_movil.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 30);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(54, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Todos";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Visible = false;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // cmb_clasificacion_p_movil
            // 
            this.cmb_clasificacion_p_movil.FormattingEnabled = true;
            this.cmb_clasificacion_p_movil.Items.AddRange(new object[] {
            "",
            "Negocios",
            "Ventas"});
            this.cmb_clasificacion_p_movil.Location = new System.Drawing.Point(7, 54);
            this.cmb_clasificacion_p_movil.Name = "cmb_clasificacion_p_movil";
            this.cmb_clasificacion_p_movil.Size = new System.Drawing.Size(187, 21);
            this.cmb_clasificacion_p_movil.TabIndex = 2;
            this.cmb_clasificacion_p_movil.SelectedIndexChanged += new System.EventHandler(this.cmb_clasificacion_p_movil_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbt_categoria_p_movil);
            this.groupBox6.Controls.Add(this.rbt_categproa_p_movil_todos);
            this.groupBox6.Controls.Add(this.cmb_categoria_p_movil);
            this.groupBox6.Location = new System.Drawing.Point(236, 15);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(200, 100);
            this.groupBox6.TabIndex = 29;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Categoria";
            // 
            // rbt_categoria_p_movil
            // 
            this.rbt_categoria_p_movil.AutoSize = true;
            this.rbt_categoria_p_movil.Location = new System.Drawing.Point(6, 30);
            this.rbt_categoria_p_movil.Name = "rbt_categoria_p_movil";
            this.rbt_categoria_p_movil.Size = new System.Drawing.Size(79, 17);
            this.rbt_categoria_p_movil.TabIndex = 0;
            this.rbt_categoria_p_movil.TabStop = true;
            this.rbt_categoria_p_movil.Text = "Seleccionar";
            this.rbt_categoria_p_movil.UseVisualStyleBackColor = true;
            // 
            // rbt_categproa_p_movil_todos
            // 
            this.rbt_categproa_p_movil_todos.AutoSize = true;
            this.rbt_categproa_p_movil_todos.Location = new System.Drawing.Point(107, 30);
            this.rbt_categproa_p_movil_todos.Name = "rbt_categproa_p_movil_todos";
            this.rbt_categproa_p_movil_todos.Size = new System.Drawing.Size(54, 17);
            this.rbt_categproa_p_movil_todos.TabIndex = 1;
            this.rbt_categproa_p_movil_todos.TabStop = true;
            this.rbt_categproa_p_movil_todos.Text = "Todos";
            this.rbt_categproa_p_movil_todos.UseVisualStyleBackColor = true;
            this.rbt_categproa_p_movil_todos.CheckedChanged += new System.EventHandler(this.rbt_categproa_p_movil_todos_CheckedChanged);
            // 
            // cmb_categoria_p_movil
            // 
            this.cmb_categoria_p_movil.FormattingEnabled = true;
            this.cmb_categoria_p_movil.Location = new System.Drawing.Point(7, 54);
            this.cmb_categoria_p_movil.Name = "cmb_categoria_p_movil";
            this.cmb_categoria_p_movil.Size = new System.Drawing.Size(187, 21);
            this.cmb_categoria_p_movil.TabIndex = 2;
            this.cmb_categoria_p_movil.SelectedIndexChanged += new System.EventHandler(this.cmb_categoria_p_movil_SelectedIndexChanged);
            // 
            // btn_promedio_moviles
            // 
            this.btn_promedio_moviles.Location = new System.Drawing.Point(476, 78);
            this.btn_promedio_moviles.Name = "btn_promedio_moviles";
            this.btn_promedio_moviles.Size = new System.Drawing.Size(112, 37);
            this.btn_promedio_moviles.TabIndex = 27;
            this.btn_promedio_moviles.Text = "Promedios Moviles";
            this.btn_promedio_moviles.Click += new System.EventHandler(this.btn_promedio_moviles_Click);
            // 
            // dgv_complemento
            // 
            this.dgv_complemento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_complemento.Location = new System.Drawing.Point(37, 62);
            this.dgv_complemento.Name = "dgv_complemento";
            this.dgv_complemento.Size = new System.Drawing.Size(10, 10);
            this.dgv_complemento.TabIndex = 26;
            this.dgv_complemento.Visible = false;
            // 
            // dgv_tabla_result
            // 
            this.dgv_tabla_result.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tabla_result.Location = new System.Drawing.Point(21, 63);
            this.dgv_tabla_result.Name = "dgv_tabla_result";
            this.dgv_tabla_result.Size = new System.Drawing.Size(10, 10);
            this.dgv_tabla_result.TabIndex = 25;
            this.dgv_tabla_result.Visible = false;
            // 
            // dgv_consulta_negos_ventas
            // 
            this.dgv_consulta_negos_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_consulta_negos_ventas.Location = new System.Drawing.Point(5, 63);
            this.dgv_consulta_negos_ventas.Name = "dgv_consulta_negos_ventas";
            this.dgv_consulta_negos_ventas.Size = new System.Drawing.Size(10, 10);
            this.dgv_consulta_negos_ventas.TabIndex = 24;
            this.dgv_consulta_negos_ventas.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmb_metodo);
            this.groupBox4.Location = new System.Drawing.Point(890, 63);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(10, 10);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Metodo";
            // 
            // cmb_metodo
            // 
            this.cmb_metodo.FormattingEnabled = true;
            this.cmb_metodo.Items.AddRange(new object[] {
            "",
            "Minimos cuadrados"});
            this.cmb_metodo.Location = new System.Drawing.Point(7, 54);
            this.cmb_metodo.Name = "cmb_metodo";
            this.cmb_metodo.Size = new System.Drawing.Size(187, 21);
            this.cmb_metodo.TabIndex = 2;
            this.cmb_metodo.SelectedIndexChanged += new System.EventHandler(this.cmb_metodo_SelectedIndexChanged);
            // 
            // ctc_pronostico
            // 
            this.ctc_pronostico.AppearanceNameSerializable = "Light";
            this.ctc_pronostico.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ctc_pronostico.Diagram = swiftPlotDiagram1;
            this.ctc_pronostico.Location = new System.Drawing.Point(45, 330);
            this.ctc_pronostico.Name = "ctc_pronostico";
            this.ctc_pronostico.PaletteName = "Default";
            series1.Name = "Serie1";
            swiftPlotSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(108)))), ((int)(((byte)(9)))));
            series1.View = swiftPlotSeriesView1;
            this.ctc_pronostico.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ctc_pronostico.Size = new System.Drawing.Size(808, 245);
            this.ctc_pronostico.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "Proyección de ventas";
            // 
            // frm_pronostico_ventas_secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1230, 609);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_pronostico_ventas_secundario";
            this.Text = "Proyección de ventas";
            this.Load += new System.EventHandler(this.frm_pronostico_ventas_secundario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_detalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.xtraTabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_complemento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tabla_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_consulta_negos_ventas)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctc_pronostico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbt_seleccionar_categoria;
        private System.Windows.Forms.RadioButton rbt_todos_categoria;
        private System.Windows.Forms.ComboBox cmb_categoria;
        private DevExpress.XtraCharts.ChartControl ctc_pronostico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbt_siguiente_mes;
        private System.Windows.Forms.RadioButton rbt_sig_trimestre;
        private System.Windows.Forms.RadioButton rbt_sig_anio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_seleccionar_clasificacion;
        private System.Windows.Forms.RadioButton rbt_todos_clasificacion;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private DevExpress.XtraEditors.SimpleButton btn_pronosticar;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cmb_metodo;
        private System.Windows.Forms.DataGridView dgv_consulta_negos_ventas;
        private System.Windows.Forms.DataGridView dgv_tabla_result;
        private System.Windows.Forms.DataGridView dgv_complemento;
        private DevExpress.XtraEditors.SimpleButton btn_promedio_moviles;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rbt_clasificacion_p_movil;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cmb_clasificacion_p_movil;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbt_categoria_p_movil;
        private System.Windows.Forms.RadioButton rbt_categproa_p_movil_todos;
        private System.Windows.Forms.ComboBox cmb_categoria_p_movil;
        private DevExpress.XtraGrid.GridControl dgv_detalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
    }
}