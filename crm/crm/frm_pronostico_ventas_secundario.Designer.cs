namespace crm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbt_seleccionar_categoria = new System.Windows.Forms.RadioButton();
            this.rbt_todos_categoria = new System.Windows.Forms.RadioButton();
            this.cmb_categoria = new System.Windows.Forms.ComboBox();
            this.ctc_pronostico = new DevExpress.XtraCharts.ChartControl();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbt_siguiente_mes = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbt_seleccionar_clasificacion = new System.Windows.Forms.RadioButton();
            this.rbt_todos_clasificacion = new System.Windows.Forms.RadioButton();
            this.cmb_clasificacion = new System.Windows.Forms.ComboBox();
            this.btn_pronosticar = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctc_pronostico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor2 = System.Drawing.Color.White;
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.groupBox3);
            this.groupControl1.Controls.Add(this.ctc_pronostico);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.groupBox2);
            this.groupControl1.Controls.Add(this.groupBox1);
            this.groupControl1.Controls.Add(this.btn_pronosticar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1061, 515);
            this.groupControl1.TabIndex = 31;
            this.groupControl1.Text = "Proyecciones";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbt_seleccionar_categoria);
            this.groupBox3.Controls.Add(this.rbt_todos_categoria);
            this.groupBox3.Controls.Add(this.cmb_categoria);
            this.groupBox3.Location = new System.Drawing.Point(256, 98);
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
            // ctc_pronostico
            // 
            this.ctc_pronostico.AppearanceNameSerializable = "Dark";
            this.ctc_pronostico.BorderOptions.Visibility = DevExpress.Utils.DefaultBoolean.True;
            swiftPlotDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            swiftPlotDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.ctc_pronostico.Diagram = swiftPlotDiagram1;
            this.ctc_pronostico.Location = new System.Drawing.Point(27, 270);
            this.ctc_pronostico.Name = "ctc_pronostico";
            this.ctc_pronostico.PaletteName = "Default";
            series1.Name = "Serie1";
            swiftPlotSeriesView1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(108)))), ((int)(((byte)(9)))));
            series1.View = swiftPlotSeriesView1;
            this.ctc_pronostico.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.ctc_pronostico.Size = new System.Drawing.Size(952, 200);
            this.ctc_pronostico.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Pronostico de ventas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbt_siguiente_mes);
            this.groupBox2.Controls.Add(this.radioButton4);
            this.groupBox2.Controls.Add(this.radioButton5);
            this.groupBox2.Controls.Add(this.radioButton6);
            this.groupBox2.Location = new System.Drawing.Point(471, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 100);
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
            this.rbt_siguiente_mes.Text = "Siguiente mes";
            this.rbt_siguiente_mes.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(106, 30);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(115, 17);
            this.radioButton4.TabIndex = 4;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Siguiente trimestre";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(234, 30);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(90, 17);
            this.radioButton5.TabIndex = 5;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Siguiente año";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(351, 30);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(141, 17);
            this.radioButton6.TabIndex = 6;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "Busqueda Personalizada";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbt_seleccionar_clasificacion);
            this.groupBox1.Controls.Add(this.rbt_todos_clasificacion);
            this.groupBox1.Controls.Add(this.cmb_clasificacion);
            this.groupBox1.Location = new System.Drawing.Point(22, 98);
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
            // btn_pronosticar
            // 
            this.btn_pronosticar.Location = new System.Drawing.Point(28, 230);
            this.btn_pronosticar.Name = "btn_pronosticar";
            this.btn_pronosticar.Size = new System.Drawing.Size(75, 23);
            this.btn_pronosticar.TabIndex = 18;
            this.btn_pronosticar.Text = "Pronosticar";
            // 
            // frm_pronostico_ventas_secundario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 515);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_pronostico_ventas_secundario";
            this.Text = "Proyección de ventas";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(swiftPlotSeriesView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctc_pronostico)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbt_seleccionar_clasificacion;
        private System.Windows.Forms.RadioButton rbt_todos_clasificacion;
        private System.Windows.Forms.ComboBox cmb_clasificacion;
        private DevExpress.XtraEditors.SimpleButton btn_pronosticar;
    }
}