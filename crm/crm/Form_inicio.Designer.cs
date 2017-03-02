namespace crm
{
    partial class Form_inicio
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
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.tile = new DevExpress.XtraEditors.TileControl();
            this.Grupo1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.item_negocios = new DevExpress.XtraEditors.TileItem();
            this.item_contacto = new DevExpress.XtraEditors.TileItem();
            this.item_calendario = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileItem8 = new DevExpress.XtraEditors.TileItem();
            this.SuspendLayout();
            // 
            // tile
            // 
            this.tile.AppearanceItem.Hovered.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tile.AppearanceItem.Hovered.Options.UseFont = true;
            this.tile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tile.DragSize = new System.Drawing.Size(0, 0);
            this.tile.Groups.Add(this.Grupo1);
            this.tile.Groups.Add(this.tileGroup2);
            this.tile.Groups.Add(this.tileGroup3);
            this.tile.ItemSize = 130;
            this.tile.Location = new System.Drawing.Point(0, 0);
            this.tile.MaxId = 20;
            this.tile.Name = "tile";
            this.tile.SelectionColor = System.Drawing.Color.LightSkyBlue;
            this.tile.Size = new System.Drawing.Size(942, 448);
            this.tile.TabIndex = 0;
            this.tile.Text = "tileControl1";
            // 
            // Grupo1
            // 
            this.Grupo1.Items.Add(this.item_negocios);
            this.Grupo1.Items.Add(this.item_contacto);
            this.Grupo1.Items.Add(this.item_calendario);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Text = "grupo1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Items.Add(this.tileItem2);
            this.tileGroup2.Items.Add(this.tileItem6);
            this.tileGroup2.Items.Add(this.tileItem7);
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileItem2
            // 
            tileItemElement4.Text = "tileItem2";
            this.tileItem2.Elements.Add(tileItemElement4);
            this.tileItem2.Id = 9;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Items.Add(this.tileItem8);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileItem3
            // 
            tileItemElement7.Text = "tileItem3";
            this.tileItem3.Elements.Add(tileItemElement7);
            this.tileItem3.Id = 10;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem3.Name = "tileItem3";
            // 
            // item_negocios
            // 
            this.item_negocios.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter;
            this.item_negocios.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "tileItem1";
            this.item_negocios.Elements.Add(tileItemElement1);
            this.item_negocios.Id = 14;
            this.item_negocios.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_negocios.Name = "item_negocios";
            // 
            // item_contacto
            // 
            tileItemElement2.Text = "tileItem4";
            this.item_contacto.Elements.Add(tileItemElement2);
            this.item_contacto.Id = 15;
            this.item_contacto.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_contacto.Name = "item_contacto";
            // 
            // item_calendario
            // 
            tileItemElement3.Text = "tileItem5";
            this.item_calendario.Elements.Add(tileItemElement3);
            this.item_calendario.Id = 16;
            this.item_calendario.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_calendario.Name = "item_calendario";
            // 
            // tileItem6
            // 
            tileItemElement5.Text = "tileItem6";
            this.tileItem6.Elements.Add(tileItemElement5);
            this.tileItem6.Id = 17;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem7
            // 
            tileItemElement6.Text = "tileItem7";
            this.tileItem7.Elements.Add(tileItemElement6);
            this.tileItem7.Id = 18;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileItem8
            // 
            tileItemElement8.Text = "tileItem8";
            this.tileItem8.Elements.Add(tileItemElement8);
            this.tileItem8.Id = 19;
            this.tileItem8.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem8.Name = "tileItem8";
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 448);
            this.Controls.Add(this.tile);
            this.Name = "Form_inicio";
            this.Text = "Form_inicio";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tile;
        private DevExpress.XtraEditors.TileGroup Grupo1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private DevExpress.XtraEditors.TileItem item_negocios;
        private DevExpress.XtraEditors.TileItem item_contacto;
        private DevExpress.XtraEditors.TileItem item_calendario;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem8;
    }
}