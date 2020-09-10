namespace Ferreteria
{
    partial class Frm_IngresoAlmacen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_IngresoAlmacen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcodigoN = new System.Windows.Forms.TextBox();
            this.lblTotal_Pagado = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtfiltro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnbuscarp = new System.Windows.Forms.Button();
            this.txtigv = new System.Windows.Forms.TextBox();
            this.txtcorrelativo = new System.Windows.Forms.TextBox();
            this.txtserie = new System.Windows.Forms.TextBox();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnquitar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtbuscarporcodigo = new System.Windows.Forms.Label();
            this.chProducto_Nuevo = new System.Windows.Forms.CheckBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbComprobante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFecha_Produccion = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioventa = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.dataListadoDetalle = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtFecha_Vencimiento = new System.Windows.Forms.DateTimePicker();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.txtId_Ingreso = new System.Windows.Forms.TextBox();
            this.txtIdproducto = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.btnnormal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(822, 491);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcodigoN);
            this.groupBox1.Controls.Add(this.lblTotal_Pagado);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtfiltro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnbuscarp);
            this.groupBox1.Controls.Add(this.txtigv);
            this.groupBox1.Controls.Add(this.txtcorrelativo);
            this.groupBox1.Controls.Add(this.txtserie);
            this.groupBox1.Controls.Add(this.btncancelar);
            this.groupBox1.Controls.Add(this.btnquitar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtbuscarporcodigo);
            this.groupBox1.Controls.Add(this.chProducto_Nuevo);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbComprobante);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dtFecha_Produccion);
            this.groupBox1.Controls.Add(this.txtPrecioventa);
            this.groupBox1.Controls.Add(this.txtStock);
            this.groupBox1.Controls.Add(this.dataListadoDetalle);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.Nuevo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboProveedor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtproducto);
            this.groupBox1.Controls.Add(this.txtId_Ingreso);
            this.groupBox1.Controls.Add(this.txtIdproducto);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 424);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // txtcodigoN
            // 
            this.txtcodigoN.BackColor = System.Drawing.Color.White;
            this.txtcodigoN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtcodigoN.Location = new System.Drawing.Point(352, 213);
            this.txtcodigoN.Margin = new System.Windows.Forms.Padding(2);
            this.txtcodigoN.Name = "txtcodigoN";
            this.txtcodigoN.Size = new System.Drawing.Size(137, 24);
            this.txtcodigoN.TabIndex = 240;
            this.txtcodigoN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            // 
            // lblTotal_Pagado
            // 
            this.lblTotal_Pagado.AutoSize = true;
            this.lblTotal_Pagado.Location = new System.Drawing.Point(407, 392);
            this.lblTotal_Pagado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal_Pagado.Name = "lblTotal_Pagado";
            this.lblTotal_Pagado.Size = new System.Drawing.Size(28, 18);
            this.lblTotal_Pagado.TabIndex = 239;
            this.lblTotal_Pagado.Text = "0.0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(271, 392);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 18);
            this.label6.TabIndex = 238;
            this.label6.Text = "Total Pagado $";
            // 
            // txtfiltro
            // 
            this.txtfiltro.BackColor = System.Drawing.Color.Lime;
            this.txtfiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtfiltro.Location = new System.Drawing.Point(164, 213);
            this.txtfiltro.Name = "txtfiltro";
            this.txtfiltro.Size = new System.Drawing.Size(137, 24);
            this.txtfiltro.TabIndex = 237;
            this.txtfiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtfiltro_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(265, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 18);
            this.label5.TabIndex = 236;
            this.label5.Text = "IGV";
            // 
            // btnbuscarp
            // 
            this.btnbuscarp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnbuscarp.BackColor = System.Drawing.Color.Gray;
            this.btnbuscarp.FlatAppearance.BorderSize = 0;
            this.btnbuscarp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnbuscarp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnbuscarp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscarp.ForeColor = System.Drawing.Color.White;
            this.btnbuscarp.Location = new System.Drawing.Point(352, 172);
            this.btnbuscarp.Name = "btnbuscarp";
            this.btnbuscarp.Size = new System.Drawing.Size(27, 25);
            this.btnbuscarp.TabIndex = 235;
            this.btnbuscarp.Text = "....";
            this.btnbuscarp.UseVisualStyleBackColor = false;
            this.btnbuscarp.Click += new System.EventHandler(this.btnbuscarp_Click);
            // 
            // txtigv
            // 
            this.txtigv.BackColor = System.Drawing.Color.White;
            this.txtigv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtigv.Location = new System.Drawing.Point(312, 135);
            this.txtigv.Name = "txtigv";
            this.txtigv.Size = new System.Drawing.Size(64, 24);
            this.txtigv.TabIndex = 234;
            // 
            // txtcorrelativo
            // 
            this.txtcorrelativo.BackColor = System.Drawing.Color.White;
            this.txtcorrelativo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorrelativo.Location = new System.Drawing.Point(192, 135);
            this.txtcorrelativo.Name = "txtcorrelativo";
            this.txtcorrelativo.Size = new System.Drawing.Size(64, 24);
            this.txtcorrelativo.TabIndex = 233;
            // 
            // txtserie
            // 
            this.txtserie.BackColor = System.Drawing.Color.White;
            this.txtserie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserie.Location = new System.Drawing.Point(122, 135);
            this.txtserie.Name = "txtserie";
            this.txtserie.Size = new System.Drawing.Size(64, 24);
            this.txtserie.TabIndex = 232;
            // 
            // btncancelar
            // 
            this.btncancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btncancelar.BackColor = System.Drawing.Color.Maroon;
            this.btncancelar.FlatAppearance.BorderSize = 0;
            this.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancelar.ForeColor = System.Drawing.Color.White;
            this.btncancelar.Location = new System.Drawing.Point(676, 350);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(100, 30);
            this.btncancelar.TabIndex = 231;
            this.btncancelar.Text = "Cancelar";
            this.btncancelar.UseVisualStyleBackColor = false;
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnquitar
            // 
            this.btnquitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnquitar.BackColor = System.Drawing.Color.Maroon;
            this.btnquitar.FlatAppearance.BorderSize = 0;
            this.btnquitar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnquitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnquitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquitar.ForeColor = System.Drawing.Color.White;
            this.btnquitar.Location = new System.Drawing.Point(676, 109);
            this.btnquitar.Name = "btnquitar";
            this.btnquitar.Size = new System.Drawing.Size(100, 30);
            this.btnquitar.TabIndex = 228;
            this.btnquitar.Text = "Quitar";
            this.btnquitar.UseVisualStyleBackColor = false;
            this.btnquitar.Click += new System.EventHandler(this.btnquitar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnagregar.BackColor = System.Drawing.Color.Yellow;
            this.btnagregar.FlatAppearance.BorderSize = 0;
            this.btnagregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnagregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Location = new System.Drawing.Point(676, 70);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(100, 30);
            this.btnagregar.TabIndex = 227;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtbuscarporcodigo
            // 
            this.txtbuscarporcodigo.AutoSize = true;
            this.txtbuscarporcodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtbuscarporcodigo.Location = new System.Drawing.Point(19, 215);
            this.txtbuscarporcodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtbuscarporcodigo.Name = "txtbuscarporcodigo";
            this.txtbuscarporcodigo.Size = new System.Drawing.Size(138, 20);
            this.txtbuscarporcodigo.TabIndex = 226;
            this.txtbuscarporcodigo.Text = "Buscar Por codigo";
            // 
            // chProducto_Nuevo
            // 
            this.chProducto_Nuevo.AutoSize = true;
            this.chProducto_Nuevo.Location = new System.Drawing.Point(306, 31);
            this.chProducto_Nuevo.Name = "chProducto_Nuevo";
            this.chProducto_Nuevo.Size = new System.Drawing.Size(70, 22);
            this.chProducto_Nuevo.TabIndex = 224;
            this.chProducto_Nuevo.Text = "Nuevo";
            this.chProducto_Nuevo.UseVisualStyleBackColor = true;
            this.chProducto_Nuevo.CheckedChanged += new System.EventHandler(this.chProducto_Nuevo_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(20, 141);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 221;
            this.label14.Text = "Numero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(18, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 18);
            this.label3.TabIndex = 218;
            this.label3.Text = "Comprobante";
            // 
            // cmbComprobante
            // 
            this.cmbComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbComprobante.FormattingEnabled = true;
            this.cmbComprobante.Location = new System.Drawing.Point(122, 67);
            this.cmbComprobante.Name = "cmbComprobante";
            this.cmbComprobante.Size = new System.Drawing.Size(137, 26);
            this.cmbComprobante.TabIndex = 217;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(412, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 216;
            this.label2.Text = "F_Produccion";
            // 
            // dtFecha_Produccion
            // 
            this.dtFecha_Produccion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Produccion.Location = new System.Drawing.Point(532, 133);
            this.dtFecha_Produccion.Name = "dtFecha_Produccion";
            this.dtFecha_Produccion.Size = new System.Drawing.Size(114, 24);
            this.dtFecha_Produccion.TabIndex = 215;
            // 
            // txtPrecioventa
            // 
            this.txtPrecioventa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioventa.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioventa.Location = new System.Drawing.Point(534, 69);
            this.txtPrecioventa.Name = "txtPrecioventa";
            this.txtPrecioventa.Size = new System.Drawing.Size(50, 24);
            this.txtPrecioventa.TabIndex = 198;
            this.txtPrecioventa.Text = "0,00";
            this.txtPrecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioventa_KeyPress);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(534, 102);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 24);
            this.txtStock.TabIndex = 192;
            this.txtStock.Text = "0";
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // dataListadoDetalle
            // 
            this.dataListadoDetalle.AllowUserToAddRows = false;
            this.dataListadoDetalle.AllowUserToDeleteRows = false;
            this.dataListadoDetalle.BackgroundColor = System.Drawing.Color.White;
            this.dataListadoDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataListadoDetalle.Location = new System.Drawing.Point(24, 251);
            this.dataListadoDetalle.Name = "dataListadoDetalle";
            this.dataListadoDetalle.ReadOnly = true;
            this.dataListadoDetalle.Size = new System.Drawing.Size(636, 129);
            this.dataListadoDetalle.TabIndex = 214;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.Lime;
            this.label16.Location = new System.Drawing.Point(408, 72);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 18);
            this.label16.TabIndex = 199;
            this.label16.Text = "Precio Venta s/:";
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
            this.Guardar.Location = new System.Drawing.Point(676, 314);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 30);
            this.Guardar.TabIndex = 213;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = false;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
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
            this.Nuevo.Location = new System.Drawing.Point(676, 278);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(100, 30);
            this.Nuevo.TabIndex = 209;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = false;
            this.Nuevo.Click += new System.EventHandler(this.Nuevo_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.dtFecha_Vencimiento);
            this.groupBox2.Controls.Add(this.txtPrecioCompra);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(399, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(261, 180);
            this.groupBox2.TabIndex = 202;
            this.groupBox2.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(13, 144);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 218;
            this.label13.Text = "F_Vencimiento";
            // 
            // dtFecha_Vencimiento
            // 
            this.dtFecha_Vencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFecha_Vencimiento.Location = new System.Drawing.Point(133, 142);
            this.dtFecha_Vencimiento.Name = "dtFecha_Vencimiento";
            this.dtFecha_Vencimiento.Size = new System.Drawing.Size(114, 24);
            this.dtFecha_Vencimiento.TabIndex = 217;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.MediumAquamarine;
            this.txtPrecioCompra.Location = new System.Drawing.Point(135, 16);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(50, 24);
            this.txtPrecioCompra.TabIndex = 190;
            this.txtPrecioCompra.Text = "0,00";
            this.txtPrecioCompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioCompra_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(9, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 18);
            this.label9.TabIndex = 191;
            this.label9.Text = "Precio Compra";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(10, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 18);
            this.label12.TabIndex = 193;
            this.label12.Text = "Stock:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(18, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 18);
            this.label10.TabIndex = 201;
            this.label10.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(121, 29);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(114, 24);
            this.dtpfecha.TabIndex = 200;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(18, 105);
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
            this.cboProveedor.Location = new System.Drawing.Point(121, 100);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(254, 26);
            this.cboProveedor.TabIndex = 188;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Producto";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.Color.White;
            this.txtproducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtproducto.Location = new System.Drawing.Point(119, 173);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(227, 24);
            this.txtproducto.TabIndex = 10;
            // 
            // txtId_Ingreso
            // 
            this.txtId_Ingreso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtId_Ingreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Ingreso.Location = new System.Drawing.Point(121, 68);
            this.txtId_Ingreso.Name = "txtId_Ingreso";
            this.txtId_Ingreso.Size = new System.Drawing.Size(75, 24);
            this.txtId_Ingreso.TabIndex = 6;
            this.txtId_Ingreso.TextChanged += new System.EventHandler(this.txtId_Ingreso_TextChanged);
            // 
            // txtIdproducto
            // 
            this.txtIdproducto.BackColor = System.Drawing.Color.White;
            this.txtIdproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdproducto.Location = new System.Drawing.Point(185, 173);
            this.txtIdproducto.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdproducto.Name = "txtIdproducto";
            this.txtIdproducto.Size = new System.Drawing.Size(52, 24);
            this.txtIdproducto.TabIndex = 230;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(43)))), ((int)(((byte)(50)))));
            this.panel2.Controls.Add(this.btnnormal);
            this.panel2.Controls.Add(this.btnMinimizar);
            this.panel2.Controls.Add(this.btnCerrar);
            this.panel2.Controls.Add(this.btnLogo);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(822, 43);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(297, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "INGRESO ALMACEN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ttMensaje
            // 
            this.ttMensaje.IsBalloon = true;
            // 
            // btnnormal
            // 
            this.btnnormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnormal.FlatAppearance.BorderSize = 0;
            this.btnnormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnormal.Image = ((System.Drawing.Image)(resources.GetObject("btnnormal.Image")));
            this.btnnormal.Location = new System.Drawing.Point(681, 0);
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
            this.btnMinimizar.Location = new System.Drawing.Point(730, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(779, 1);
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
            // Frm_IngresoAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 491);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_IngresoAlmacen";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_IngresoAlmacen";
            this.Load += new System.EventHandler(this.Frm_IngresoAlmacen_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataListadoDetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox txtId_Ingreso;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnnormal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtPrecioventa;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Nuevo;
          private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView dataListadoDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFecha_Produccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtFecha_Vencimiento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbComprobante;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label txtbuscarporcodigo;
        private System.Windows.Forms.CheckBox chProducto_Nuevo;
        private System.Windows.Forms.Button btnquitar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtIdproducto;
        private System.Windows.Forms.Button btncancelar;
        private System.Windows.Forms.TextBox txtigv;
        private System.Windows.Forms.TextBox txtcorrelativo;
        private System.Windows.Forms.TextBox txtserie;
        private System.Windows.Forms.Button btnbuscarp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfiltro;
        private System.Windows.Forms.Label lblTotal_Pagado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtcodigoN;
        private System.Windows.Forms.ToolTip ttMensaje;
    }
}