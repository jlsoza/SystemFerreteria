namespace Ferreteria
{
    partial class Frm_Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpfechaN = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbtipodoc = new System.Windows.Forms.ComboBox();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.cbxDispositivo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpfecha = new System.Windows.Forms.DateTimePicker();
            this.Guardar = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.bteditar = new System.Windows.Forms.Button();
            this.Eliminar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcelular = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.labelContador = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pxImagen = new System.Windows.Forms.PictureBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgwProveedor = new System.Windows.Forms.DataGridView();
            this.Nombre_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaNac_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre_TipDoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroDoc_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Correo_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechCreacion_Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foto = new System.Windows.Forms.DataGridViewImageColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnumerodoc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtId_Cliente = new System.Windows.Forms.TextBox();
            this.Estado = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnnormal = new System.Windows.Forms.Button();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnLogo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProveedor)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(832, 670);
            this.panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.dtpfechaN);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cmbtipodoc);
            this.groupBox1.Controls.Add(this.btnWebcam);
            this.groupBox1.Controls.Add(this.cbxDispositivo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpfecha);
            this.groupBox1.Controls.Add(this.Guardar);
            this.groupBox1.Controls.Add(this.Nuevo);
            this.groupBox1.Controls.Add(this.bteditar);
            this.groupBox1.Controls.Add(this.Eliminar);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.rbFemenino);
            this.groupBox1.Controls.Add(this.rbMasculino);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtcorreo);
            this.groupBox1.Controls.Add(this.txtcelular);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.labelContador);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pxImagen);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.dgwProveedor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtnumerodoc);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtId_Cliente);
            this.groupBox1.Controls.Add(this.Estado);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(12, 54);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 604);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.Yellow;
            this.label14.Location = new System.Drawing.Point(32, 380);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 18);
            this.label14.TabIndex = 232;
            this.label14.Text = "Buscar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(21, 181);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 18);
            this.label13.TabIndex = 229;
            this.label13.Text = "Fecha Nacimiento";
            // 
            // dtpfechaN
            // 
            this.dtpfechaN.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfechaN.Location = new System.Drawing.Point(158, 175);
            this.dtpfechaN.Name = "dtpfechaN";
            this.dtpfechaN.Size = new System.Drawing.Size(114, 24);
            this.dtpfechaN.TabIndex = 228;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(20, 121);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 18);
            this.label12.TabIndex = 227;
            this.label12.Text = "Tipo Documento";
            // 
            // cmbtipodoc
            // 
            this.cmbtipodoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbtipodoc.FormattingEnabled = true;
            this.cmbtipodoc.Location = new System.Drawing.Point(158, 113);
            this.cmbtipodoc.Name = "cmbtipodoc";
            this.cmbtipodoc.Size = new System.Drawing.Size(283, 26);
            this.cmbtipodoc.TabIndex = 226;
            // 
            // btnWebcam
            // 
            this.btnWebcam.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWebcam.BackColor = System.Drawing.Color.Maroon;
            this.btnWebcam.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnWebcam.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnWebcam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnWebcam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnWebcam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWebcam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWebcam.ForeColor = System.Drawing.Color.Yellow;
            this.btnWebcam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWebcam.Location = new System.Drawing.Point(524, 365);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(84, 30);
            this.btnWebcam.TabIndex = 225;
            this.btnWebcam.Text = "WebCam";
            this.btnWebcam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWebcam.UseVisualStyleBackColor = false;
            this.btnWebcam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // cbxDispositivo
            // 
            this.cbxDispositivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDispositivo.FormattingEnabled = true;
            this.cbxDispositivo.Location = new System.Drawing.Point(641, 28);
            this.cbxDispositivo.Name = "cbxDispositivo";
            this.cbxDispositivo.Size = new System.Drawing.Size(145, 26);
            this.cbxDispositivo.TabIndex = 223;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(456, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 18);
            this.label6.TabIndex = 219;
            this.label6.Text = "Fecha";
            // 
            // dtpfecha
            // 
            this.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpfecha.Location = new System.Drawing.Point(511, 29);
            this.dtpfecha.Name = "dtpfecha";
            this.dtpfecha.Size = new System.Drawing.Size(114, 24);
            this.dtpfecha.TabIndex = 218;
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
            this.Guardar.Location = new System.Drawing.Point(129, 29);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(100, 30);
            this.Guardar.TabIndex = 217;
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
            this.Nuevo.Location = new System.Drawing.Point(23, 29);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(100, 30);
            this.Nuevo.TabIndex = 216;
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
            this.bteditar.Location = new System.Drawing.Point(235, 28);
            this.bteditar.Name = "bteditar";
            this.bteditar.Size = new System.Drawing.Size(100, 30);
            this.bteditar.TabIndex = 215;
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
            this.Eliminar.Location = new System.Drawing.Point(341, 28);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Size = new System.Drawing.Size(100, 30);
            this.Eliminar.TabIndex = 214;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = false;
            this.Eliminar.Click += new System.EventHandler(this.Eliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(21, 212);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 187;
            this.label11.Text = "Sexo";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(264, 207);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(92, 22);
            this.rbFemenino.TabIndex = 186;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(160, 208);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(94, 22);
            this.rbMasculino.TabIndex = 185;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(20, 285);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 18);
            this.label10.TabIndex = 183;
            this.label10.Text = "Correo";
            // 
            // txtcorreo
            // 
            this.txtcorreo.BackColor = System.Drawing.Color.White;
            this.txtcorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcorreo.Location = new System.Drawing.Point(158, 279);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(283, 24);
            this.txtcorreo.TabIndex = 182;
            // 
            // txtcelular
            // 
            this.txtcelular.BackColor = System.Drawing.Color.White;
            this.txtcelular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcelular.Location = new System.Drawing.Point(319, 241);
            this.txtcelular.Name = "txtcelular";
            this.txtcelular.Size = new System.Drawing.Size(122, 24);
            this.txtcelular.TabIndex = 181;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(259, 244);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 18);
            this.label9.TabIndex = 180;
            this.label9.Text = "Celular";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(21, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 18);
            this.label8.TabIndex = 179;
            this.label8.Text = "Telefono";
            // 
            // txttelefono
            // 
            this.txttelefono.BackColor = System.Drawing.Color.White;
            this.txttelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttelefono.Location = new System.Drawing.Point(158, 241);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(96, 24);
            this.txttelefono.TabIndex = 178;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(356, 377);
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
            this.labelContador.Location = new System.Drawing.Point(411, 375);
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
            this.button2.Location = new System.Drawing.Point(679, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 30);
            this.button2.TabIndex = 174;
            this.button2.Text = "Limpiar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.Cursor = System.Windows.Forms.Cursors.Default;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(611, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 30);
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
            this.pxImagen.Location = new System.Drawing.Point(506, 89);
            this.pxImagen.Name = "pxImagen";
            this.pxImagen.Size = new System.Drawing.Size(280, 260);
            this.pxImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pxImagen.TabIndex = 172;
            this.pxImagen.TabStop = false;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFiltro.Location = new System.Drawing.Point(118, 374);
            this.txtFiltro.MaxLength = 20;
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(228, 24);
            this.txtFiltro.TabIndex = 170;
            this.txtFiltro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFiltro_KeyDown);
            this.txtFiltro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFiltro_KeyPress);
            // 
            // dgwProveedor
            // 
            this.dgwProveedor.AllowUserToAddRows = false;
            this.dgwProveedor.AllowUserToDeleteRows = false;
            this.dgwProveedor.AllowUserToOrderColumns = true;
            this.dgwProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgwProveedor.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwProveedor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwProveedor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgwProveedor.ColumnHeadersHeight = 30;
            this.dgwProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre_Cliente,
            this.Sexo_Cliente,
            this.Direccion_Cliente,
            this.FechaNac_Cliente,
            this.Telefono_Cliente,
            this.Celular_Cliente,
            this.Nombre_TipDoc,
            this.NumeroDoc_Cliente,
            this.Correo_Cliente,
            this.FechCreacion_Cliente,
            this.Foto});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(61)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgwProveedor.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgwProveedor.EnableHeadersVisualStyles = false;
            this.dgwProveedor.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwProveedor.Location = new System.Drawing.Point(18, 414);
            this.dgwProveedor.Name = "dgwProveedor";
            this.dgwProveedor.ReadOnly = true;
            this.dgwProveedor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.PaleVioletRed;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwProveedor.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgwProveedor.Size = new System.Drawing.Size(773, 181);
            this.dgwProveedor.TabIndex = 3;
            this.dgwProveedor.SelectionChanged += new System.EventHandler(this.dgwProveedor_SelectionChanged);
            // 
            // Nombre_Cliente
            // 
            this.Nombre_Cliente.DataPropertyName = "Nombre_Cliente";
            this.Nombre_Cliente.HeaderText = "Cliente";
            this.Nombre_Cliente.MinimumWidth = 20;
            this.Nombre_Cliente.Name = "Nombre_Cliente";
            this.Nombre_Cliente.ReadOnly = true;
            this.Nombre_Cliente.Width = 165;
            // 
            // Sexo_Cliente
            // 
            this.Sexo_Cliente.DataPropertyName = "Sexo_Cliente";
            this.Sexo_Cliente.HeaderText = "Sexo";
            this.Sexo_Cliente.Name = "Sexo_Cliente";
            this.Sexo_Cliente.ReadOnly = true;
            this.Sexo_Cliente.Visible = false;
            // 
            // Direccion_Cliente
            // 
            this.Direccion_Cliente.DataPropertyName = "Direccion_Cliente";
            this.Direccion_Cliente.HeaderText = "Direccion";
            this.Direccion_Cliente.Name = "Direccion_Cliente";
            this.Direccion_Cliente.ReadOnly = true;
            this.Direccion_Cliente.Visible = false;
            // 
            // FechaNac_Cliente
            // 
            this.FechaNac_Cliente.DataPropertyName = "FechaNac_Cliente";
            this.FechaNac_Cliente.HeaderText = "FechaNac";
            this.FechaNac_Cliente.Name = "FechaNac_Cliente";
            this.FechaNac_Cliente.ReadOnly = true;
            this.FechaNac_Cliente.Visible = false;
            // 
            // Telefono_Cliente
            // 
            this.Telefono_Cliente.DataPropertyName = "Telefono_Cliente";
            this.Telefono_Cliente.HeaderText = "Telefono";
            this.Telefono_Cliente.Name = "Telefono_Cliente";
            this.Telefono_Cliente.ReadOnly = true;
            this.Telefono_Cliente.Visible = false;
            // 
            // Celular_Cliente
            // 
            this.Celular_Cliente.DataPropertyName = "Celular_Cliente";
            this.Celular_Cliente.HeaderText = "Celular";
            this.Celular_Cliente.Name = "Celular_Cliente";
            this.Celular_Cliente.ReadOnly = true;
            this.Celular_Cliente.Visible = false;
            // 
            // Nombre_TipDoc
            // 
            this.Nombre_TipDoc.DataPropertyName = "Nombre_TipDoc";
            this.Nombre_TipDoc.HeaderText = "TipoDoc";
            this.Nombre_TipDoc.Name = "Nombre_TipDoc";
            this.Nombre_TipDoc.ReadOnly = true;
            // 
            // NumeroDoc_Cliente
            // 
            this.NumeroDoc_Cliente.DataPropertyName = "NumeroDoc_Cliente";
            this.NumeroDoc_Cliente.HeaderText = " NºDoc";
            this.NumeroDoc_Cliente.Name = "NumeroDoc_Cliente";
            this.NumeroDoc_Cliente.ReadOnly = true;
            this.NumeroDoc_Cliente.Width = 219;
            // 
            // Correo_Cliente
            // 
            this.Correo_Cliente.DataPropertyName = "Correo_Cliente";
            this.Correo_Cliente.HeaderText = "Correo";
            this.Correo_Cliente.MinimumWidth = 20;
            this.Correo_Cliente.Name = "Correo_Cliente";
            this.Correo_Cliente.ReadOnly = true;
            this.Correo_Cliente.Width = 148;
            // 
            // FechCreacion_Cliente
            // 
            this.FechCreacion_Cliente.DataPropertyName = "FechCreacion_Cliente";
            this.FechCreacion_Cliente.HeaderText = "Fecha";
            this.FechCreacion_Cliente.MinimumWidth = 10;
            this.FechCreacion_Cliente.Name = "FechCreacion_Cliente";
            this.FechCreacion_Cliente.ReadOnly = true;
            // 
            // Foto
            // 
            this.Foto.DataPropertyName = "Foto";
            this.Foto.HeaderText = "Foto";
            this.Foto.Name = "Foto";
            this.Foto.ReadOnly = true;
            this.Foto.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(21, 317);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 13;
            this.label5.Text = "Direccion";
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(158, 313);
            this.txtdireccion.Multiline = true;
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtdireccion.Size = new System.Drawing.Size(283, 48);
            this.txtdireccion.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(21, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cliente";
            // 
            // txtcliente
            // 
            this.txtcliente.BackColor = System.Drawing.Color.White;
            this.txtcliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcliente.Location = new System.Drawing.Point(158, 145);
            this.txtcliente.Name = "txtcliente";
            this.txtcliente.Size = new System.Drawing.Size(283, 24);
            this.txtcliente.TabIndex = 10;
            this.txtcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombrecategoria_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(21, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nº Documento";
            // 
            // txtnumerodoc
            // 
            this.txtnumerodoc.BackColor = System.Drawing.Color.White;
            this.txtnumerodoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnumerodoc.Location = new System.Drawing.Point(158, 80);
            this.txtnumerodoc.Name = "txtnumerodoc";
            this.txtnumerodoc.Size = new System.Drawing.Size(177, 24);
            this.txtnumerodoc.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(638, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // txtId_Cliente
            // 
            this.txtId_Cliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.txtId_Cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId_Cliente.Location = new System.Drawing.Point(679, 150);
            this.txtId_Cliente.Name = "txtId_Cliente";
            this.txtId_Cliente.Size = new System.Drawing.Size(75, 24);
            this.txtId_Cliente.TabIndex = 6;
            // 
            // Estado
            // 
            this.Estado.AutoSize = true;
            this.Estado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Estado.ForeColor = System.Drawing.Color.Lime;
            this.Estado.Location = new System.Drawing.Point(587, 62);
            this.Estado.Name = "Estado";
            this.Estado.Size = new System.Drawing.Size(21, 20);
            this.Estado.TabIndex = 224;
            this.Estado.Text = "...";
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
            this.panel2.Size = new System.Drawing.Size(832, 43);
            this.panel2.TabIndex = 0;
            // 
            // btnnormal
            // 
            this.btnnormal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnnormal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnormal.FlatAppearance.BorderSize = 0;
            this.btnnormal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnnormal.Image = ((System.Drawing.Image)(resources.GetObject("btnnormal.Image")));
            this.btnnormal.Location = new System.Drawing.Point(691, 0);
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
            this.btnMinimizar.Location = new System.Drawing.Point(740, 0);
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
            this.btnCerrar.Location = new System.Drawing.Point(789, 1);
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
            this.label1.Location = new System.Drawing.Point(283, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "CATALOGO DE CLIENTE";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 670);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Cliente";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Cliente";
            this.Load += new System.EventHandler(this.Frm_Cliente_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProveedor)).EndInit();
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
        private System.Windows.Forms.TextBox txtcliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnumerodoc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtId_Cliente;
        private System.Windows.Forms.DataGridView dgwProveedor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.PictureBox pxImagen;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelContador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnnormal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtcelular;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Button bteditar;
        private System.Windows.Forms.Button Eliminar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpfecha;
        private System.Windows.Forms.ComboBox cbxDispositivo;
        private System.Windows.Forms.Label Estado;
        private System.Windows.Forms.Button btnWebcam;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbtipodoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpfechaN;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaNac_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_TipDoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroDoc_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Correo_Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechCreacion_Cliente;
        private System.Windows.Forms.DataGridViewImageColumn Foto;
        private System.Windows.Forms.Label label14;
    }
}