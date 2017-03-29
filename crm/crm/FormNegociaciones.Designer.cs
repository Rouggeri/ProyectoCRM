namespace crm
{
    partial class FormNegociaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNegociaciones));
            this.dgv_negocios = new DevExpress.XtraGrid.GridControl();
            this.dgv_neg = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.navigationPane1 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.pag_lista = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.pag_estado = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.label2 = new System.Windows.Forms.Label();
            this.tileGroup1 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup2 = new DevExpress.XtraEditors.TileGroup();
            this.tileGroup3 = new DevExpress.XtraEditors.TileGroup();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_ultimo = new System.Windows.Forms.Button();
            this.btn_actualizar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.btn_primero = new System.Windows.Forms.Button();
            this.btn_anterior = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_eliminar = new System.Windows.Forms.Button();
            this.btn_siguiente = new System.Windows.Forms.Button();
            this.tileBar0 = new DevExpress.XtraBars.Navigation.TileBar();
            this.grupo_preparacion = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.tileBar1 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBar2 = new DevExpress.XtraBars.Navigation.TileBar();
            this.tileBar3 = new DevExpress.XtraBars.Navigation.TileBar();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_negocios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_neg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).BeginInit();
            this.navigationPane1.SuspendLayout();
            this.pag_lista.SuspendLayout();
            this.pag_estado.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grupo_preparacion)).BeginInit();
            this.grupo_preparacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_negocios
            // 
            this.dgv_negocios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_negocios.Location = new System.Drawing.Point(0, 0);
            this.dgv_negocios.MainView = this.dgv_neg;
            this.dgv_negocios.Name = "dgv_negocios";
            this.dgv_negocios.Size = new System.Drawing.Size(947, 427);
            this.dgv_negocios.TabIndex = 0;
            this.dgv_negocios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgv_neg});
            this.dgv_negocios.DoubleClick += new System.EventHandler(this.dgv_negocios_DoubleClick);
            // 
            // dgv_neg
            // 
            this.dgv_neg.GridControl = this.dgv_negocios;
            this.dgv_neg.Name = "dgv_neg";
            this.dgv_neg.OptionsView.ShowFooter = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(783, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(158, 20);
            this.textBox1.TabIndex = 2;
            // 
            // navigationPane1
            // 
            this.navigationPane1.Controls.Add(this.pag_lista);
            this.navigationPane1.Controls.Add(this.pag_estado);
            this.navigationPane1.Location = new System.Drawing.Point(1, 99);
            this.navigationPane1.Name = "navigationPane1";
            this.navigationPane1.PageProperties.ShowMode = DevExpress.XtraBars.Navigation.ItemShowMode.Image;
            this.navigationPane1.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.pag_lista,
            this.pag_estado});
            this.navigationPane1.RegularSize = new System.Drawing.Size(1013, 487);
            this.navigationPane1.SelectedPage = this.pag_estado;
            this.navigationPane1.SelectedPageIndex = 1;
            this.navigationPane1.Size = new System.Drawing.Size(1013, 487);
            this.navigationPane1.TabIndex = 4;
            this.navigationPane1.Text = "Negociaciones";
            // 
            // pag_lista
            // 
            this.pag_lista.Caption = "Lista";
            this.pag_lista.Controls.Add(this.dgv_negocios);
            this.pag_lista.Image = ((System.Drawing.Image)(resources.GetObject("pag_lista.Image")));
            this.pag_lista.Name = "pag_lista";
            this.pag_lista.PageText = "";
            this.pag_lista.Size = new System.Drawing.Size(947, 427);
            // 
            // pag_estado
            // 
            this.pag_estado.Caption = "Estado";
            this.pag_estado.Controls.Add(this.groupControl5);
            this.pag_estado.Controls.Add(this.groupControl3);
            this.pag_estado.Controls.Add(this.groupControl2);
            this.pag_estado.Controls.Add(this.grupo_preparacion);
            this.pag_estado.Image = ((System.Drawing.Image)(resources.GetObject("pag_estado.Image")));
            this.pag_estado.Name = "pag_estado";
            this.pag_estado.Size = new System.Drawing.Size(947, 427);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(737, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar";
            // 
            // tileGroup1
            // 
            this.tileGroup1.Name = "tileGroup1";
            // 
            // tileGroup2
            // 
            this.tileGroup2.Name = "tileGroup2";
            // 
            // tileGroup3
            // 
            this.tileGroup3.Name = "tileGroup3";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btn_nuevo);
            this.panel2.Controls.Add(this.btn_cancelar);
            this.panel2.Controls.Add(this.btn_ultimo);
            this.panel2.Controls.Add(this.btn_actualizar);
            this.panel2.Controls.Add(this.btn_guardar);
            this.panel2.Controls.Add(this.btn_buscar);
            this.panel2.Controls.Add(this.btn_primero);
            this.panel2.Controls.Add(this.btn_anterior);
            this.panel2.Controls.Add(this.btn_editar);
            this.panel2.Controls.Add(this.btn_eliminar);
            this.panel2.Controls.Add(this.btn_siguiente);
            this.panel2.Location = new System.Drawing.Point(86, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(630, 77);
            this.panel2.TabIndex = 188;
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::crm.Properties.Resources.imprimir1;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(541, 4);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 59);
            this.button2.TabIndex = 182;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.BackgroundImage")));
            this.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_nuevo.FlatAppearance.BorderSize = 0;
            this.btn_nuevo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nuevo.Location = new System.Drawing.Point(29, 4);
            this.btn_nuevo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(58, 59);
            this.btn_nuevo.TabIndex = 4;
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click_1);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.BackgroundImage")));
            this.btn_cancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cancelar.FlatAppearance.BorderSize = 0;
            this.btn_cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cancelar.Location = new System.Drawing.Point(334, 4);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(56, 59);
            this.btn_cancelar.TabIndex = 176;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_ultimo
            // 
            this.btn_ultimo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_ultimo.BackgroundImage")));
            this.btn_ultimo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_ultimo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ultimo.FlatAppearance.BorderSize = 0;
            this.btn_ultimo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ultimo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_ultimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ultimo.Location = new System.Drawing.Point(503, 37);
            this.btn_ultimo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ultimo.Name = "btn_ultimo";
            this.btn_ultimo.Size = new System.Drawing.Size(30, 26);
            this.btn_ultimo.TabIndex = 181;
            this.btn_ultimo.UseVisualStyleBackColor = true;
            // 
            // btn_actualizar
            // 
            this.btn_actualizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_actualizar.BackgroundImage")));
            this.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_actualizar.FlatAppearance.BorderSize = 0;
            this.btn_actualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_actualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_actualizar.Location = new System.Drawing.Point(391, 4);
            this.btn_actualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_actualizar.Name = "btn_actualizar";
            this.btn_actualizar.Size = new System.Drawing.Size(56, 59);
            this.btn_actualizar.TabIndex = 177;
            this.btn_actualizar.UseVisualStyleBackColor = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_guardar.BackgroundImage")));
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Location = new System.Drawing.Point(95, 3);
            this.btn_guardar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(58, 59);
            this.btn_guardar.TabIndex = 3;
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // btn_buscar
            // 
            this.btn_buscar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscar.BackgroundImage")));
            this.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscar.FlatAppearance.BorderSize = 0;
            this.btn_buscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_buscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_buscar.Location = new System.Drawing.Point(275, 4);
            this.btn_buscar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(58, 59);
            this.btn_buscar.TabIndex = 175;
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // btn_primero
            // 
            this.btn_primero.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_primero.BackgroundImage")));
            this.btn_primero.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_primero.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_primero.FlatAppearance.BorderSize = 0;
            this.btn_primero.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_primero.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_primero.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_primero.Location = new System.Drawing.Point(465, 37);
            this.btn_primero.Margin = new System.Windows.Forms.Padding(4);
            this.btn_primero.Name = "btn_primero";
            this.btn_primero.Size = new System.Drawing.Size(30, 26);
            this.btn_primero.TabIndex = 180;
            this.btn_primero.UseVisualStyleBackColor = true;
            // 
            // btn_anterior
            // 
            this.btn_anterior.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_anterior.BackgroundImage")));
            this.btn_anterior.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_anterior.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_anterior.FlatAppearance.BorderSize = 0;
            this.btn_anterior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_anterior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_anterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_anterior.Location = new System.Drawing.Point(465, 4);
            this.btn_anterior.Margin = new System.Windows.Forms.Padding(4);
            this.btn_anterior.Name = "btn_anterior";
            this.btn_anterior.Size = new System.Drawing.Size(30, 26);
            this.btn_anterior.TabIndex = 178;
            this.btn_anterior.UseVisualStyleBackColor = true;
            // 
            // btn_editar
            // 
            this.btn_editar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_editar.BackgroundImage")));
            this.btn_editar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_editar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_editar.FlatAppearance.BorderSize = 0;
            this.btn_editar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_editar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_editar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_editar.Location = new System.Drawing.Point(157, 4);
            this.btn_editar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(58, 59);
            this.btn_editar.TabIndex = 5;
            this.btn_editar.UseVisualStyleBackColor = true;
            // 
            // btn_eliminar
            // 
            this.btn_eliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.BackgroundImage")));
            this.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_eliminar.FlatAppearance.BorderSize = 0;
            this.btn_eliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eliminar.Location = new System.Drawing.Point(216, 4);
            this.btn_eliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(58, 59);
            this.btn_eliminar.TabIndex = 6;
            this.btn_eliminar.UseVisualStyleBackColor = true;
            // 
            // btn_siguiente
            // 
            this.btn_siguiente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_siguiente.BackgroundImage")));
            this.btn_siguiente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_siguiente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_siguiente.FlatAppearance.BorderSize = 0;
            this.btn_siguiente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_siguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btn_siguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_siguiente.Location = new System.Drawing.Point(503, 3);
            this.btn_siguiente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_siguiente.Name = "btn_siguiente";
            this.btn_siguiente.Size = new System.Drawing.Size(30, 26);
            this.btn_siguiente.TabIndex = 179;
            this.btn_siguiente.UseVisualStyleBackColor = true;
            // 
            // tileBar0
            // 
            this.tileBar0.AllowDrag = false;
            this.tileBar0.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar0.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar0.AppearanceText.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.tileBar0.AppearanceText.Options.UseFont = true;
            this.tileBar0.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar0.ItemSize = 80;
            this.tileBar0.Location = new System.Drawing.Point(5, 37);
            this.tileBar0.MaxId = 3;
            this.tileBar0.Name = "tileBar0";
            this.tileBar0.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar0.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar0.Size = new System.Drawing.Size(220, 379);
            this.tileBar0.TabIndex = 0;
            this.tileBar0.Text = "tileBar0";
            // 
            // grupo_preparacion
            // 
            this.grupo_preparacion.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grupo_preparacion.AppearanceCaption.Options.UseFont = true;
            this.grupo_preparacion.CaptionImage = ((System.Drawing.Image)(resources.GetObject("grupo_preparacion.CaptionImage")));
            this.grupo_preparacion.Controls.Add(this.tileBar0);
            this.grupo_preparacion.Location = new System.Drawing.Point(3, 3);
            this.grupo_preparacion.Name = "grupo_preparacion";
            this.grupo_preparacion.Size = new System.Drawing.Size(230, 421);
            this.grupo_preparacion.TabIndex = 1;
            this.grupo_preparacion.Text = "Preparación o análisis";
            // 
            // groupControl2
            // 
            this.groupControl2.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl2.AppearanceCaption.Options.UseFont = true;
            this.groupControl2.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl2.CaptionImage")));
            this.groupControl2.Controls.Add(this.tileBar1);
            this.groupControl2.Location = new System.Drawing.Point(239, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(230, 421);
            this.groupControl2.TabIndex = 2;
            this.groupControl2.Text = "Discusión";
            // 
            // groupControl3
            // 
            this.groupControl3.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl3.AppearanceCaption.Options.UseFont = true;
            this.groupControl3.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl3.CaptionImage")));
            this.groupControl3.Controls.Add(this.tileBar2);
            this.groupControl3.Controls.Add(this.groupControl4);
            this.groupControl3.Location = new System.Drawing.Point(475, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(230, 421);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "Propuesta realizada";
            // 
            // groupControl4
            // 
            this.groupControl4.Location = new System.Drawing.Point(236, 0);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(230, 239);
            this.groupControl4.TabIndex = 4;
            this.groupControl4.Text = "groupControl4";
            // 
            // groupControl5
            // 
            this.groupControl5.AppearanceCaption.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl5.AppearanceCaption.Options.UseFont = true;
            this.groupControl5.CaptionImage = ((System.Drawing.Image)(resources.GetObject("groupControl5.CaptionImage")));
            this.groupControl5.Controls.Add(this.tileBar3);
            this.groupControl5.Controls.Add(this.groupControl6);
            this.groupControl5.Location = new System.Drawing.Point(711, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(230, 421);
            this.groupControl5.TabIndex = 5;
            this.groupControl5.Text = "Cierre y acuerdo";
            // 
            // groupControl6
            // 
            this.groupControl6.Location = new System.Drawing.Point(236, 0);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(230, 239);
            this.groupControl6.TabIndex = 4;
            this.groupControl6.Text = "groupControl6";
            // 
            // tileBar1
            // 
            this.tileBar1.AllowDrag = false;
            this.tileBar1.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar1.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar1.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar1.ItemSize = 80;
            this.tileBar1.Location = new System.Drawing.Point(5, 37);
            this.tileBar1.Name = "tileBar1";
            this.tileBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar1.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar1.Size = new System.Drawing.Size(220, 379);
            this.tileBar1.TabIndex = 1;
            this.tileBar1.Text = "tileBar2";
            // 
            // tileBar2
            // 
            this.tileBar2.AllowDrag = false;
            this.tileBar2.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar2.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar2.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar2.ItemSize = 80;
            this.tileBar2.Location = new System.Drawing.Point(5, 37);
            this.tileBar2.Name = "tileBar2";
            this.tileBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar2.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar2.Size = new System.Drawing.Size(220, 379);
            this.tileBar2.TabIndex = 2;
            this.tileBar2.Text = "tileBar3";
            // 
            // tileBar3
            // 
            this.tileBar3.AllowDrag = false;
            this.tileBar3.AppearanceItem.Normal.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileBar3.AppearanceItem.Normal.Options.UseFont = true;
            this.tileBar3.DropDownOptions.BeakColor = System.Drawing.Color.Empty;
            this.tileBar3.ItemSize = 80;
            this.tileBar3.Location = new System.Drawing.Point(5, 37);
            this.tileBar3.Name = "tileBar3";
            this.tileBar3.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.tileBar3.ScrollMode = DevExpress.XtraEditors.TileControlScrollMode.ScrollButtons;
            this.tileBar3.Size = new System.Drawing.Size(220, 379);
            this.tileBar3.TabIndex = 5;
            this.tileBar3.Text = "tileBar4";
            // 
            // FormNegociaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 591);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navigationPane1);
            this.Controls.Add(this.textBox1);
            this.Name = "FormNegociaciones";
            this.Text = "Negocios";
            this.Load += new System.EventHandler(this.FormNegociaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_negocios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_neg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navigationPane1)).EndInit();
            this.navigationPane1.ResumeLayout(false);
            this.pag_lista.ResumeLayout(false);
            this.pag_estado.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grupo_preparacion)).EndInit();
            this.grupo_preparacion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgv_negocios;
        private DevExpress.XtraGrid.Views.Grid.GridView dgv_neg;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraBars.Navigation.NavigationPane navigationPane1;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_lista;
        private DevExpress.XtraBars.Navigation.NavigationPage pag_estado;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.TileGroup tileGroup1;
        private DevExpress.XtraEditors.TileGroup tileGroup2;
        private DevExpress.XtraEditors.TileGroup tileGroup3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_ultimo;
        private System.Windows.Forms.Button btn_actualizar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_primero;
        private System.Windows.Forms.Button btn_anterior;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_eliminar;
        private System.Windows.Forms.Button btn_siguiente;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl grupo_preparacion;
        private DevExpress.XtraBars.Navigation.TileBar tileBar0;
        private DevExpress.XtraBars.Navigation.TileBar tileBar3;
        private DevExpress.XtraBars.Navigation.TileBar tileBar2;
        private DevExpress.XtraBars.Navigation.TileBar tileBar1;
    }
}