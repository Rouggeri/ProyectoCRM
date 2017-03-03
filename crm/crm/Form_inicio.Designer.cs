﻿namespace crm
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
            DevExpress.XtraEditors.TileItemElement tileItemElement1 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement2 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement3 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement4 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement5 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement6 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement7 = new DevExpress.XtraEditors.TileItemElement();
            DevExpress.XtraEditors.TileItemElement tileItemElement8 = new DevExpress.XtraEditors.TileItemElement();
            this.tile = new DevExpress.XtraEditors.TileControl();
            this.Grupo1 = new DevExpress.XtraEditors.TileGroup();
            this.item_negocios = new DevExpress.XtraEditors.TileItem();
            this.item_contactos = new DevExpress.XtraEditors.TileItem();
            this.item_calendario = new DevExpress.XtraEditors.TileItem();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem2 = new DevExpress.XtraEditors.TileItem();
            this.tileItem6 = new DevExpress.XtraEditors.TileItem();
            this.tileItem7 = new DevExpress.XtraEditors.TileItem();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.tileItem1 = new DevExpress.XtraEditors.TileItem();
            this.tileItem3 = new DevExpress.XtraEditors.TileItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
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
            this.tile.MaxId = 22;
            this.tile.Name = "tile";
            this.tile.SelectionColor = System.Drawing.Color.LightSkyBlue;
            this.tile.Size = new System.Drawing.Size(1033, 534);
            this.tile.TabIndex = 0;
            this.tile.Text = "tileControl1";
            // 
            // Grupo1
            // 
            this.Grupo1.Items.Add(this.item_negocios);
            this.Grupo1.Items.Add(this.item_contactos);
            this.Grupo1.Items.Add(this.item_calendario);
            this.Grupo1.Name = "Grupo1";
            this.Grupo1.Text = "grupo1";
            // 
            // item_negocios
            // 
            this.item_negocios.AppearanceItem.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.item_negocios.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.item_negocios.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.item_negocios.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.item_negocios.AppearanceItem.Normal.BackColor = System.Drawing.Color.Teal;
            this.item_negocios.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Teal;
            this.item_negocios.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_negocios.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_negocios.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_negocios.AppearanceItem.Normal.Options.UseFont = true;
            this.item_negocios.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_negocios.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement1.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement1.Text = "Negocios";
            this.item_negocios.Elements.Add(tileItemElement1);
            this.item_negocios.Id = 14;
            this.item_negocios.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.item_negocios.Name = "item_negocios";
            // 
            // item_contactos
            // 
            this.item_contactos.AppearanceItem.Normal.BackColor = System.Drawing.Color.Yellow;
            this.item_contactos.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Yellow;
            this.item_contactos.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_contactos.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_contactos.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_contactos.AppearanceItem.Normal.Options.UseFont = true;
            this.item_contactos.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter;
            this.item_contactos.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement2.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement2.Text = "Contactos";
            this.item_contactos.Elements.Add(tileItemElement2);
            this.item_contactos.Id = 15;
            this.item_contactos.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_contactos.Name = "item_contactos";
            // 
            // item_calendario
            // 
            this.item_calendario.AppearanceItem.Normal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.item_calendario.AppearanceItem.Normal.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.item_calendario.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.item_calendario.AppearanceItem.Normal.Options.UseBackColor = true;
            this.item_calendario.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.item_calendario.AppearanceItem.Normal.Options.UseFont = true;
            this.item_calendario.BackgroundImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleRight;
            this.item_calendario.BackgroundImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside;
            tileItemElement3.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Stretch;
            tileItemElement3.ImageToTextAlignment = DevExpress.XtraEditors.TileControlImageToTextAlignment.Top;
            tileItemElement3.Text = "Calendario";
            this.item_calendario.Elements.Add(tileItemElement3);
            this.item_calendario.Id = 16;
            this.item_calendario.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.item_calendario.Name = "item_calendario";
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
            this.tileItem2.AppearanceItem.Normal.BackColor = System.Drawing.Color.DarkOrchid;
            this.tileItem2.AppearanceItem.Normal.BorderColor = System.Drawing.Color.DarkOrchid;
            this.tileItem2.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.tileItem2.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem2.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement4.Text = "Clientes";
            this.tileItem2.Elements.Add(tileItemElement4);
            this.tileItem2.Id = 9;
            this.tileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem2.Name = "tileItem2";
            // 
            // tileItem6
            // 
            this.tileItem6.AppearanceItem.Hovered.BackColor = System.Drawing.Color.Red;
            this.tileItem6.AppearanceItem.Hovered.BorderColor = System.Drawing.Color.Red;
            this.tileItem6.AppearanceItem.Hovered.Options.UseBackColor = true;
            this.tileItem6.AppearanceItem.Hovered.Options.UseBorderColor = true;
            this.tileItem6.AppearanceItem.Normal.BackColor = System.Drawing.Color.Gray;
            this.tileItem6.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Gray;
            this.tileItem6.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.tileItem6.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem6.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem6.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement5.Text = "Personal";
            this.tileItem6.Elements.Add(tileItemElement5);
            this.tileItem6.Id = 17;
            this.tileItem6.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem6.Name = "tileItem6";
            // 
            // tileItem7
            // 
            this.tileItem7.AppearanceItem.Normal.BackColor = System.Drawing.Color.OrangeRed;
            this.tileItem7.AppearanceItem.Normal.BorderColor = System.Drawing.Color.OrangeRed;
            this.tileItem7.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.tileItem7.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem7.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem7.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement6.Text = "Pronosticos";
            this.tileItem7.Elements.Add(tileItemElement6);
            this.tileItem7.Id = 18;
            this.tileItem7.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium;
            this.tileItem7.Name = "tileItem7";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Items.Add(this.tileItem1);
            this.tileGroup3.Items.Add(this.tileItem3);
            this.tileGroup3.Name = "tileGroup3";
            // 
            // tileItem1
            // 
            this.tileItem1.AppearanceItem.Normal.BackColor = System.Drawing.Color.Red;
            this.tileItem1.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Red;
            this.tileItem1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.tileItem1.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem1.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement7.Text = "Productos";
            this.tileItem1.Elements.Add(tileItemElement7);
            this.tileItem1.Id = 20;
            this.tileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem1.Name = "tileItem1";
            // 
            // tileItem3
            // 
            this.tileItem3.AppearanceItem.Normal.BackColor = System.Drawing.Color.Green;
            this.tileItem3.AppearanceItem.Normal.BorderColor = System.Drawing.Color.Green;
            this.tileItem3.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 10.5F, System.Drawing.FontStyle.Bold);
            this.tileItem3.AppearanceItem.Normal.Options.UseBackColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseBorderColor = true;
            this.tileItem3.AppearanceItem.Normal.Options.UseFont = true;
            tileItemElement8.Text = "Ventas";
            this.tileItem3.Elements.Add(tileItemElement8);
            this.tileItem3.Id = 21;
            this.tileItem3.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide;
            this.tileItem3.Name = "tileItem3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(155, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "CRM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(449, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estadisticas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(801, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Otros";
            // 
            // Form_inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tile);
            this.Name = "Form_inicio";
            this.Text = "Form_inicio";
            this.Load += new System.EventHandler(this.Form_inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TileControl tile;
        private DevExpress.XtraEditors.TileGroup Grupo1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileItem tileItem2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private DevExpress.XtraEditors.TileItem item_negocios;
        private DevExpress.XtraEditors.TileItem item_contactos;
        private DevExpress.XtraEditors.TileItem item_calendario;
        private DevExpress.XtraEditors.TileItem tileItem6;
        private DevExpress.XtraEditors.TileItem tileItem7;
        private DevExpress.XtraEditors.TileItem tileItem1;
        private DevExpress.XtraEditors.TileItem tileItem3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}