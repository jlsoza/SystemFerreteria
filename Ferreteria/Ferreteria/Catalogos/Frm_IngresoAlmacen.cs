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

namespace Ferreteria
{
    public partial class Frm_IngresoAlmacen: Form
    {
             

        CNProducto objetoCN = new CNProducto();
        private string Id_Prod = null;
        private bool Editar = false;
        public Frm_IngresoAlmacen()
        {
            InitializeComponent();
        }

       
        private void eliminarErrorProvider()
        {
            errorProvider1.SetError(txtproducto, "");
          //  errorProvider1.SetError(txtCodigo_Prod , "");
        }
        private void limpiarForm()
        {
          
            txtproducto.Clear();
            txtproducto.Focus();
          
            txtPrecioCompra.Text = "0,00";
            txtPrecioproducto.Text = "0,00";
            txtStock.Text ="0";
         
          
            cboProveedor.Text = "Seleccione un Proveedor";
           
          
          
        }

        private void habilitarCampos(bool sw)
        {
            txtId_Prod.Enabled = false;
           
            txtproducto.Enabled = true;
           
            txtPrecioCompra.Enabled = true;
            txtPrecioproducto.Enabled = true;
            txtStock.Enabled = true;
            
          
            cboProveedor.Enabled = true;
           
            
          
            Guardar.Enabled = true;
         
          
        }

        
              
        
     
        private void LlenarCombos()
        {
            try
            {
                

            

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
               
           



        

        private void btneliminar_Click(object sender, EventArgs e)
        {
           
        }
       

      
        private void Frm_IngresoAlmacen_Load(object sender, EventArgs e)
        {
            

           
            limpiarForm();
            LlenarCombos();
            MostrarProducto();
            Guardar.Enabled = false;
           
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                   

                }
                catch (Exception)
                {

                    MessageBox.Show("No se pudop genrar el codigo de barra", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                

            }


    }

        private void Guardar_Click(object sender, EventArgs e)
        {
            //eliminarErrorProvider();
            //if (validarControles())

            //    //INSERTAR
            //    if (Editar == false)
            //    {
            //        try

              
            //        {
                       
            //            decimal PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            //            decimal Precioproducto = Convert.ToDecimal(txtPrecioproducto.Text);
            //            int Stock = Convert.ToInt32(txtStock.Text);
            //            int StockPromedio = Convert.ToInt32(txtStockPromedio.Text);
            //            int StockMin = Convert.ToInt32(txtStockMin.Text);

            //            int Categoria;
            //            Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
            //            int Proveedor;
            //            Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);

            //            int UnidadMedida;
            //            UnidadMedida = Convert.ToInt32(cboUnidMed.SelectedValue);

            //            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //            //pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //            //byte[] imagen = ms.GetBuffer();


                      

                      

            //            //objetoCN.InsertarProducto(txtCodigo_Prod.Text, txtproducto.Text, Categoria, UnidadMedida, Proveedor, txtmarca.Text 
            //            //,PrecioCompra , Precioproducto, Stock, StockPromedio, StockMin, dtpfecha.Text  ,1, CodigoBarra, imagen);
            //            //MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //MostrarProducto();
            //            //limpiarForm();

                       
            //            btnbuscar.Enabled = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("No se pudo insertar los datos por: " + ex);
            //        }
            //    }
            //    else
            //            //EDITAR
            //            if (Editar == true)
            //    {
            //        try
            //        {

            //            decimal PrecioCompra = Convert.ToDecimal(txtPrecioCompra.Text);
            //            decimal Precioproducto = Convert.ToDecimal(txtPrecioproducto.Text);
            //            int Stock = Convert.ToInt32(txtStock.Text);
            //            int StockPromedio = Convert.ToInt32(txtStockPromedio.Text);
            //            int StockMin = Convert.ToInt32(txtStockMin.Text);

            //            int Categoria;
            //            Categoria = Convert.ToInt32(cboCategoria.SelectedValue);
            //            int Proveedor;
            //            Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);

            //            int UnidadMedida;
            //            UnidadMedida = Convert.ToInt32(cboUnidMed.SelectedValue);



            //            //System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //            //pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //            //byte[] imagen = ms.GetBuffer();

                      

            //            //objetoCN.EditarProducto(Id_Prod, txtCodigo_Prod.Text, txtproducto.Text, Categoria, UnidadMedida, Proveedor, txtmarca.Text
            //            //, PrecioCompra, Precioproducto, Stock, StockPromedio, StockMin, dtpfecha.Text, 1,  CodigoBarra, imagen);
            //            //MessageBox.Show("Se edito correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            //MostrarProducto();
            //            Editar = false;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("No se pudo editar los datos por: " + ex);
            //        }
            //    }
            //habilitarCampos(false);
        }

        private void bteditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            habilitarCampos(true);
            Guardar.Enabled = true;
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            //DialogResult result = MessageBox.Show("¿Está seguro de eliminar el siguiente registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            //if (result == DialogResult.Yes)
            //{
            //    DataRowView drv = (DataRowView)dgwProducto.SelectedRows[0].DataBoundItem;

            //    Id_Prod = drv["Id_Prod"].ToString();
            //    objetoCN.EliminarProducto(Id_Prod);
            //    MessageBox.Show("Eliminado correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    MostrarProducto();
            //    limpiarForm();
            //}
            //else if (result == DialogResult.No)
            //{
            //    MessageBox.Show("seleccione una fila  por favor", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
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
