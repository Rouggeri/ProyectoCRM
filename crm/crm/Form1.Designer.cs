namespace crm
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dfToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.negocios = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promocionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cobrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.encuestasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.proyeccionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.dfToolStripMenuItem,
            this.otroToolStripMenuItem,
            this.cobrosToolStripMenuItem,
            this.estadisticasToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.mantenimientosToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(48, 20);
            this.toolStripMenuItem1.Text = "Inicio";
            // 
            // dfToolStripMenuItem
            // 
            this.dfToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.negocios,
            this.actividadesToolStripMenuItem,
            this.contactoToolStripMenuItem});
            this.dfToolStripMenuItem.Name = "dfToolStripMenuItem";
            this.dfToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.dfToolStripMenuItem.Text = "CRM";
            // 
            // negocios
            // 
            this.negocios.Name = "negocios";
            this.negocios.Size = new System.Drawing.Size(202, 22);
            this.negocios.Text = "Negociaciones";
            this.negocios.Click += new System.EventHandler(this.gToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.actividadesToolStripMenuItem.Text = "Actividades y calendario";
            this.actividadesToolStripMenuItem.Click += new System.EventHandler(this.actividadesToolStripMenuItem_Click);
            // 
            // contactoToolStripMenuItem
            // 
            this.contactoToolStripMenuItem.Name = "contactoToolStripMenuItem";
            this.contactoToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.contactoToolStripMenuItem.Text = "Contactos";
            this.contactoToolStripMenuItem.Click += new System.EventHandler(this.contactoToolStripMenuItem_Click);
            // 
            // otroToolStripMenuItem
            // 
            this.otroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.promocionesToolStripMenuItem});
            this.otroToolStripMenuItem.Name = "otroToolStripMenuItem";
            this.otroToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.otroToolStripMenuItem.Text = "Ventas";
            this.otroToolStripMenuItem.Click += new System.EventHandler(this.otroToolStripMenuItem_Click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.dToolStripMenuItem.Text = "d";
            // 
            // promocionesToolStripMenuItem
            // 
            this.promocionesToolStripMenuItem.Name = "promocionesToolStripMenuItem";
            this.promocionesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.promocionesToolStripMenuItem.Text = "Promociones";
            // 
            // cobrosToolStripMenuItem
            // 
            this.cobrosToolStripMenuItem.Name = "cobrosToolStripMenuItem";
            this.cobrosToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.cobrosToolStripMenuItem.Text = "Cobros";
            // 
            // estadisticasToolStripMenuItem
            // 
            this.estadisticasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalToolStripMenuItem,
            this.personalToolStripMenuItem1,
            this.encuestasToolStripMenuItem1,
            this.proyeccionesToolStripMenuItem});
            this.estadisticasToolStripMenuItem.Name = "estadisticasToolStripMenuItem";
            this.estadisticasToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.estadisticasToolStripMenuItem.Text = "Estadisticas";
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.personalToolStripMenuItem.Text = "Clientes";
            this.personalToolStripMenuItem.Click += new System.EventHandler(this.personalToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem1
            // 
            this.personalToolStripMenuItem1.Name = "personalToolStripMenuItem1";
            this.personalToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.personalToolStripMenuItem1.Text = "Personal";
            this.personalToolStripMenuItem1.Click += new System.EventHandler(this.personalToolStripMenuItem1_Click);
            // 
            // encuestasToolStripMenuItem1
            // 
            this.encuestasToolStripMenuItem1.Name = "encuestasToolStripMenuItem1";
            this.encuestasToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
            this.encuestasToolStripMenuItem1.Text = "Encuestas";
            // 
            // proyeccionesToolStripMenuItem
            // 
            this.proyeccionesToolStripMenuItem.Name = "proyeccionesToolStripMenuItem";
            this.proyeccionesToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.proyeccionesToolStripMenuItem.Text = "Proyecciones";
            this.proyeccionesToolStripMenuItem.Click += new System.EventHandler(this.proyeccionesToolStripMenuItem_Click);
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.productosToolStripMenuItem.Text = "Productos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fToolStripMenuItem,
            this.gToolStripMenuItem1,
            this.sToolStripMenuItem});
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // fToolStripMenuItem
            // 
            this.fToolStripMenuItem.Name = "fToolStripMenuItem";
            this.fToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.fToolStripMenuItem.Text = "Gestión de seguridad";
            // 
            // gToolStripMenuItem1
            // 
            this.gToolStripMenuItem1.Name = "gToolStripMenuItem1";
            this.gToolStripMenuItem1.Size = new System.Drawing.Size(185, 22);
            this.gToolStripMenuItem1.Text = "Cambiar contraseña";
            // 
            // sToolStripMenuItem
            // 
            this.sToolStripMenuItem.Name = "sToolStripMenuItem";
            this.sToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.sToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 591);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dfToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem negocios;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cobrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promocionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem encuestasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem proyeccionesToolStripMenuItem;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
    }
}

