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
namespace Ferreteria
{
    public partial class Frm_Proveedor: Form
    {
        CNProveedor objetoCN = new CNProveedor();
        private string Id_Proveedor = null;
        private bool Editar = false;
        public Frm_Proveedor()
        {
            InitializeComponent();
        }

       
        private void eliminarErrorProvider()
        {
            errorProvider1.SetError(txtRazSocial_Proveedor, "");
            errorProvider1.SetError(txtCod_Proveedor , "");
        }
        private void limpiarForm()
        {
            txtId_Proveedor.Clear();
            txtId_Proveedor.Focus();
            txtCod_Proveedor .Clear();
            txtCod_Proveedor.Focus();
            txtRazSocial_Proveedor.Clear();
            txtRazSocial_Proveedor.Focus();
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
            txtCod_Proveedor.Enabled = true  ;
            txtRazSocial_Proveedor.Enabled = true ;
            txtdireccion.Enabled = true;
            txtcelular.Enabled = true;
            txtcorreo.Enabled = true;
            txttelefono.Enabled = true;
            txtId_Proveedor.Enabled = false;
        }

        private bool validarControles()
        {
            bool ok = true;
            if (txtCod_Proveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCod_Proveedor , "Ingrese el codigo dEL Proveedor");
            }
            else
             if (txtRazSocial_Proveedor.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtRazSocial_Proveedor, "Ingrese el nombre del Proveedor");
            }
            return ok;

        
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            limpiarForm();
            habilitarCampos(true);

            btneliminar .Enabled = false;
            btnbuscar.Enabled = false;
            btnguardado .Enabled = true;
            btneditar .Enabled = false ;

        }
        private void Mostrarcategoria()
        {
            CNProveedor objeto = new CNProveedor();
            string filtro;
            filtro = txtFiltro.Text.Replace("'", "");
            dgwProveedor.DataSource = objeto.listaDeProveedor (filtro);
            labelContador.Text = dgwProveedor.Rows.Count.ToString();
        }
     

        private void btnguardar_Click(object sender, EventArgs e)
        {
                    
          
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            habilitarCampos(true);
            btnguardado.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            Mostrarcategoria();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Mostrarcategoria();
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

                txtCod_Proveedor.Text = drv["Cod_Proveedor"].ToString();
                txtRazSocial_Proveedor.Text = drv["RazSocial_Proveedor"].ToString();
                txtruc.Text = drv["Ruc_Proveedor"].ToString();
                txtdireccion.Text = drv["Direccion_proveedor"].ToString();
                txttelefono .Text = drv["Telefono_Proveedor"].ToString();
                txtcelular .Text = drv["Celular_Proveedor"].ToString();
                txtcorreo.Text = drv["Correo_Proveedor"].ToString();
                Id_Proveedor = drv["Id_Proveedor"].ToString();
                byte[] imagenBuffer = (byte[])this.dgwProveedor.CurrentRow.Cells["Imagen"].Value;
                // Se crea un MemoryStream a partir de ese buffer  
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
                // Se utiliza el MemoryStream para extraer la imagen  
                this.pxImagen.Image = Image.FromStream(ms);
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

                habilitarCampos(false);

            }
               

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el siguiente registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)dgwProveedor.SelectedRows[0].DataBoundItem;

                Id_Proveedor = drv["Id_Proveedor"].ToString();
                objetoCN.EliminarProveedor(Id_Proveedor);
                MessageBox.Show("Eliminado correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Mostrarcategoria();
                limpiarForm();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("seleccione una fila  por favor", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Proveedor_Load(object sender, EventArgs e)
        {

            dgwProveedor.AutoGenerateColumns = false;
            Mostrarcategoria();
            limpiarForm();
            btnguardado.Enabled = false;
            labelContador.Text = dgwProveedor.Rows.Count.ToString();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
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
            eliminarErrorProvider();
            if (validarControles())

                //INSERTAR
                if (Editar == false)
                {
                    try


                    {
                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        objetoCN.InsertarProveedor(txtCod_Proveedor.Text, txtRazSocial_Proveedor.Text, txtruc.Text, txtdireccion.Text, txttelefono.Text, txtcelular.Text, txtcorreo.Text, 1, imagen);
                        MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrarcategoria();
                        limpiarForm();

                        btneliminar.Enabled = true;
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

                        objetoCN.EditarProveedor(Id_Proveedor, txtCod_Proveedor.Text, txtRazSocial_Proveedor.Text, txtruc.Text, txtdireccion.Text, txttelefono.Text, txtcelular.Text, txtcorreo.Text, 1, imagen);
                        MessageBox.Show("Se edito correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Mostrarcategoria();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            habilitarCampos(false);
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
