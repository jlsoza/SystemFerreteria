namespace Ferreteria.MenuPrincipal
{
    partial class Menu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.Contenedor = new System.Windows.Forms.Panel();
            this.FormPanel = new System.Windows.Forms.Panel();
            this.PiedePagina = new System.Windows.Forms.Panel();
            this.menup = new System.Windows.Forms.Panel();
            this.VentasPanel = new System.Windows.Forms.Panel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Btnventas = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Compras = new System.Windows.Forms.Panel();
            this.btndetalleIngreso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnIngreso = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnCompras = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelSubmenuC = new System.Windows.Forms.Panel();
            this.btnUsuarios = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEmpleados = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnProducto = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btncatalogo = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Titulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.DeslizarArchivos = new System.Windows.Forms.Timer(this.components);
            this.DeslizarComponentes = new System.Windows.Forms.Timer(this.components);
            this.DeslizarMovimientos = new System.Windows.Forms.Timer(this.components);
            this.MinArc = new System.Windows.Forms.Timer(this.components);
            this.MinCom = new System.Windows.Forms.Timer(this.components);
            this.MinMov = new System.Windows.Forms.Timer(this.components);
            this.Control = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.btnclientes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelGraficos = new System.Windows.Forms.Panel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btncategorias = new Bunifu.Framework.UI.BunifuFlatButton();
            this.Contenedor.SuspendLayout();
            this.PiedePagina.SuspendLayout();
            this.menup.SuspendLayout();
            this.VentasPanel.SuspendLayout();
            this.Compras.SuspendLayout();
            this.panelSubmenuC.SuspendLayout();
            this.Titulo.SuspendLayout();
            this.panelGraficos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Contenedor.Controls.Add(this.FormPanel);
            this.Contenedor.Controls.Add(this.PiedePagina);
            this.Contenedor.Controls.Add(this.menup);
            this.Contenedor.Controls.Add(this.Titulo);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1132, 676);
            this.Contenedor.TabIndex = 0;
            // 
            // FormPanel
            // 
            this.FormPanel.Location = new System.Drawing.Point(230, 43);
            this.FormPanel.Name = "FormPanel";
            this.FormPanel.Size = new System.Drawing.Size(899, 576);
            this.FormPanel.TabIndex = 3;
            // 
            // PiedePagina
            // 
            this.PiedePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.PiedePagina.Controls.Add(this.lbFecha);
            this.PiedePagina.Controls.Add(this.lblHora);
            this.PiedePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PiedePagina.Location = new System.Drawing.Point(230, 609);
            this.PiedePagina.Name = "PiedePagina";
            this.PiedePagina.Size = new System.Drawing.Size(902, 67);
            this.PiedePagina.TabIndex = 2;
            // 
            // menup
            // 
            this.menup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.menup.Controls.Add(this.panelGraficos);
            this.menup.Controls.Add(this.VentasPanel);
            this.menup.Controls.Add(this.Compras);
            this.menup.Controls.Add(this.panelSubmenuC);
            this.menup.Dock = System.Windows.Forms.DockStyle.Left;
            this.menup.Location = new System.Drawing.Point(0, 43);
            this.menup.Name = "menup";
            this.menup.Size = new System.Drawing.Size(230, 633);
            this.menup.TabIndex = 1;
            // 
            // VentasPanel
            // 
            this.VentasPanel.BackColor = System.Drawing.Color.Transparent;
            this.VentasPanel.Controls.Add(this.bunifuFlatButton1);
            this.VentasPanel.Controls.Add(this.bunifuFlatButton2);
            this.VentasPanel.Controls.Add(this.panel4);
            this.VentasPanel.Controls.Add(this.Btnventas);
            this.VentasPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.VentasPanel.Location = new System.Drawing.Point(0, 440);
            this.VentasPanel.MaximumSize = new System.Drawing.Size(229, 150);
            this.VentasPanel.MinimumSize = new System.Drawing.Size(229, 48);
            this.VentasPanel.Name = "VentasPanel";
            this.VentasPanel.Size = new System.Drawing.Size(229, 150);
            this.VentasPanel.TabIndex = 14;
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 7;
            this.bunifuFlatButton1.ButtonText = "  Detalle Ventas";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 60D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(22, 96);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(207, 48);
            this.bunifuFlatButton1.TabIndex = 17;
            this.bunifuFlatButton1.Text = "  Detalle Ventas";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 7;
            this.bunifuFlatButton2.ButtonText = "  Ingreso";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 60D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(22, 48);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(207, 48);
            this.bunifuFlatButton2.TabIndex = 16;
            this.bunifuFlatButton2.Text = "  Ingreso";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 48);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(22, 102);
            this.panel4.TabIndex = 15;
            // 
            // Btnventas
            // 
            this.Btnventas.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.Btnventas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btnventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Btnventas.BorderRadius = 7;
            this.Btnventas.ButtonText = "        Ventas";
            this.Btnventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btnventas.DisabledColor = System.Drawing.Color.Gray;
            this.Btnventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Btnventas.Iconcolor = System.Drawing.Color.Transparent;
            this.Btnventas.Iconimage = ((System.Drawing.Image)(resources.GetObject("Btnventas.Iconimage")));
            this.Btnventas.Iconimage_right = null;
            this.Btnventas.Iconimage_right_Selected = null;
            this.Btnventas.Iconimage_Selected = null;
            this.Btnventas.IconMarginLeft = 0;
            this.Btnventas.IconMarginRight = 0;
            this.Btnventas.IconRightVisible = true;
            this.Btnventas.IconRightZoom = 0D;
            this.Btnventas.IconVisible = true;
            this.Btnventas.IconZoom = 90D;
            this.Btnventas.IsTab = false;
            this.Btnventas.Location = new System.Drawing.Point(0, 0);
            this.Btnventas.Name = "Btnventas";
            this.Btnventas.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.Btnventas.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.Btnventas.OnHoverTextColor = System.Drawing.Color.White;
            this.Btnventas.selected = false;
            this.Btnventas.Size = new System.Drawing.Size(229, 48);
            this.Btnventas.TabIndex = 1;
            this.Btnventas.Text = "        Ventas";
            this.Btnventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btnventas.Textcolor = System.Drawing.Color.White;
            this.Btnventas.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btnventas.Click += new System.EventHandler(this.Btnventas_Click);
            // 
            // Compras
            // 
            this.Compras.BackColor = System.Drawing.Color.Transparent;
            this.Compras.Controls.Add(this.btndetalleIngreso);
            this.Compras.Controls.Add(this.btnIngreso);
            this.Compras.Controls.Add(this.panel1);
            this.Compras.Controls.Add(this.BtnCompras);
            this.Compras.Dock = System.Windows.Forms.DockStyle.Top;
            this.Compras.Location = new System.Drawing.Point(0, 290);
            this.Compras.MaximumSize = new System.Drawing.Size(229, 150);
            this.Compras.MinimumSize = new System.Drawing.Size(229, 48);
            this.Compras.Name = "Compras";
            this.Compras.Size = new System.Drawing.Size(229, 150);
            this.Compras.TabIndex = 13;
            // 
            // btndetalleIngreso
            // 
            this.btndetalleIngreso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btndetalleIngreso.BackColor = System.Drawing.Color.Transparent;
            this.btndetalleIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndetalleIngreso.BorderRadius = 7;
            this.btndetalleIngreso.ButtonText = "  Detalle Ingreso";
            this.btndetalleIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btndetalleIngreso.DisabledColor = System.Drawing.Color.Gray;
            this.btndetalleIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btndetalleIngreso.Iconcolor = System.Drawing.Color.Transparent;
            this.btndetalleIngreso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btndetalleIngreso.Iconimage")));
            this.btndetalleIngreso.Iconimage_right = null;
            this.btndetalleIngreso.Iconimage_right_Selected = null;
            this.btndetalleIngreso.Iconimage_Selected = null;
            this.btndetalleIngreso.IconMarginLeft = 0;
            this.btndetalleIngreso.IconMarginRight = 0;
            this.btndetalleIngreso.IconRightVisible = true;
            this.btndetalleIngreso.IconRightZoom = 0D;
            this.btndetalleIngreso.IconVisible = true;
            this.btndetalleIngreso.IconZoom = 60D;
            this.btndetalleIngreso.IsTab = false;
            this.btndetalleIngreso.Location = new System.Drawing.Point(22, 96);
            this.btndetalleIngreso.Name = "btndetalleIngreso";
            this.btndetalleIngreso.Normalcolor = System.Drawing.Color.Transparent;
            this.btndetalleIngreso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btndetalleIngreso.OnHoverTextColor = System.Drawing.Color.White;
            this.btndetalleIngreso.selected = false;
            this.btndetalleIngreso.Size = new System.Drawing.Size(207, 48);
            this.btndetalleIngreso.TabIndex = 17;
            this.btndetalleIngreso.Text = "  Detalle Ingreso";
            this.btndetalleIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndetalleIngreso.Textcolor = System.Drawing.Color.White;
            this.btndetalleIngreso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnIngreso
            // 
            this.btnIngreso.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btnIngreso.BackColor = System.Drawing.Color.Transparent;
            this.btnIngreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngreso.BorderRadius = 7;
            this.btnIngreso.ButtonText = "  Ingreso Almacen";
            this.btnIngreso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngreso.DisabledColor = System.Drawing.Color.Gray;
            this.btnIngreso.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngreso.Iconcolor = System.Drawing.Color.Transparent;
            this.btnIngreso.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnIngreso.Iconimage")));
            this.btnIngreso.Iconimage_right = null;
            this.btnIngreso.Iconimage_right_Selected = null;
            this.btnIngreso.Iconimage_Selected = null;
            this.btnIngreso.IconMarginLeft = 0;
            this.btnIngreso.IconMarginRight = 0;
            this.btnIngreso.IconRightVisible = true;
            this.btnIngreso.IconRightZoom = 0D;
            this.btnIngreso.IconVisible = true;
            this.btnIngreso.IconZoom = 60D;
            this.btnIngreso.IsTab = false;
            this.btnIngreso.Location = new System.Drawing.Point(22, 48);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Normalcolor = System.Drawing.Color.Transparent;
            this.btnIngreso.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnIngreso.OnHoverTextColor = System.Drawing.Color.White;
            this.btnIngreso.selected = false;
            this.btnIngreso.Size = new System.Drawing.Size(207, 48);
            this.btnIngreso.TabIndex = 16;
            this.btnIngreso.Text = "  Ingreso Almacen";
            this.btnIngreso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIngreso.Textcolor = System.Drawing.Color.White;
            this.btnIngreso.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(22, 102);
            this.panel1.TabIndex = 15;
            // 
            // BtnCompras
            // 
            this.BtnCompras.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.BtnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCompras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCompras.BorderRadius = 7;
            this.BtnCompras.ButtonText = "        Compras";
            this.BtnCompras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCompras.DisabledColor = System.Drawing.Color.Gray;
            this.BtnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCompras.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnCompras.Iconimage = ((System.Drawing.Image)(resources.GetObject("BtnCompras.Iconimage")));
            this.BtnCompras.Iconimage_right = null;
            this.BtnCompras.Iconimage_right_Selected = null;
            this.BtnCompras.Iconimage_Selected = null;
            this.BtnCompras.IconMarginLeft = 0;
            this.BtnCompras.IconMarginRight = 0;
            this.BtnCompras.IconRightVisible = true;
            this.BtnCompras.IconRightZoom = 0D;
            this.BtnCompras.IconVisible = true;
            this.BtnCompras.IconZoom = 90D;
            this.BtnCompras.IsTab = false;
            this.BtnCompras.Location = new System.Drawing.Point(0, 0);
            this.BtnCompras.Name = "BtnCompras";
            this.BtnCompras.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.BtnCompras.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.BtnCompras.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnCompras.selected = false;
            this.BtnCompras.Size = new System.Drawing.Size(229, 48);
            this.BtnCompras.TabIndex = 1;
            this.BtnCompras.Text = "        Compras";
            this.BtnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCompras.Textcolor = System.Drawing.Color.White;
            this.BtnCompras.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCompras.Click += new System.EventHandler(this.BtnCompras_Click);
            // 
            // panelSubmenuC
            // 
            this.panelSubmenuC.BackColor = System.Drawing.Color.Transparent;
            this.panelSubmenuC.Controls.Add(this.btncategorias);
            this.panelSubmenuC.Controls.Add(this.btnclientes);
            this.panelSubmenuC.Controls.Add(this.btnUsuarios);
            this.panelSubmenuC.Controls.Add(this.btnEmpleados);
            this.panelSubmenuC.Controls.Add(this.btnProducto);
            this.panelSubmenuC.Controls.Add(this.panel3);
            this.panelSubmenuC.Controls.Add(this.btncatalogo);
            this.panelSubmenuC.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubmenuC.Location = new System.Drawing.Point(0, 0);
            this.panelSubmenuC.MaximumSize = new System.Drawing.Size(229, 290);
            this.panelSubmenuC.MinimumSize = new System.Drawing.Size(229, 48);
            this.panelSubmenuC.Name = "panelSubmenuC";
            this.panelSubmenuC.Size = new System.Drawing.Size(229, 290);
            this.panelSubmenuC.TabIndex = 12;
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btnUsuarios.BackColor = System.Drawing.Color.Transparent;
            this.btnUsuarios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUsuarios.BorderRadius = 7;
            this.btnUsuarios.ButtonText = "   Usuarios";
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledColor = System.Drawing.Color.Gray;
            this.btnUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuarios.Iconcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Iconimage")));
            this.btnUsuarios.Iconimage_right = null;
            this.btnUsuarios.Iconimage_right_Selected = null;
            this.btnUsuarios.Iconimage_Selected = null;
            this.btnUsuarios.IconMarginLeft = 0;
            this.btnUsuarios.IconMarginRight = 0;
            this.btnUsuarios.IconRightVisible = true;
            this.btnUsuarios.IconRightZoom = 0D;
            this.btnUsuarios.IconVisible = true;
            this.btnUsuarios.IconZoom = 60D;
            this.btnUsuarios.IsTab = false;
            this.btnUsuarios.Location = new System.Drawing.Point(22, 144);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Normalcolor = System.Drawing.Color.Transparent;
            this.btnUsuarios.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnUsuarios.OnHoverTextColor = System.Drawing.Color.White;
            this.btnUsuarios.selected = false;
            this.btnUsuarios.Size = new System.Drawing.Size(207, 48);
            this.btnUsuarios.TabIndex = 17;
            this.btnUsuarios.Text = "   Usuarios";
            this.btnUsuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsuarios.Textcolor = System.Drawing.Color.White;
            this.btnUsuarios.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btnEmpleados.BackColor = System.Drawing.Color.Transparent;
            this.btnEmpleados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEmpleados.BorderRadius = 7;
            this.btnEmpleados.ButtonText = " Proveedores";
            this.btnEmpleados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleados.DisabledColor = System.Drawing.Color.Gray;
            this.btnEmpleados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEmpleados.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Iconimage")));
            this.btnEmpleados.Iconimage_right = null;
            this.btnEmpleados.Iconimage_right_Selected = null;
            this.btnEmpleados.Iconimage_Selected = null;
            this.btnEmpleados.IconMarginLeft = 0;
            this.btnEmpleados.IconMarginRight = 0;
            this.btnEmpleados.IconRightVisible = true;
            this.btnEmpleados.IconRightZoom = 0D;
            this.btnEmpleados.IconVisible = true;
            this.btnEmpleados.IconZoom = 60D;
            this.btnEmpleados.IsTab = false;
            this.btnEmpleados.Location = new System.Drawing.Point(22, 96);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Normalcolor = System.Drawing.Color.Transparent;
            this.btnEmpleados.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnEmpleados.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEmpleados.selected = false;
            this.btnEmpleados.Size = new System.Drawing.Size(207, 48);
            this.btnEmpleados.TabIndex = 16;
            this.btnEmpleados.Text = " Proveedores";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmpleados.Textcolor = System.Drawing.Color.White;
            this.btnEmpleados.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btnProducto.BackColor = System.Drawing.Color.Transparent;
            this.btnProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProducto.BorderRadius = 7;
            this.btnProducto.ButtonText = "  Productos";
            this.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProducto.DisabledColor = System.Drawing.Color.Gray;
            this.btnProducto.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProducto.Iconcolor = System.Drawing.Color.Transparent;
            this.btnProducto.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnProducto.Iconimage")));
            this.btnProducto.Iconimage_right = null;
            this.btnProducto.Iconimage_right_Selected = null;
            this.btnProducto.Iconimage_Selected = null;
            this.btnProducto.IconMarginLeft = 0;
            this.btnProducto.IconMarginRight = 0;
            this.btnProducto.IconRightVisible = true;
            this.btnProducto.IconRightZoom = 0D;
            this.btnProducto.IconVisible = true;
            this.btnProducto.IconZoom = 60D;
            this.btnProducto.IsTab = false;
            this.btnProducto.Location = new System.Drawing.Point(22, 48);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Normalcolor = System.Drawing.Color.Transparent;
            this.btnProducto.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnProducto.OnHoverTextColor = System.Drawing.Color.White;
            this.btnProducto.selected = false;
            this.btnProducto.Size = new System.Drawing.Size(207, 48);
            this.btnProducto.TabIndex = 15;
            this.btnProducto.Text = "  Productos";
            this.btnProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProducto.Textcolor = System.Drawing.Color.White;
            this.btnProducto.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(22, 242);
            this.panel3.TabIndex = 13;
            // 
            // btncatalogo
            // 
            this.btncatalogo.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btncatalogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btncatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncatalogo.BorderRadius = 7;
            this.btncatalogo.ButtonText = "        Catalogo";
            this.btncatalogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncatalogo.DisabledColor = System.Drawing.Color.Gray;
            this.btncatalogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncatalogo.Iconcolor = System.Drawing.Color.Transparent;
            this.btncatalogo.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncatalogo.Iconimage")));
            this.btncatalogo.Iconimage_right = null;
            this.btncatalogo.Iconimage_right_Selected = null;
            this.btncatalogo.Iconimage_Selected = null;
            this.btncatalogo.IconMarginLeft = 0;
            this.btncatalogo.IconMarginRight = 0;
            this.btncatalogo.IconRightVisible = true;
            this.btncatalogo.IconRightZoom = 0D;
            this.btncatalogo.IconVisible = true;
            this.btncatalogo.IconZoom = 90D;
            this.btncatalogo.IsTab = false;
            this.btncatalogo.Location = new System.Drawing.Point(0, 0);
            this.btncatalogo.Name = "btncatalogo";
            this.btncatalogo.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btncatalogo.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btncatalogo.OnHoverTextColor = System.Drawing.Color.White;
            this.btncatalogo.selected = false;
            this.btncatalogo.Size = new System.Drawing.Size(229, 48);
            this.btncatalogo.TabIndex = 12;
            this.btncatalogo.Text = "        Catalogo";
            this.btncatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncatalogo.Textcolor = System.Drawing.Color.White;
            this.btncatalogo.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncatalogo.Click += new System.EventHandler(this.btncatalogo_Click_1);
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(41)))), ((int)(((byte)(73)))));
            this.Titulo.Controls.Add(this.btnMinimizar);
            this.Titulo.Controls.Add(this.btnCerrar);
            this.Titulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Titulo.Location = new System.Drawing.Point(0, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1132, 43);
            this.Titulo.TabIndex = 1;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1042, -1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 8;
            this.btnMinimizar.UseVisualStyleBackColor = false;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCerrar.Image")));
            this.btnCerrar.Location = new System.Drawing.Point(1091, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 7;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // DeslizarArchivos
            // 
            this.DeslizarArchivos.Interval = 2;
            this.DeslizarArchivos.Tick += new System.EventHandler(this.DeslizarArchivos_Tick);
            // 
            // DeslizarComponentes
            // 
            this.DeslizarComponentes.Interval = 2;
            this.DeslizarComponentes.Tick += new System.EventHandler(this.DeslizarComponentes_Tick);
            // 
            // DeslizarMovimientos
            // 
            this.DeslizarMovimientos.Interval = 2;
            this.DeslizarMovimientos.Tick += new System.EventHandler(this.DeslizarMovimientos_Tick);
            // 
            // MinArc
            // 
            this.MinArc.Interval = 2;
            this.MinArc.Tick += new System.EventHandler(this.MinArc_Tick);
            // 
            // MinCom
            // 
            this.MinCom.Interval = 2;
            this.MinCom.Tick += new System.EventHandler(this.MinCom_Tick);
            // 
            // MinMov
            // 
            this.MinMov.Interval = 2;
            this.MinMov.Tick += new System.EventHandler(this.MinMov_Tick);
            // 
            // Control
            // 
            this.Control.Fixed = true;
            this.Control.Horizontal = true;
            this.Control.TargetControl = null;
            this.Control.Vertical = true;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(646, 44);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 9;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(735, 13);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(120, 31);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "21:49:45";
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // btnclientes
            // 
            this.btnclientes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btnclientes.BackColor = System.Drawing.Color.Transparent;
            this.btnclientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclientes.BorderRadius = 7;
            this.btnclientes.ButtonText = "   Clientes";
            this.btnclientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnclientes.DisabledColor = System.Drawing.Color.Gray;
            this.btnclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnclientes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnclientes.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnclientes.Iconimage")));
            this.btnclientes.Iconimage_right = null;
            this.btnclientes.Iconimage_right_Selected = null;
            this.btnclientes.Iconimage_Selected = null;
            this.btnclientes.IconMarginLeft = 0;
            this.btnclientes.IconMarginRight = 0;
            this.btnclientes.IconRightVisible = true;
            this.btnclientes.IconRightZoom = 0D;
            this.btnclientes.IconVisible = true;
            this.btnclientes.IconZoom = 80D;
            this.btnclientes.IsTab = false;
            this.btnclientes.Location = new System.Drawing.Point(22, 192);
            this.btnclientes.Name = "btnclientes";
            this.btnclientes.Normalcolor = System.Drawing.Color.Transparent;
            this.btnclientes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btnclientes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnclientes.selected = false;
            this.btnclientes.Size = new System.Drawing.Size(207, 48);
            this.btnclientes.TabIndex = 18;
            this.btnclientes.Text = "   Clientes";
            this.btnclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnclientes.Textcolor = System.Drawing.Color.White;
            this.btnclientes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclientes.Click += new System.EventHandler(this.btnclientes_Click);
            // 
            // panelGraficos
            // 
            this.panelGraficos.Controls.Add(this.bunifuFlatButton3);
            this.panelGraficos.Location = new System.Drawing.Point(3, 546);
            this.panelGraficos.Name = "panelGraficos";
            this.panelGraficos.Size = new System.Drawing.Size(229, 100);
            this.panelGraficos.TabIndex = 15;
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Graficos";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton3.Iconimage")));
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(0, 0);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(230, 48);
            this.bunifuFlatButton3.TabIndex = 0;
            this.bunifuFlatButton3.Text = "Graficos";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btncategorias
            // 
            this.btncategorias.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(100)))), ((int)(((byte)(156)))));
            this.btncategorias.BackColor = System.Drawing.Color.Transparent;
            this.btncategorias.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncategorias.BorderRadius = 7;
            this.btncategorias.ButtonText = "   Categorias";
            this.btncategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncategorias.DisabledColor = System.Drawing.Color.Gray;
            this.btncategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncategorias.Iconcolor = System.Drawing.Color.Transparent;
            this.btncategorias.Iconimage = ((System.Drawing.Image)(resources.GetObject("btncategorias.Iconimage")));
            this.btncategorias.Iconimage_right = null;
            this.btncategorias.Iconimage_right_Selected = null;
            this.btncategorias.Iconimage_Selected = null;
            this.btncategorias.IconMarginLeft = 0;
            this.btncategorias.IconMarginRight = 0;
            this.btncategorias.IconRightVisible = true;
            this.btncategorias.IconRightZoom = 0D;
            this.btncategorias.IconVisible = true;
            this.btncategorias.IconZoom = 80D;
            this.btncategorias.IsTab = false;
            this.btncategorias.Location = new System.Drawing.Point(22, 240);
            this.btncategorias.Name = "btncategorias";
            this.btncategorias.Normalcolor = System.Drawing.Color.Transparent;
            this.btncategorias.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(29)))), ((int)(((byte)(38)))));
            this.btncategorias.OnHoverTextColor = System.Drawing.Color.White;
            this.btncategorias.selected = false;
            this.btncategorias.Size = new System.Drawing.Size(207, 48);
            this.btncategorias.TabIndex = 19;
            this.btncategorias.Text = "   Categorias";
            this.btncategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncategorias.Textcolor = System.Drawing.Color.White;
            this.btncategorias.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncategorias.Click += new System.EventHandler(this.btncategorias_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 676);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Contenedor.ResumeLayout(false);
            this.PiedePagina.ResumeLayout(false);
            this.PiedePagina.PerformLayout();
            this.menup.ResumeLayout(false);
            this.VentasPanel.ResumeLayout(false);
            this.Compras.ResumeLayout(false);
            this.panelSubmenuC.ResumeLayout(false);
            this.Titulo.ResumeLayout(false);
            this.panelGraficos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel menup;
        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.Panel PiedePagina;
        private System.Windows.Forms.Panel FormPanel;
        private System.Windows.Forms.Timer DeslizarArchivos;
        private System.Windows.Forms.Timer DeslizarComponentes;
        private System.Windows.Forms.Timer DeslizarMovimientos;
        private System.Windows.Forms.Timer MinArc;
        private System.Windows.Forms.Timer MinCom;
        private System.Windows.Forms.Timer MinMov;
        private System.Windows.Forms.Panel panelSubmenuC;
        private Bunifu.Framework.UI.BunifuFlatButton btncatalogo;
        private Bunifu.Framework.UI.BunifuFlatButton btnProducto;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnEmpleados;
        private Bunifu.Framework.UI.BunifuFlatButton btnUsuarios;
        private System.Windows.Forms.Panel Compras;
        private Bunifu.Framework.UI.BunifuFlatButton BtnCompras;
        private Bunifu.Framework.UI.BunifuFlatButton btndetalleIngreso;
        private Bunifu.Framework.UI.BunifuFlatButton btnIngreso;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDragControl Control;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel VentasPanel;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuFlatButton Btnventas;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer tmFechaHora;
        private Bunifu.Framework.UI.BunifuFlatButton btnclientes;
        private System.Windows.Forms.Panel panelGraficos;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private Bunifu.Framework.UI.BunifuFlatButton btncategorias;
    }
}