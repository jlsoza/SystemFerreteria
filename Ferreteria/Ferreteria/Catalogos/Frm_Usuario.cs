using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
using Entidades;
namespace Ferreteria
{
    public partial class Frm_Usuario: Form
    {
        CN_Usuario  objetoCN = new CN_Usuario();
        private string Id_Usuario = null;
        private bool Editar = false;
        public Frm_Usuario()
        {
           
            InitializeComponent();
                 
            
        }

       
        private void eliminarErrorProvider()
        {
            errorProvider1.SetError(txtusuario, "");
            errorProvider1.SetError(txtcodigousuario , "");
        }
        private void limpiarForm()
        {
            txtId_Usuario.Clear();
            txtId_Usuario.Focus();
            txtcodigousuario .Clear();
            txtcodigousuario.Focus();
            txtusuario.Clear();
            txtusuario.Focus();
          
            txttelefono.Clear();
            txttelefono.Focus();
            txtcelular.Clear();
            txtcelular.Focus();
            txtcorreo.Clear();
            txtcorreo.Focus();


           
        }

        private void habilitarCampos(bool sw)
        {
            txtcodigousuario.Enabled = true  ;
            txtusuario.Enabled = true ;
           
            txtcelular.Enabled = true;
            txtcorreo.Enabled = true;
            txttelefono.Enabled = true;
            txtId_Usuario.Enabled = false;
            bteditar.Enabled = true;
        }

        private bool validarControles()
        {
            bool ok = true;
            if (txtcodigousuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtcodigousuario , "Ingrese el codigo dEL Proveedor");
            }
            else
             if (txtusuario.Text == "")
            {
                ok = false;
                errorProvider1.SetError(txtusuario, "Ingrese el nombre del Proveedor");
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

                txtusuario.Text = drv["Nombre_Cliente"].ToString();
               // dtpfechaN.Text = drv["FechaNac_Cliente"].ToString();
                ///Sexo_Cliente = drv["FechaNac_Cliente"].ToString();
                cmbNivelAcceso.Text = drv["Nombre_TipDoc"].ToString();
                txttelefono.Text = drv["Telefono_Cliente"].ToString();
                txtcelular.Text = drv["Celular_Cliente"].ToString();
               
                txtcodigousuario.Text = drv["NumeroDoc_Cliente"].ToString();
                txtcorreo .Text = drv["Correo_Cliente"].ToString();
                dtpfecha .Text = drv["FechCreacion_Cliente"].ToString();
                Id_Usuario  = drv["Id_Usuario"].ToString();
              

                habilitarCampos(false);

            }
               

        }
              

        private void Frm_Usuario_Load(object sender, EventArgs e)
        {


           /// this.leer_datos("Select *  from Tbl_Cliente")
          
           
            dgwProveedor.AutoGenerateColumns = false;
            MostrarClientes();
            limpiarForm();
            LlenarCombos();
            Guardar.Enabled = false;
            labelContador.Text = dgwProveedor.Rows.Count.ToString();
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

        private void btnguardado_Click(object sender, EventArgs e)
        {
        
        }

        private void LlenarCombos()
        {
            try
            {
                cmbNivelAcceso.ValueMember = "Id_NivelAcc";
                cmbNivelAcceso.DisplayMember = "Descripcion_NivelAcc";
                cmbNivelAcceso.DataSource = CN_NivelAcceso.Instancia.ListaNivelAcceso ();

                cmbsucursal .ValueMember = "Id_Suc";
                cmbsucursal.DisplayMember = "Direccion_Suc";
                cmbsucursal.DataSource = CN_Sucursal .Instancia.ListaSucursalCombo  ();

            }

            catch (Exception)
            {
                throw;
            }

        }
           
       
        public void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            SqlConnection cn = ConexionBD.Instancia.Conectar();
            SqlCommand CMD = new SqlCommand(query, cn);
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(CMD);
            da.Fill(dstprincipal, tabla);
            da.Dispose();
            cn.Close();

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
                        string Expiracion_Usuario;
                        Expiracion_Usuario = dtpfechaexpiracion.Value.ToString("dd/MM/yyyy");

                        string Fecha;
                        Fecha = dtpfecha .Value.ToString("dd/MM/yyyy");

                        int NivelAcceso;
                        NivelAcceso = Convert.ToInt32(cmbNivelAcceso.SelectedValue);
                        int Sucursal;
                        Sucursal = Convert.ToInt32(cmbsucursal .SelectedValue);

                        Boolean Estado_Usuario;
                       // if (rbMasculino.Checked == true) Sexo_Cliente = "M"; else Sexo_Cliente = "F";
                        if (rbActivo.Checked == true) Estado_Usuario = true;
                        else  Estado_Usuario = false;
                        objetoCN.InsertarUsuario (txtcodigousuario.Text  , NivelAcceso, Sucursal, txtusuario .Text, txtloginusuario .Text, txtcontrasena .Text ,
                        txttelefono.Text, txtcelular.Text, txtcorreo.Text, Estado_Usuario , Expiracion_Usuario, Fecha);
                        timer1.Stop();
                        MessageBox.Show("Se inserto correctamente", "Proceso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //MostrarClientes();
                        limpiarForm();

                        Eliminar.Enabled = true;
                       
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

                      
                        string Expiracion_Usuario;
                        Expiracion_Usuario = dtpfechaexpiracion.Value.ToString("yyyy/MM/dd");

                        string Fecha;
                        Fecha = dtpfecha.Value.ToString("yyyy/MM/dd");

                        int NivelAcceso;
                        NivelAcceso = Convert.ToInt32(cmbNivelAcceso.SelectedValue);
                        int Sucursal;
                        Sucursal = Convert.ToInt32(cmbsucursal.SelectedValue);
                        bool Estado_Usuario;
                        // if (rbMasculino.Checked == true) Sexo_Cliente = "M"; else Sexo_Cliente = "F";
                        if (rbActivo.Checked == true) Estado_Usuario = true;
                        else Estado_Usuario = false;

                        objetoCN.Editarusuario (Id_Usuario,txtcodigousuario.Text, NivelAcceso, Sucursal, txtusuario.Text, txtloginusuario.Text, txtcontrasena.Text,
                        txttelefono.Text, txtcelular.Text, txtcorreo.Text, Estado_Usuario, Expiracion_Usuario, Fecha);
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

                Id_Usuario = drv["Id_Usuario"].ToString();
                objetoCN.Eliminarusuario (Id_Usuario);
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
          
            Guardar.Enabled = true;
            bteditar.Enabled = false;
        }

       

        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            MostrarClientes();
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
