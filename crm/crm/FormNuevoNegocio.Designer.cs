namespace crm
{
    partial class FormNuevoNegocio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNuevoNegocio));
            this.dtp_fecha_cierre = new DevExpress.XtraEditors.DateEdit();
            this.lbl_titulo = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txt_titulo = new System.Windows.Forms.TextBox();
            this.cbo_quien = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cbo_perem = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_detalles = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_moneda = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txt_valor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_categoria = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btn_nueva = new DevExpress.XtraEditors.SimpleButton();
            this.btn_refesh = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_quien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_perem.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_categoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtp_fecha_cierre
            // 
            this.dtp_fecha_cierre.EditValue = null;
            this.dtp_fecha_cierre.Location = new System.Drawing.Point(360, 315);
            this.dtp_fecha_cierre.Name = "dtp_fecha_cierre";
            this.dtp_fecha_cierre.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_fecha_cierre.Size = new System.Drawing.Size(428, 20);
            this.dtp_fecha_cierre.TabIndex = 0;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Location = new System.Drawing.Point(178, 82);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(118, 13);
            this.lbl_titulo.TabIndex = 1;
            this.lbl_titulo.Text = "Titulo de la negociación";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(153, 123);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(145, 13);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = " ¿Con quién es la negociación?";
            // 
            // txt_titulo
            // 
            this.txt_titulo.Location = new System.Drawing.Point(360, 75);
            this.txt_titulo.Name = "txt_titulo";
            this.txt_titulo.Size = new System.Drawing.Size(428, 21);
            this.txt_titulo.TabIndex = 3;
            // 
            // cbo_quien
            // 
            this.cbo_quien.Location = new System.Drawing.Point(360, 120);
            this.cbo_quien.Name = "cbo_quien";
            this.cbo_quien.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_quien.Properties.DropDownRows = 2;
            this.cbo_quien.Properties.Items.AddRange(new object[] {
            "Empresa",
            "Persona"});
            this.cbo_quien.Size = new System.Drawing.Size(100, 20);
            this.cbo_quien.TabIndex = 4;
            // 
            // cbo_perem
            // 
            this.cbo_perem.Location = new System.Drawing.Point(466, 120);
            this.cbo_perem.Name = "cbo_perem";
            this.cbo_perem.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_perem.Properties.DropDownRows = 2;
            this.cbo_perem.Properties.Items.AddRange(new object[] {
            "Empresa",
            "Persona"});
            this.cbo_perem.Size = new System.Drawing.Size(188, 20);
            this.cbo_perem.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(253, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Detalles";
            // 
            // txt_detalles
            // 
            this.txt_detalles.Location = new System.Drawing.Point(360, 163);
            this.txt_detalles.Name = "txt_detalles";
            this.txt_detalles.Size = new System.Drawing.Size(428, 60);
            this.txt_detalles.TabIndex = 7;
            this.txt_detalles.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor del negocio";
            // 
            // cbo_moneda
            // 
            this.cbo_moneda.Location = new System.Drawing.Point(360, 238);
            this.cbo_moneda.Name = "cbo_moneda";
            this.cbo_moneda.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_moneda.Properties.DropDownRows = 2;
            this.cbo_moneda.Properties.Items.AddRange(new object[] {
            "Empresa",
            "Persona"});
            this.cbo_moneda.Size = new System.Drawing.Size(100, 20);
            this.cbo_moneda.TabIndex = 9;
            // 
            // txt_valor
            // 
            this.txt_valor.Location = new System.Drawing.Point(466, 238);
            this.txt_valor.Name = "txt_valor";
            this.txt_valor.Size = new System.Drawing.Size(322, 21);
            this.txt_valor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(244, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Categoría";
            // 
            // cbo_categoria
            // 
            this.cbo_categoria.Location = new System.Drawing.Point(360, 276);
            this.cbo_categoria.Name = "cbo_categoria";
            this.cbo_categoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_categoria.Properties.DropDownRows = 2;
            this.cbo_categoria.Properties.Items.AddRange(new object[] {
            "Empresa",
            "Persona"});
            this.cbo_categoria.Size = new System.Drawing.Size(294, 20);
            this.cbo_categoria.TabIndex = 12;
            // 
            // btn_nueva
            // 
            this.btn_nueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nueva.Image = ((System.Drawing.Image)(resources.GetObject("btn_nueva.Image")));
            this.btn_nueva.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_nueva.Location = new System.Drawing.Point(660, 273);
            this.btn_nueva.Name = "btn_nueva";
            this.btn_nueva.Size = new System.Drawing.Size(61, 23);
            this.btn_nueva.TabIndex = 13;
            // 
            // btn_refesh
            // 
            this.btn_refesh.Image = ((System.Drawing.Image)(resources.GetObject("btn_refesh.Image")));
            this.btn_refesh.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.btn_refesh.Location = new System.Drawing.Point(727, 273);
            this.btn_refesh.Name = "btn_refesh";
            this.btn_refesh.Size = new System.Drawing.Size(61, 23);
            this.btn_refesh.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Fecha estimada de cierre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Empleado responsable";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(360, 351);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.DropDownRows = 2;
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Empresa",
            "Persona"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(294, 20);
            this.comboBoxEdit1.TabIndex = 17;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton1.Location = new System.Drawing.Point(660, 349);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(61, 23);
            this.simpleButton1.TabIndex = 18;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.Image")));
            this.simpleButton2.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton2.Location = new System.Drawing.Point(727, 348);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(61, 23);
            this.simpleButton2.TabIndex = 19;
            // 
            // simpleButton3
            // 
            this.simpleButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton3.Location = new System.Drawing.Point(660, 117);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(61, 23);
            this.simpleButton3.TabIndex = 20;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.Image")));
            this.simpleButton4.ImageLocation = DevExpress.XtraEditors.ImageLocation.BottomCenter;
            this.simpleButton4.Location = new System.Drawing.Point(727, 117);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(61, 23);
            this.simpleButton4.TabIndex = 21;
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.CaptionLocation = DevExpress.Utils.Locations.Top;
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.simpleButton4);
            this.groupControl1.Controls.Add(this.dtp_fecha_cierre);
            this.groupControl1.Controls.Add(this.simpleButton3);
            this.groupControl1.Controls.Add(this.lbl_titulo);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.txt_titulo);
            this.groupControl1.Controls.Add(this.comboBoxEdit1);
            this.groupControl1.Controls.Add(this.cbo_quien);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.cbo_perem);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.btn_refesh);
            this.groupControl1.Controls.Add(this.txt_detalles);
            this.groupControl1.Controls.Add(this.btn_nueva);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.cbo_categoria);
            this.groupControl1.Controls.Add(this.cbo_moneda);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_valor);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(888, 477);
            this.groupControl1.TabIndex = 22;
            this.groupControl1.Text = "Datos del negocio:";
            // 
            // FormNuevoNegocio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 477);
            this.Controls.Add(this.groupControl1);
            this.Name = "FormNuevoNegocio";
            this.Text = "Nuevo Negocio";
            this.Load += new System.EventHandler(this.FormNuevoNegocio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_fecha_cierre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_quien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_perem.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_moneda.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_categoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtp_fecha_cierre;
        private System.Windows.Forms.Label lbl_titulo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox txt_titulo;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_quien;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_perem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_detalles;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_moneda;
        private System.Windows.Forms.TextBox txt_valor;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_categoria;
        private DevExpress.XtraEditors.SimpleButton btn_nueva;
        private DevExpress.XtraEditors.SimpleButton btn_refesh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}