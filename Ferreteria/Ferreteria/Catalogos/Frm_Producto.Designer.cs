﻿namespace Ferreteria
{
    partial class Frm_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Producto));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PCTCodigoBarra = new System.Windows.Forms.PictureBox();
            this.Guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Nuevo = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecioproducto = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtStockMin = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtStockPromedio = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboUnidMed = new System.Windows.Forms.ComboBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgwProducto = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo_Prod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Prod = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnormal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Codigo_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion_Umed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RazSocial_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioCompra_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Stock_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockMin_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StockProm_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechCreacion_Prod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodigoBarra = new System.Windows.Forms.DataGridViewImageColumn();
            this.Imagen = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCTCodigoBarra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(907, 670);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.PCTCodigoBarra);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.Nuevo);
            this.groupBox1.Controls.Add(this.bteditar);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboProveedor);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.cboUnidMed);
            this.groupBox1.Controls.Add(this.cboCategoria);
            this.groupBox1.Controls.Add(this.txtmarca);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelContador);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pxImagen);
            this.groupBox1.Controls.Add(this.btnbuscar);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.dgwProducto);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo_Prod);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId_Prod);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(883, 604);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // PCTCodigoBarra
            // 
            this.PCTCodigoBarra.BackColor = System.Drawing.Color.Transparent;
            this.PCTCodigoBarra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PCTCodigoBarra.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PCTCodigoBarra.ErrorImage = null;
            this.PCTCodigoBarra.InitialImage = null;
            this.PCTCodigoBarra.Location = new System.Drawing.Point(21, 140);
            this.PCTCodigoBarra.Name = "PCTCodigoBarra";
            this.PCTCodigoBarra.Size = new System.Drawing.Size(390, 100);
            this.PCTCodigoBarra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PCTCodigoBarra.TabIndex = 214;
            this.PCTCodigoBarra.TabStop = false;
            // 
            // Guardar
            // 
            this.Guardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Guardar.BackColor = System.Drawing.Color.SeaGreen;
            this.Guardar.FlatAppearance.BorderSize = 0;
            this.Guardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.ForeColor = System.Drawing.Color.White;
            this.Guardar.Location = new System.Drawing.Point(304, 21);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 30);
            this.Guardar.TabIndex = 213;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(426, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 210;
            this.pictureBox1.TabStop = false;
            // 
            // Nuevo
            // 
            this.Nuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Nuevo.BackColor = System.Drawing.Color.SeaGreen;
            this.Nuevo.FlatAppearance.BorderSize = 0;
            this.Nuevo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nuevo.ForeColor = System.Drawing.Color.White;
            this.Nuevo.Location = new System.Drawing.Point(198, 21);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(100, 30);
            this.Nuevo.TabIndex = 209;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // bteditar
            // 
            this.bteditar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bteditar.BackColor = System.Drawing.Color.SeaGreen;
            this.bteditar.FlatAppearance.BorderSize = 0;
            this.bteditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.bteditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bteditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bteditar.ForeColor = System.Drawing.Color.White;
            this.bteditar.Location = new System.Drawing.Point(410, 20);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(100, 30);
            this.bteditar.TabIndex = 207;
            this.bteditar.Text = "Editar";
            this.bteditar.UseVisualStyleBackColor = false;
            this.bteditar.Click += new System.EventHandler(this.bteditar_Click);
            // 
            // Eliminar
            // 
            this.Eliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Eliminar.BackColor = System.Drawing.Color.SeaGreen;
            this.Eliminar.FlatAppearance.BorderSize = 0;
            this.Eliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eliminar.ForeColor = System.Drawing.Color.White;
            this.Eliminar.Location = new System.Drawing.Point(516, 20);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 30);
            this.Eliminar.TabIndex = 206;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtPrecioproducto);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.txtStockMin);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtStock);
            this.groupBox2.Controls.Add(this.txtStockPromedio);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Location = new System.Drawing.Point(19, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(846, 41);
            this.groupBox2.TabIndex = 202;
            this.groupBox2.TabStop = false;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioCompra.Location = new System.Drawing.Point(135, 11);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(50, 24);
            this.txtPrecioCompra.TabIndex = 190;
            this.txtPrecioCompra.Text = "0,00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(19, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 191;
            this.label9.Text = "Precio Compra";
            // 
            // txtPrecioproducto
            // 
            this.txtPrecioproducto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioproducto.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioproducto.Location = new System.Drawing.Point(318, 11);
            this.txtPrecioproducto.Name = "txtPrecioproducto";
            this.txtPrecioproducto.Size = new System.Drawing.Size(50, 24);
            this.txtPrecioproducto.TabIndex = 198;
            this.txtPrecioproducto.Text = "0,00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(678, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(104, 18);
            this.label14.TabIndex = 197;
            this.label14.Text = "Stock Minimo:";
            // 
            // txtStockMin
            // 
            this.txtStockMin.Location = new System.Drawing.Point(784, 12);
            this.txtStockMin.Name = "txtStockMin";
            this.txtStockMin.Size = new System.Drawing.Size(50, 24);
            this.txtStockMin.TabIndex = 196;
            this.txtStockMin.Text = "0";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(195, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 18);
            this.label16.TabIndex = 199;
            this.label16.Text = "Precio Venta s/:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(438, 10);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 24);
            this.txtStock.TabIndex = 192;
            this.txtStock.Text = "0";
            // 
            // txtStockPromedio
            // 
            this.txtStockPromedio.Location = new System.Drawing.Point(620, 11);
            this.txtStockPromedio.Name = "txtStockPromedio";
            this.txtStockPromedio.Size = new System.Drawing.Size(50, 24);
            this.txtStockPromedio.TabIndex = 194;
            this.txtStockPromedio.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(382, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 193;
            this.label12.Text = "Stock:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(496, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 18);
            this.label13.TabIndex = 195;
            this.label13.Text = "Stock Promedio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(672, 27);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 201;
            this.label10.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(751, 23);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(114, 24);
            this.dtpfecha.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(334, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 189;
            this.label8.Text = "Proveedor";
            // 
            // cboProveedor
            // 
            this.cboProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(418, 249);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(156, 26);
            this.cboProveedor.TabIndex = 188;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(301, 331);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 18);
            this.label11.TabIndex = 187;
            this.label11.Text = "Uni. Medida";
            // 
            // cboUnidMed
            // 
            this.cboUnidMed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboUnidMed.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidMed.FormattingEnabled = true;
            this.cboUnidMed.Location = new System.Drawing.Point(409, 325);
            this.cboUnidMed.Name = "cboUnidMed";
            this.cboUnidMed.Size = new System.Drawing.Size(165, 26);
            this.cboUnidMed.TabIndex = 186;
            // 
            // cboCategoria
            // 
            this.cboCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(121, 289);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(453, 26);
            this.cboCategoria.TabIndex = 185;
            // 
            // txtmarca
            // 
            this.txtmarca.BackColor = System.Drawing.Color.White;
            this.txtmarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmarca.Location = new System.Drawing.Point(121, 327);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(156, 24);
            this.txtmarca.TabIndex = 177;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(18, 382);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 18);
            this.label7.TabIndex = 176;
            this.label7.Text = "Total :";
            // 
            // labelContador
            // 
            this.labelContador.AutoSize = true;
            this.labelContador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContador.ForeColor = System.Drawing.Color.Lime;
            this.labelContador.Location = new System.Drawing.Point(73, 380);
            this.labelContador.Name = "labelContador";
            this.labelContador.Size = new System.Drawing.Size(14, 20);
            this.labelContador.TabIndex = 175;
            this.labelContador.Text = ".";
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Default;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Yellow;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(741, 345);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 30);
            this.button2.TabIndex = 174;
            this.button2.Text = "Limpiar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Yellow;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(661, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 30);
            this.button1.TabIndex = 173;
            this.button1.Text = "Cargar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pxImagen
            // 
            this.pxImagen.BackColor = System.Drawing.Color.Transparent;
            this.pxImagen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pxImagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pxImagen.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.pxImagen.ErrorImage = null;
            this.pxImagen.InitialImage = null;
            this.pxImagen.Location = new System.Drawing.Point(602, 108);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(263, 231);
            this.pxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxImagen.TabIndex = 172;
            this.pxImagen.TabStop = false;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbuscar.BackColor = System.Drawing.Color.Gray;
            this.btnbuscar.FlatAppearance.BorderSize = 0;
            this.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.ForeColor = System.Drawing.Color.White;
            this.btnbuscar.Location = new System.Drawing.Point(229, 375);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(86, 27);
            this.btnbuscar.TabIndex = 171;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = false;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.Location = new System.Drawing.Point(322, 376);
            this.txtFiltro.MaxLength = 20;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(294, 24);
            this.txtFiltro.TabIndex = 170;
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(18, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 18);
            this.label6.TabIndex = 25;
            this.label6.Text = "Marca";
            // 
            // btneliminar
            // 
            this.btneliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btneliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btneliminar.Cursor = System.Windows.Forms.Cursors.Default;
            this.btneliminar.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btneliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btneliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btneliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btneliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btneliminar.ForeColor = System.Drawing.Color.Yellow;
            this.btneliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btneliminar.Location = new System.Drawing.Point(639, 185);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(100, 30);
            this.btneliminar.TabIndex = 22;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btneliminar.UseVisualStyleBackColor = false;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgwProducto
            // 
            this.dgwProducto.AllowUserToAddRows = false;
            this.dgwProducto.AllowUserToDeleteRows = false;
            this.dgwProducto.AllowUserToOrderColumns = true;
            this.dgwProducto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwProducto.ColumnHeadersHeight = 30;
            this.dgwProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo_Prod,
            this.Nombre_Prod,
            this.Marca_Prod,
            this.Nombre_Cat,
            this.Descripcion_Umed,
            this.RazSocial_Proveedor,
            this.PrecioCompra_Prod,
            this.Precio_Prod,
            this.Stock_Prod,
            this.StockMin_Prod,
            this.StockProm_Prod,
            this.FechCreacion_Prod,
            this.CodigoBarra,
            this.Imagen});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwProducto.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwProducto.EnableHeadersVisualStyles = false;
            this.dgwProducto.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProducto.Location = new System.Drawing.Point(17, 419);
            this.dgwProducto.Name = "dgwProducto";
            this.dgwProducto.ReadOnly = true;
            this.dgwProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProducto.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwProducto.Size = new System.Drawing.Size(848, 170);
            this.dgwProducto.TabIndex = 3;
            this.dgwProducto.SelectionChanged += new System.EventHandler(this.dgwProducto_SelectionChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Categoria";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(18, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.White;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(121, 252);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(205, 24);
            this.txtproducto.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Codigo ";
            // 
            // txtCodigo_Prod
            // 
            this.txtCodigo_Prod.BackColor = System.Drawing.Color.White;
            this.txtCodigo_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo_Prod.Location = new System.Drawing.Point(208, 105);
            this.txtCodigo_Prod.Name = "txtCodigo_Prod";
            this.txtCodigo_Prod.Size = new System.Drawing.Size(201, 24);
            this.txtCodigo_Prod.TabIndex = 8;
            this.txtCodigo_Prod.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_Prod_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // txtId_Prod
            // 
            this.txtId_Prod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtId_Prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Prod.Location = new System.Drawing.Point(43, 107);
            this.txtId_Prod.Name = "txtId_Prod";
            this.txtId_Prod.Size = new System.Drawing.Size(75, 24);
            this.txtId_Prod.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(61)))), ((int)(((byte)(92)))));
            this.panel2.Controls.Add(this.btnnormal);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(907, 43);
            this.panel2.TabIndex = 0;
            // 
            // btnnormal
            // 
            this.btnnormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnormal.FlatAppearance.BorderSize = 0;
            this.btnnormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnormal.Image = ((System.Drawing.Image)(resources.GetObject("btnnormal.Image")));
            this.btnnormal.Location = new System.Drawing.Point(766, 0);
            this.btnnormal.Name = "btnnormal";
            this.btnnormal.Size = new System.Drawing.Size(43, 43);
            this.btnnormal.TabIndex = 19;
            this.btnnormal.UseVisualStyleBackColor = false;
            this.btnnormal.Click += new System.EventHandler(this.btnnormal_Click);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizar.Image")));
            this.btnMinimizar.Location = new System.Drawing.Point(815, 0);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(43, 43);
            this.btnMinimizar.TabIndex = 18;
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
            this.btnCerrar.Location = new System.Drawing.Point(864, 1);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(39, 39);
            this.btnCerrar.TabIndex = 17;
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnLogo
            // 
            this.btnLogo.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnLogo.FlatAppearance.BorderSize = 0;
            this.btnLogo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnLogo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnLogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogo.ForeColor = System.Drawing.Color.Silver;
            this.btnLogo.Image = ((System.Drawing.Image)(resources.GetObject("btnLogo.Image")));
            this.btnLogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogo.Location = new System.Drawing.Point(1, -3);
            this.btnLogo.Name = "btnLogo";
            this.btnLogo.Size = new System.Drawing.Size(66, 51);
            this.btnLogo.TabIndex = 16;
            this.btnLogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLogo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(326, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CATALOGO DE PRODUCTOS";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Codigo_Prod
            // 
            this.Codigo_Prod.DataPropertyName = "Codigo_Prod";
            this.Codigo_Prod.HeaderText = "Codigo";
            this.Codigo_Prod.Name = "Codigo_Prod";
            this.Codigo_Prod.ReadOnly = true;
            this.Codigo_Prod.Width = 120;
            // 
            // Nombre_Prod
            // 
            this.Nombre_Prod.DataPropertyName = "Nombre_Prod";
            this.Nombre_Prod.HeaderText = "Producto";
            this.Nombre_Prod.Name = "Nombre_Prod";
            this.Nombre_Prod.ReadOnly = true;
            this.Nombre_Prod.Width = 166;
            // 
            // Marca_Prod
            // 
            this.Marca_Prod.DataPropertyName = "Marca_Prod";
            this.Marca_Prod.HeaderText = "Marca";
            this.Marca_Prod.Name = "Marca_Prod";
            this.Marca_Prod.ReadOnly = true;
            this.Marca_Prod.Visible = false;
            // 
            // Nombre_Cat
            // 
            this.Nombre_Cat.DataPropertyName = "Nombre_Cat";
            this.Nombre_Cat.HeaderText = "Categoria";
            this.Nombre_Cat.Name = "Nombre_Cat";
            this.Nombre_Cat.ReadOnly = true;
            this.Nombre_Cat.Visible = false;
            // 
            // Descripcion_Umed
            // 
            this.Descripcion_Umed.DataPropertyName = "Descripcion_Umed";
            this.Descripcion_Umed.HeaderText = "Umed";
            this.Descripcion_Umed.Name = "Descripcion_Umed";
            this.Descripcion_Umed.ReadOnly = true;
            this.Descripcion_Umed.Visible = false;
            // 
            // RazSocial_Proveedor
            // 
            this.RazSocial_Proveedor.DataPropertyName = "RazSocial_Proveedor";
            this.RazSocial_Proveedor.HeaderText = "Proveedor";
            this.RazSocial_Proveedor.Name = "RazSocial_Proveedor";
            this.RazSocial_Proveedor.ReadOnly = true;
            this.RazSocial_Proveedor.Visible = false;
            // 
            // PrecioCompra_Prod
            // 
            this.PrecioCompra_Prod.DataPropertyName = "PrecioCompra_Prod";
            this.PrecioCompra_Prod.HeaderText = "PrecioCompra";
            this.PrecioCompra_Prod.Name = "PrecioCompra_Prod";
            this.PrecioCompra_Prod.ReadOnly = true;
            this.PrecioCompra_Prod.Width = 120;
            // 
            // Precio_Prod
            // 
            this.Precio_Prod.DataPropertyName = "Precio_Prod";
            this.Precio_Prod.HeaderText = "Precio";
            this.Precio_Prod.Name = "Precio_Prod";
            this.Precio_Prod.ReadOnly = true;
            // 
            // Stock_Prod
            // 
            this.Stock_Prod.DataPropertyName = "Stock_Prod";
            this.Stock_Prod.HeaderText = "Stock";
            this.Stock_Prod.Name = "Stock_Prod";
            this.Stock_Prod.ReadOnly = true;
            // 
            // StockMin_Prod
            // 
            this.StockMin_Prod.DataPropertyName = "StockMin_Prod";
            this.StockMin_Prod.HeaderText = "StockMin";
            this.StockMin_Prod.Name = "StockMin_Prod";
            this.StockMin_Prod.ReadOnly = true;
            // 
            // StockProm_Prod
            // 
            this.StockProm_Prod.DataPropertyName = "StockProm_Prod";
            this.StockProm_Prod.HeaderText = "StockProm";
            this.StockProm_Prod.Name = "StockProm_Prod";
            this.StockProm_Prod.ReadOnly = true;
            // 
            // FechCreacion_Prod
            // 
            this.FechCreacion_Prod.DataPropertyName = "FechCreacion_Prod";
            this.FechCreacion_Prod.HeaderText = "FechCreacion";
            this.FechCreacion_Prod.Name = "FechCreacion_Prod";
            this.FechCreacion_Prod.ReadOnly = true;
            this.FechCreacion_Prod.Visible = false;
            // 
            // CodigoBarra
            // 
            this.CodigoBarra.DataPropertyName = "CodigoBarra";
            this.CodigoBarra.HeaderText = "CodigoBarra";
            this.CodigoBarra.Name = "CodigoBarra";
            this.CodigoBarra.ReadOnly = true;
            this.CodigoBarra.Visible = false;
            // 
            // Imagen
            // 
            this.Imagen.DataPropertyName = "Imagen";
            this.Imagen.HeaderText = "Imagen";
            this.Imagen.Name = "Imagen";
            this.Imagen.ReadOnly = true;
            this.Imagen.Visible = false;
            // 
            // Frm_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 670);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Producto";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Producto";
            this.Load += new System.EventHandler(this.Frm_Producto_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PCTCodigoBarra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducto)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo_Prod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Prod;
        private System.Windows.Forms.DataGridView dgwProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnnormal;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboUnidMed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.TextBox txtStockMin;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtStockPromedio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioproducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.PictureBox pictureBox1;
          private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.PictureBox PCTCodigoBarra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion_Umed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RazSocial_Proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioCompra_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Stock_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockMin_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn StockProm_Prod;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechCreacion_Prod;
        private System.Windows.Forms.DataGridViewImageColumn CodigoBarra;
        private System.Windows.Forms.DataGridViewImageColumn Imagen;
    }
}