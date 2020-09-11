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
using Ferreteria.MenuPrincipal;


namespace Ferreteria
{
    public partial class Frm_Sucursal : Form
    {
        E_usuario u = new E_usuario();
        public Frm_Sucursal(E_usuario User)
        {
            InitializeComponent();
            this.u = User;
        }

        private void LlenarCombos()
        {
            try
            {
                cmbSucursal.ValueMember = "Id_Suc";
                cmbSucursal.DisplayMember = "Direccion_Suc";
                cmbSucursal.DataSource = CN_Sucursal.Instancia.ListaSucursalCombo ();

            }

            catch (Exception)
            {
                throw;
            }

        }


        private void eliminarErrorProvider()
        {
           // errorProvider1.SetError(txtnombrecategoria, "");
           // errorProvider1.SetError(txtcodigocategoria , "");
        }
        private void limpiarForm()
        {
          
          
           
           // pxImagen.Image = null;
        }

        private void habilitarCampos(bool sw)
        {
            
          
            
        }

       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            limpiarForm();
            habilitarCampos(true);

           

        }
     
     

        private void btnguardar_Click(object sender, EventArgs e)
        {


        
            eliminarErrorProvider();
            //if (validarControles())

            ////INSERTAR
            //if (Editar == false)
            //    {
            //        try

               
            //        {
            //            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //            //pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //            byte[] imagen = ms.GetBuffer();

            //           // objetoCN.Insertarcategoria(txtcodigocategoria.Text, txtnombrecategoria.Text, txtdescripcion.Text,1,dtpfecharegistro.Text, imagen );
            //            MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Mostrarcategoria();
            //            limpiarForm();

            //            btneliminar.Enabled = true;
            //           // btnbuscar .Enabled = true;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("No se pudo insertar los datos por: " + ex);
            //        }
            //    }
            //    else
            //        //EDITAR
            //        if (Editar == true)
            //    {
            //        try
            //        {
            //            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            //            //pxImagen.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
            //            byte[] imagen = ms.GetBuffer();

            //           // objetoCN.Editarcategoria (Id_Cat ,txtcodigocategoria.Text  ,txtnombrecategoria.Text  , txtdescripcion .Text ,1,dtpfecharegistro .Text, imagen );
            //            MessageBox.Show("Se edito correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //            Mostrarcategoria();
            //            Editar = false;
            //        }
            //        catch (Exception ex)
            //        {
            //            MessageBox.Show("No se pudo editar los datos por: " + ex);
            //        }
            //    }
            //habilitarCampos(false);
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
           
            habilitarCampos(true);
            //btnguardar .Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
         
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
          
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

        private void dgwcategorias_SelectionChanged(object sender, EventArgs e)
        {


            //sirve para que se cargen en los textbox
            //if (dgwcategorias.SelectedRows.Count > 0)
            //{
            //    DataRowView drv = (DataRowView)dgwcategorias.SelectedRows[0].DataBoundItem;

            //    txtcodigocategoria.Text = drv["Codigo_Cat"].ToString();
            //    txtnombrecategoria.Text = drv["Nombre_Cat"].ToString();
            //    txtdescripcion.Text = drv["Descripcion_Cat"].ToString();
            //    dtpfecharegistro.Text = drv["Fecha"].ToString();
            //    Id_Cat = drv["Id_Cat"].ToString();
            //    byte[] imagenBuffer = (byte[])this.dgwcategorias.CurrentRow.Cells["Imagen"].Value;
            //    // Se crea un MemoryStream a partir de ese buffer  
            //    System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer);
            //    // Se utiliza el MemoryStream para extraer la imagen  
            //    this.pxImagen.Image = Image.FromStream(ms);
            //    this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;

            //    habilitarCampos(false);

            //}
               

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro de eliminar el siguiente registro?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
               // DataRowView drv = (DataRowView)dgwcategorias.SelectedRows[0].DataBoundItem;

                //Id_Cat   = drv["Id_Cat"].ToString();
               // objetoCN.Eliminarcategoria(Id_Cat);
                MessageBox.Show("Eliminado correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                limpiarForm();
            }
            else if (result == DialogResult.No)
            {
                MessageBox.Show("seleccione una fila  por favor", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Frm_Sucursal_Load(object sender, EventArgs e)
        {

            //dgwcategorias.AutoGenerateColumns = false;
          
            limpiarForm();
            LlenarCombos();
            // btnguardar.Enabled = false;
            //labelContador.Text = dgwcategorias.Rows.Count.ToString();
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
                //this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                //pxImagen.Image = Image.FromFile(dialog.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.pxImagen.SizeMode = PictureBoxSizeMode.StretchImage;
            //  this.pxImagen.Image = global::CapaPresentacion.Properties.Resources.premiosya;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            LOCAL.Instancia.Id_Suc = Convert.ToInt32(cmbSucursal.SelectedValue);
            Ferreteria.MenuPrincipal.Menu  menu = new Ferreteria.MenuPrincipal.Menu(u);
            menu.Show();
        }

       

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
