namespace Ferreteria.MenuPrincipal
{
    partial class Frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menu));
            this.tmExpandirMenu = new System.Windows.Forms.Timer(this.components);
            this.tmContraerMenu = new System.Windows.Forms.Timer(this.components);
            this.tmFechaHora = new System.Windows.Forms.Timer(this.components);
            this.Contenedor = new System.Windows.Forms.Panel();
            this.PiedePagina = new System.Windows.Forms.Panel();
            this.lbFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.Titulo = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Menu = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnListaClientes = new System.Windows.Forms.Button();
            this.btndetalleventa = new System.Windows.Forms.Button();
            this.btnventa = new System.Windows.Forms.Button();
            this.btnempleados = new System.Windows.Forms.Button();
            this.btnproveedor = new System.Windows.Forms.Button();
            this.btnproductos = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.PictureBox();
            this.Contenedor.SuspendLayout();
            this.PiedePagina.SuspendLayout();
            this.Titulo.SuspendLayout();
            this.Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // tmExpandirMenu
            // 
            this.tmExpandirMenu.Interval = 15;
            this.tmExpandirMenu.Tick += new System.EventHandler(this.tmExpandirMenu_Tick);
            // 
            // tmContraerMenu
            // 
            this.tmContraerMenu.Interval = 15;
            this.tmContraerMenu.Tick += new System.EventHandler(this.tmContraerMenu_Tick);
            // 
            // tmFechaHora
            // 
            this.tmFechaHora.Enabled = true;
            this.tmFechaHora.Tick += new System.EventHandler(this.tmFechaHora_Tick);
            // 
            // Contenedor
            // 
            this.Contenedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.Contenedor.Controls.Add(this.PiedePagina);
            this.Contenedor.Controls.Add(this.Titulo);
            this.Contenedor.Controls.Add(this.panel1);
            this.Contenedor.Controls.Add(this.Menu);
            this.Contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contenedor.Location = new System.Drawing.Point(0, 0);
            this.Contenedor.Name = "Contenedor";
            this.Contenedor.Size = new System.Drawing.Size(1135, 715);
            this.Contenedor.TabIndex = 0;
            // 
            // PiedePagina
            // 
            this.PiedePagina.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            this.PiedePagina.Controls.Add(this.lbFecha);
            this.PiedePagina.Controls.Add(this.lblHora);
            this.PiedePagina.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PiedePagina.Location = new System.Drawing.Point(230, 615);
            this.PiedePagina.Name = "PiedePagina";
            this.PiedePagina.Size = new System.Drawing.Size(905, 100);
            this.PiedePagina.TabIndex = 5;
            // 
            // lbFecha
            // 
            this.lbFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbFecha.AutoSize = true;
            this.lbFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbFecha.ForeColor = System.Drawing.Color.White;
            this.lbFecha.Location = new System.Drawing.Point(671, 70);
            this.lbFecha.Name = "lbFecha";
            this.lbFecha.Size = new System.Drawing.Size(224, 20);
            this.lbFecha.TabIndex = 7;
            this.lbFecha.Text = "Lunes, 26 de septiembre 2018";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 35.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.LightGray;
            this.lblHora.Location = new System.Drawing.Point(693, 10);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(205, 54);
            this.lblHora.TabIndex = 6;
            this.lblHora.Text = "21:49:45";
            // 
            // Titulo
            // 
            this.Titulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(40)))), ((int)(((byte)(89)))));
            this.Titulo.Controls.Add(this.btnMinimizar);
            this.Titulo.Controls.Add(this.btnCerrar);
            this.Titulo.Location = new System.Drawing.Point(-1, 0);
            this.Titulo.Name = "Titulo";
            this.Titulo.Size = new System.Drawing.Size(1136, 43);
            this.Titulo.TabIndex = 0;
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(1045, 1);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 6;
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
            this.btnCerrar.Location = new System.Drawing.Point(1094, 3);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 2;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(230, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 581);
            this.panel1.TabIndex = 6;
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(34)))), ((int)(((byte)(39)))));
            this.Menu.Controls.Add(this.button1);
            this.Menu.Controls.Add(this.button2);
            this.Menu.Controls.Add(this.btnListaClientes);
            this.Menu.Controls.Add(this.btndetalleventa);
            this.Menu.Controls.Add(this.btnventa);
            this.Menu.Controls.Add(this.btnempleados);
            this.Menu.Controls.Add(this.btnproveedor);
            this.Menu.Controls.Add(this.btnproductos);
            this.Menu.Controls.Add(this.btnMenu);
            this.Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(230, 715);
            this.Menu.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Silver;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(226, 51);
            this.button1.TabIndex = 25;
            this.button1.Text = "Detalle Venta";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Silver;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1, 437);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(226, 51);
            this.button2.TabIndex = 24;
            this.button2.Text = "Venta";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnListaClientes
            // 
            this.btnListaClientes.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnListaClientes.FlatAppearance.BorderSize = 0;
            this.btnListaClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnListaClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaClientes.ForeColor = System.Drawing.Color.Silver;
            this.btnListaClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnListaClientes.Image")));
            this.btnListaClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaClientes.Location = new System.Drawing.Point(0, 208);
            this.btnListaClientes.Name = "btnListaClientes";
            this.btnListaClientes.Size = new System.Drawing.Size(230, 51);
            this.btnListaClientes.TabIndex = 23;
            this.btnListaClientes.Text = "Clientes";
            this.btnListaClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListaClientes.UseVisualStyleBackColor = true;
            this.btnListaClientes.Click += new System.EventHandler(this.btnListaClientes_Click);
            // 
            // btndetalleventa
            // 
            this.btndetalleventa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btndetalleventa.FlatAppearance.BorderSize = 0;
            this.btndetalleventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btndetalleventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btndetalleventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndetalleventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndetalleventa.ForeColor = System.Drawing.Color.Silver;
            this.btndetalleventa.Image = ((System.Drawing.Image)(resources.GetObject("btndetalleventa.Image")));
            this.btndetalleventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btndetalleventa.Location = new System.Drawing.Point(2, 368);
            this.btndetalleventa.Name = "btndetalleventa";
            this.btndetalleventa.Size = new System.Drawing.Size(226, 51);
            this.btndetalleventa.TabIndex = 22;
            this.btndetalleventa.Text = "Detalle Venta";
            this.btndetalleventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btndetalleventa.UseVisualStyleBackColor = true;
            // 
            // btnventa
            // 
            this.btnventa.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnventa.FlatAppearance.BorderSize = 0;
            this.btnventa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnventa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnventa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnventa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnventa.ForeColor = System.Drawing.Color.Silver;
            this.btnventa.Image = ((System.Drawing.Image)(resources.GetObject("btnventa.Image")));
            this.btnventa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnventa.Location = new System.Drawing.Point(1, 315);
            this.btnventa.Name = "btnventa";
            this.btnventa.Size = new System.Drawing.Size(226, 51);
            this.btnventa.TabIndex = 21;
            this.btnventa.Text = "Venta";
            this.btnventa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnventa.UseVisualStyleBackColor = true;
            // 
            // btnempleados
            // 
            this.btnempleados.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnempleados.FlatAppearance.BorderSize = 0;
            this.btnempleados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnempleados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnempleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnempleados.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnempleados.ForeColor = System.Drawing.Color.Silver;
            this.btnempleados.Image = ((System.Drawing.Image)(resources.GetObject("btnempleados.Image")));
            this.btnempleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnempleados.Location = new System.Drawing.Point(1, 258);
            this.btnempleados.Name = "btnempleados";
            this.btnempleados.Size = new System.Drawing.Size(230, 51);
            this.btnempleados.TabIndex = 20;
            this.btnempleados.Text = "Usuarios";
            this.btnempleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnempleados.UseVisualStyleBackColor = true;
            // 
            // btnproveedor
            // 
            this.btnproveedor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnproveedor.FlatAppearance.BorderSize = 0;
            this.btnproveedor.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnproveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproveedor.ForeColor = System.Drawing.Color.Silver;
            this.btnproveedor.Image = ((System.Drawing.Image)(resources.GetObject("btnproveedor.Image")));
            this.btnproveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproveedor.Location = new System.Drawing.Point(-2, 149);
            this.btnproveedor.Name = "btnproveedor";
            this.btnproveedor.Size = new System.Drawing.Size(226, 51);
            this.btnproveedor.TabIndex = 19;
            this.btnproveedor.Text = "Proveedor";
            this.btnproveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproveedor.UseVisualStyleBackColor = true;
            this.btnproveedor.Click += new System.EventHandler(this.btnproveedor_Click);
            // 
            // btnproductos
            // 
            this.btnproductos.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnproductos.FlatAppearance.BorderSize = 0;
            this.btnproductos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnproductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnproductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnproductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnproductos.ForeColor = System.Drawing.Color.Silver;
            this.btnproductos.Image = ((System.Drawing.Image)(resources.GetObject("btnproductos.Image")));
            this.btnproductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnproductos.Location = new System.Drawing.Point(1, 92);
            this.btnproductos.Name = "btnproductos";
            this.btnproductos.Size = new System.Drawing.Size(226, 51);
            this.btnproductos.TabIndex = 17;
            this.btnproductos.Text = "Productos";
            this.btnproductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnproductos.UseVisualStyleBackColor = true;
            this.btnproductos.Click += new System.EventHandler(this.btnproductos_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMenu.Image")));
            this.btnMenu.Location = new System.Drawing.Point(181, 49);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(43, 37);
            this.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btnMenu.TabIndex = 14;
            this.btnMenu.TabStop = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 715);
            this.Controls.Add(this.Contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Menu";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Menu";
            this.Contenedor.ResumeLayout(false);
            this.PiedePagina.ResumeLayout(false);
            this.PiedePagina.PerformLayout();
            this.Titulo.ResumeLayout(false);
            this.Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmExpandirMenu;
        private System.Windows.Forms.Timer tmContraerMenu;
        private System.Windows.Forms.Timer tmFechaHora;
        private System.Windows.Forms.Panel Contenedor;
        private System.Windows.Forms.Panel Menu;
        private System.Windows.Forms.Panel PiedePagina;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btnMenu;
        private System.Windows.Forms.Panel Titulo;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnproductos;
        private System.Windows.Forms.Button btnproveedor;
        private System.Windows.Forms.Button btnempleados;
        private System.Windows.Forms.Button btnventa;
        private System.Windows.Forms.Button btndetalleventa;
        private System.Windows.Forms.Button btnListaClientes;
        private System.Windows.Forms.Label lbFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}