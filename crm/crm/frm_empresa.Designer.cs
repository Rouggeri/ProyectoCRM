namespace crm
{
    partial class frm_empresa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_empresa));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btn_guardar = new DevExpress.XtraEditors.SimpleButton();
            this.cbo_pais = new DevExpress.XtraEditors.LookUpEdit();
            this.txt_direccion = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_telefono2 = new System.Windows.Forms.TextBox();
            this.txt_telefono1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_pais.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl1.CaptionImage")));
            this.groupControl1.Controls.Add(this.btn_guardar);
            this.groupControl1.Controls.Add(this.cbo_pais);
            this.groupControl1.Controls.Add(this.txt_direccion);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txt_email);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.txt_telefono2);
            this.groupControl1.Controls.Add(this.txt_telefono1);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txt_nombre);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(926, 460);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos:";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(426, 354);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 31);
            this.btn_guardar.TabIndex = 10;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // cbo_pais
            // 
            this.cbo_pais.EditValue = "pais";
            this.cbo_pais.Location = new System.Drawing.Point(532, 216);
            this.cbo_pais.Name = "cbo_pais";
            this.cbo_pais.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_pais.Size = new System.Drawing.Size(133, 20);
            this.cbo_pais.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(302, 216);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(224, 63);
            this.txt_direccion.TabIndex = 8;
            this.txt_direccion.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(177, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Direccón";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(302, 167);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(363, 21);
            this.txt_email.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Email";
            // 
            // txt_telefono2
            // 
            this.txt_telefono2.Location = new System.Drawing.Point(491, 119);
            this.txt_telefono2.Name = "txt_telefono2";
            this.txt_telefono2.Size = new System.Drawing.Size(174, 21);
            this.txt_telefono2.TabIndex = 4;
            // 
            // txt_telefono1
            // 
            this.txt_telefono1.Location = new System.Drawing.Point(302, 119);
            this.txt_telefono1.Name = "txt_telefono1";
            this.txt_telefono1.Size = new System.Drawing.Size(174, 21);
            this.txt_telefono1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(171, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Telefonos";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(302, 73);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(363, 21);
            this.txt_nombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre de la empresa";
            // 
            // frm_empresa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 460);
            this.Controls.Add(this.groupControl1);
            this.Name = "frm_empresa";
            this.Text = "Empresa";
            this.Load += new System.EventHandler(this.frm_empresa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_pais.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_telefono2;
        private System.Windows.Forms.TextBox txt_telefono1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_direccion;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit cbo_pais;
        private DevExpress.XtraEditors.SimpleButton btn_guardar;
    }
}