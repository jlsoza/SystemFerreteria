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
using Entidades;
using System.Drawing.Imaging;
using iTextSharp.text.pdf;
using System.Windows.Media;
using System.Resources;
using Ferreteria.Properties;
using Entidades;

namespace Ferreteria
{
    public partial class Frm_Producto: Form
    {
        Int32 idUsuario;

        CNProducto objetoCN = new CNProducto();
        private string Id_Prod = null;
        private bool Editar = false;
        public Frm_Producto(Int32? id_Usuario)
        {
            InitializeComponent();
            idUsuario = (Int32)id_Usuario;
        }

       
        private void eliminarErrorProvider()
        {
            errorProvider1.SetError(txtproducto, "");
            errorProvider1.SetError(txtCodigo_Prod , "");
        }
        private void limpiarForm()
        {
            txtCodigo_Prod.Clear();
            txtCodigo_Prod.Focus();
            txtproducto.Clear();
            txtproducto.Focus();
            txtmarca.Clear();
            txtmarca.Focus();
            cboCategoria.Text = "Seleccione una Categoria";
            cboProveedor.Text = "Seleccione un Proveedor";
            cboUnidMed.Text = "Seleccione una Unidad de Medida";
            PCTCodigoBarra.Image = null;
            pxImagen.Image = null;
        }

        private void habilitarCampos(bool sw)
        {
            txtId_Prod.Enabled = false;
            txtCodigo_Prod.Enabled = true;
            txtproducto.Enabled = true;
            txtmarca.Enabled = true;
            cboCategoria.Enabled = true;
            cboProveedor.Enabled = true;
            cboUnidMed.Enabled = true;
            PCTCodigoBarra.Enabled = true;
            pxImagen.Enabled = true;
            Guardar.Enabled = true;
            bteditar.Enabled = false;
            btneliminar.Enabled = false;
        }

        private bool validarControles()
        {
            bool ok = true;
            if (txtCodigo_Prod.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtCodigo_Prod , "Ingrese el codigo dEL Proveedor");
            }
            else
             if (txtproducto.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtproducto, "Ingrese el nombre del Proveedor");
            }
            return ok;

        
        }
              
        
     
        private void LlenarCombos()
        {
            try
            {
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Nombre_Cat";
                cboCategoria.DataSource = CNProducto.Instancia.ListaCategoria();

                cboUnidMed.ValueMember = "Id_Umed";
                cboUnidMed.DisplayMember = "Descripcion_Umed";
                cboUnidMed.DataSource = CN_UnidadM.Instancia.ListaUnidadMed();

                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DisplayMember = "RazSocial_Proveedor";
                cboProveedor.DataSource = CNProveedor.Instancia.ListaProveedor();
            }

            catch (Exception)
            {
                throw;
            }

        }
        private void MostrarProducto()
        {
            CNProducto objeto = new CNProducto();
            string filtro;
            filtro = txtFiltro.Text.Replace("'", "");
            dgwProducto.DataSource = objeto.listaDeProducto (filtro);
            labelContador.Text = dgwProducto.Rows.Count.ToString();
        }
                  
               
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            MostrarProducto();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                MostrarProducto();
        }
               
           



        private void dgwProducto_SelectionChanged(object sender, EventArgs e)
        {

            //sirve para que se cargen en los textbox
            if (dgwProducto.SelectedRows.Count > 0)
            {
                DataRowView drv = (DataRowView)dgwProducto.SelectedRows[0].DataBoundItem;

                //int Categoria;
                //Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                //int Proveedor;
                //Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);

                //int UnidadMedida;
                //UnidadMedida = Convert.ToInt32(cboUnidMed.SelectedValue);

               
                txtCodigo_Prod.Text = drv["Codigo_Prod"].ToString();
                txtproducto.Text = drv["Nombre_Prod"].ToString();
                txtmarca.Text = drv["Marca_Prod"].ToString();
                dtpfecha.Text = drv["FechCreacion_Prod"].ToString();
              
                Id_Prod = drv["Id_Prod"].ToString();

                           

                byte[] imagenBuffer = (byte[])this.dgwProducto.CurrentRow.Cells["Imagen"].Value;
                // Se crea un MemoryStream a partir de ese buffer  
                System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
                // Se utiliza el MemoryStream para extraer la imagen  
                this.pxImagen.Image = Image.FromStream(ms);
                this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;


                byte[] imagenBuffer1 = (byte[])this.dgwProducto.CurrentRow.Cells["CodigoBarra"].Value;
                //// Se crea un MemoryStream a partir de ese buffer  
                System.IO.MemoryStream ms1 = new System.IO.MemoryStream(imagenBuffer1);
                //// Se utiliza el MemoryStream para extraer la imagen  
                this.PCTCodigoBarra.Image = Image.FromStream(ms1);
                this.PCTCodigoBarra.SizeMode = PictureBoxSizeMode.StretchImage;

                //// habilitarCampos(false);
                bteditar.Enabled = true;
            }
               

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }
       

      
        private void Frm_Producto_Load(object sender, EventArgs e)
        {
            

            dgwProducto.AutoGenerateColumns = false;
            limpiarForm();
            LlenarCombos();
            MostrarProducto();
            Guardar.Enabled = false;
            labelContador.Text = dgwProducto.Rows.Count.ToString();
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
             

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

              

        private void txtCodigo_Prod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)

            {
                Barcode128 bcode = new Barcode128();
                bcode.BarHeight = 50;
                bcode.Code = txtCodigo_Prod.Text;
                bcode.GenerateChecksum = true;
                bcode.CodeType = Barcode.CODE128;
             //   PCTCodigoBarra.BackgroundImage = bcode.Encode(BarcodeLib.TYPE.CODE128, txtCodigo_Prod.Text, Color.Black, Color.White, 400, 100);

                try
                {
                    Bitmap bm =  new Bitmap(bcode.CreateDrawingImage(System.Drawing.Color.Black, System.Drawing.Color.White));
                    Image img;
                    img = new Bitmap(bm.Width, bm.Height);
                    Graphics G = Graphics.FromImage(img);
                    G.FillRectangle(new SolidBrush(System.Drawing.Color.White), 0, 0, bm.Width, bm.Height);
                    G.DrawImage(bm, 0, 0);
                    PCTCodigoBarra.Image = img;

                }
                catch (Exception)
                {

                    MessageBox.Show("No se pudop genrar el codigo de barra", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                       
                       
                        int Categoria;
                        Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                        int Proveedor;
                        Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);

                        int UnidadMedida;
                        UnidadMedida = Convert.ToInt32(cboUnidMed.SelectedValue);

                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();


                        E_Producto p = new E_Producto();
                        p.UsuarioCreacion_Prod = idUsuario;
                        p.UsuarioUpdate_Prod = idUsuario;

                        System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                        PCTCodigoBarra.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] CodigoBarra = ms1.GetBuffer();

                        objetoCN.InsertarProducto(txtCodigo_Prod.Text, txtproducto.Text, Categoria, UnidadMedida, Proveedor, txtmarca.Text ,
                         dtpfecha.Text  ,1, CodigoBarra, imagen, idUsuario , idUsuario );
                        MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarProducto();
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

                                              

                        int Categoria;
                        Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
                        int Proveedor;
                        Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);

                        int UnidadMedida;
                        UnidadMedida = Convert.ToInt32(cboUnidMed.SelectedValue);

                        E_Producto p = new E_Producto();
                        p.UsuarioUpdate_Prod = idUsuario;


                        System.IO.MemoryStream ms = new System.IO.MemoryStream();
                        pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] imagen = ms.GetBuffer();

                        System.IO.MemoryStream ms1 = new System.IO.MemoryStream();
                        PCTCodigoBarra.Image.Save(ms1, System.Drawing.Imaging.ImageFormat.Png);
                        byte[] CodigoBarra = ms1.GetBuffer();

                        objetoCN.EditarProducto(Id_Prod, txtCodigo_Prod.Text, txtproducto.Text, Categoria, UnidadMedida, Proveedor, txtmarca.Text
                        , dtpfecha.Text, 1,  CodigoBarra, imagen, idUsuario);
                        MessageBox.Show("Se edito correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        MostrarProducto();
                        Editar = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo editar los datos por: " + ex);
                    }
                }
            habilitarCampos(false);
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            habilitarCampos(true);
            Guardar.Enabled = true;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el siguiente registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                DataRowView drv = (DataRowView)dgwProducto.SelectedRows[0].DataBoundItem;

                Id_Prod = drv["Id_Prod"].ToString();
                objetoCN.EliminarProducto(Id_Prod);
                MessageBox.Show("Eliminado correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MostrarProducto();
                limpiarForm();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("seleccione una fila  por favor", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            limpiarForm();
            habilitarCampos(true);
        }

        
        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
