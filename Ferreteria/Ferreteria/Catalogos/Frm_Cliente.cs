using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapadeNegocio;
using System.IO;
using BarcodeLib;
using AForge.Video;
using AForge.Video.DirectShow;
namespace Ferreteria
{
    public partial class Frm_Cliente: Form
    {
        CN_Cliente objetoCN = new CN_Cliente();
        private string Id_Cliente = null;
        private bool Editar = false;
        public Frm_Cliente()
        {
            
            InitializeComponent();
            if (Estado.Text == "...")
            {
                pxImagen.Image = Properties.Resources.ImgDefecto;
            }
           
            BuscarDispositivos();
        }

       
        private void eliminarErrorProvider()
        {
            errorProvider1.SetError(txtcliente, "");
            errorProvider1.SetError(txtnumerodoc , "");
        }
        private void limpiarForm()
        {
            txtId_Cliente.Clear();
            txtId_Cliente.Focus();
            txtnumerodoc .Clear();
            txtnumerodoc.Focus();
            txtcliente.Clear();
            txtcliente.Focus();
            txtdireccion.Clear();
            txtdireccion.Focus();
            txttelefono.Clear();
            txttelefono.Focus();
            txtcelular.Clear();
            txtcelular.Focus();
            txtcorreo.Clear();
            txtcorreo.Focus();


            pxImagen.Image = null;
        }

        private void habilitarCampos(bool sw)
        {
            txtnumerodoc.Enabled = true  ;
            txtcliente.Enabled = true ;
            txtdireccion.Enabled = true;
            txtcelular.Enabled = true;
            txtcorreo.Enabled = true;
            txttelefono.Enabled = true;
            txtId_Cliente.Enabled = false;
            bteditar.Enabled = true;
        }

        private bool validarControles()
        {
            bool ok = true;
            if (txtnumerodoc.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtnumerodoc , "Ingrese el codigo dEL Proveedor");
            }
            else
             if (txtcliente.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcliente, "Ingrese el nombre del Proveedor");
            }
            return ok;

        
        }
     
        private void MostrarClientes()
        {
            CN_Cliente objeto = new CN_Cliente();
            string filtro;
            filtro = txtFiltro.Text.Replace("'", "");
            dgwProveedor.DataSource = objeto.listaDeCliente (filtro);
            labelContador.Text = dgwProveedor.Rows.Count.ToString();
        }
     
            

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            MostrarClientes();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                MostrarClientes();
        }

        private void txtnombrecategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgwProveedor_SelectionChanged(object sender, EventArgs e)
        {


            //sirve para que se cargen en los textbox
            if (dgwProveedor.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgwProveedor.SelectedRows[0].DataBoundItem;

                txtcliente.Text = drv["Nombre_Cliente"].ToString();
                dtpfechaN.Text = drv["FechaNac_Cliente"].ToString();
                ///Sexo_Cliente = drv["FechaNac_Cliente"].ToString();
                cmbtipodoc.Text = drv["Nombre_TipDoc"].ToString();
                txttelefono.Text = drv["Telefono_Cliente"].ToString();
                txtcelular.Text = drv["Celular_Cliente"].ToString();
                txtdireccion.Text = drv["Direccion_Cliente"].ToString();
                txtnumerodoc.Text = drv["NumeroDoc_Cliente"].ToString();
                txtcorreo .Text = drv["Correo_Cliente"].ToString();
                dtpfecha .Text = drv["FechCreacion_Cliente"].ToString();
                Id_Cliente = drv["Id_Cliente"].ToString();
                byte[] imagenBuffer = (byte[])this.dgwProveedor.CurrentRow.Cells["Foto"].Value;
                // Se crea un MemoryStream a partir de ese buffer  
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
                // Se utiliza el MemoryStream para extraer la imagen  
                this.pxImagen.Image = Image.FromStream(ms);
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                habilitarCampos(false);

            }
               

        }
              

        private void Frm_Cliente_Load(object sender, EventArgs e)
        {
            pxImagen.Image = Ferreteria.Properties.Resources.ImgDefecto;
            dgwProveedor.AutoGenerateColumns = false;
            MostrarClientes();
            limpiarForm();
            LlenarCombos();
            Guardar.Enabled = false;
            labelContador.Text = dgwProveedor.Rows.Count.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            this.Close();
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();

            // Si seleccionó un archivo (asumiendo que es una imagen lo que seleccionó)  
            // la mostramos en el PictureBox de la inferfaz  
            if (result == DialogResult.OK)
            {
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TerminarFuenteDeVideo();
            this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //  this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.premiosya;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void btnguardado_Click(object sender, EventArgs e)
        {
        
        }

        private void LlenarCombos()
        {
            try
            {
                cmbtipodoc.ValueMember = "Id_TipDoc";
                cmbtipodoc.DisplayMember = "Nombre_TipDoc";
                cmbtipodoc.DataSource = CN_TipoDoc.Instancia.ListaTipoDoc();
                                
            }

            catch (Exception)
            {
                throw;
            }

        }


        //CODIGO PARA VER WEBCAM
        private bool ExisteDispositivo = false;
        private FilterInfoCollection DispositivoDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public void Video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            pxImagen.Image = Imagen;
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }
        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++) ;

            cbxDispositivo.Items.Add(Dispositivos[0].Name.ToString());
            cbxDispositivo.Text = cbxDispositivo.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivoDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivoDeVideo.Count == 0)
            {
                ExisteDispositivo = false;
            }
            else
            {
                ExisteDispositivo = true;
                CargarDispositivos(DispositivoDeVideo);
            }
        }
         private void btnWebcam_Click(object sender, EventArgs e)
        {
            if (btnWebcam.Text == "WebCam")
            {
                if (ExisteDispositivo)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivoDeVideo[cbxDispositivo.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(Video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = "Ejecutando Dispositivo…";
                    btnWebcam.Text = "Capturar";
                    cbxDispositivo.Enabled = false;
                }
                else

                {
                    Estado.Text = "No Hay Camaras Conectadas";
                    pxImagen.Image = Ferreteria.Properties.Resources.ImgDefecto;
                }

            }

            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = "Dispositivo Detenido…";
                    // btniniciar.Text = "Iniciar";
                    btnWebcam.Text = "WebCam";
                    cbxDispositivo.Enabled = true;
                }
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            if (validarControles())

                //INSERTAR
                if (Editar == false)
                {
                    try


                    {

                        int TipoDoc;
                        TipoDoc = Convert.ToInt32(cmbtipodoc.SelectedValue);
                        string Sexo_Cliente;
                        if (rbMasculino.Checked == true) Sexo_Cliente = "M"; else Sexo_Cliente = "F";

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        objetoCN.Insertarcliente(TipoDoc, txtnumerodoc.Text, txtcliente.Text, dtpfechaN.Text, Sexo_Cliente,
                        txttelefono.Text, txtcelular.Text, txtcorreo.Text,txtdireccion.Text,1,dtpfecha.Text, imagen);
                        MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClientes();
                        limpiarForm();

                        Eliminar.Enabled = true;
                        btnbuscar.Enabled = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo insertar los datos por: " + ex);
                    }
                }
                else
                        //EDITAR
                        if (Editar == true)
                {
                    try
                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        // objetoCN.EditarProveedor(Id_Proveedor, txtnumerodoc.Text, txtcliente.Text, txtruc.Text, txtdireccion.Text, txttelefono.Text, txtcelular.Text, txtcorreo.Text, 1, imagen);
                        MessageBox.Show("Se edito correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarClientes();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            habilitarCampos(false);
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el siguiente registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)dgwProveedor.SelectedRows[0].DataBoundItem;

                Id_Cliente = drv["Id_Cliente"].ToString();
                objetoCN.Eliminarcliente(Id_Cliente);
                MessageBox.Show("Eliminado correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarClientes();
                limpiarForm();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("seleccione una fila  por favor", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            habilitarCampos(true);
            Guardar.Enabled = true;
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            limpiarForm();
            habilitarCampos(true);

            Eliminar.Enabled = false;
            btnbuscar.Enabled = false;
            Guardar.Enabled = true;
            bteditar.Enabled = false;
        }

        private void btnguardar_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
