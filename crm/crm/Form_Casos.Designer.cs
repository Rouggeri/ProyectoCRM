namespace crm
{
    partial class Form_Casos
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
            this.btn_nuevocaso = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btn_nuevocaso
            // 
            this.btn_nuevocaso.Location = new System.Drawing.Point(89, 38);
            this.btn_nuevocaso.Name = "btn_nuevocaso";
            this.btn_nuevocaso.Size = new System.Drawing.Size(109, 30);
            this.btn_nuevocaso.TabIndex = 0;
            this.btn_nuevocaso.Text = "Nuevo caso";
            this.btn_nuevocaso.Click += new System.EventHandler(this.btn_nuevocaso_Click);
            // 
            // Form_Casos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 459);
            this.Controls.Add(this.btn_nuevocaso);
            this.Name = "Form_Casos";
            this.Text = "Form_Casos";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btn_nuevocaso;
    }
}