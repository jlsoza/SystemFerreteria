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
namespace Ferreteria
{
    public partial class Frm_ClienteVenta : Form
    {
        int id_Usario = 0;

        public Frm_ClienteVenta(int? idUs)
        {
            InitializeComponent();
            this.id_Usario = (int)idUs;
        }

         
     

   
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void CrearGrid()
        {
            try
            {
                dgvCliente.Columns.Add("ColumnId", "Id");
                dgvCliente.Columns.Add("ColumnNro", "#");
                dgvCliente.Columns.Add("ColumnNombre", "Nombre/Raz.Social");
                dgvCliente.Columns.Add("ColumnTipoDoc", "Tipo Doc.");
                dgvCliente.Columns.Add("ColumnNroDoc", "Número Documento");
                dgvCliente.Columns.Add("ColumnTelefono", "Teléfono");
                dgvCliente.Columns.Add("ColumnCelular", "Celular");
                dgvCliente.Columns.Add("ColumnCorreo", "Correo");
                dgvCliente.Columns.Add("ColumnDireccion", "Dirección");


                dgvCliente.Columns[0].Visible = false;
                dgvCliente.Columns[1].Width = 70;
                dgvCliente.Columns[2].Width = 500;
                dgvCliente.Columns[3].Width = 150;
                dgvCliente.Columns[4].Width = 150;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvCliente.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvCliente.AllowUserToAddRows = false;
                dgvCliente.MultiSelect = false;
                dgvCliente.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Frm_ClienteVenta_Load(object sender, EventArgs e)
        {


            try
            {
                CrearGrid();
                // LlenarGrid();
                
                txtNomRazSocial.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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
        Int32 idUsuario;
        // variable globar captura estado o que tipo de busqueda dse estara realizando
        int tip_busqueda = 0;
      

      

      
        

       

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                int id_cli = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                // frmBoletaVenta frmbv = new frmBoletaVenta(this.idUsuario);
                LOCAL.Instancia.ReturnIdCliente(1, id_cli);
                int frminvocador = LOCAL.Instancia.Invocar(0, 0);
                if (frminvocador == 1)
                {
                    LOCAL.Instancia.ReturnIdCliente(1, id_cli);
                }
                else if (frminvocador == 2)
                {
                    LOCAL.Instancia.ReturnIdClienteNV(1, id_cli);
                }
                else
                {
                    LOCAL.Instancia.Invocar(1, 0);
                }
                this.Close();
                ////frmbv.txtidcli.Text = id_cli.ToString();
                //foreach (Form frm in Application.OpenForms)
                //{
                //    if (frm.GetType() == typeof(frmBoletaVenta))
                //    {
                //        frm.Show();
                //        this.Visible=false;
                //        return;
                //    }
                //}
                //frmbv.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
      
        private void chkBuscar_CheckedChanged(object sender, EventArgs e)
        {
          
            if (chkBuscar.CheckState == CheckState.Checked)
            {
                txtNroDoc.Enabled = false; btnBuscar.Enabled = false; txtNomRazSocial.Enabled = true; dgvCliente.Rows.Clear();
            }
            else { txtNroDoc.Enabled = true; btnBuscar.Enabled = true; txtNomRazSocial.Enabled = false; }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                E_cliente  c = new E_cliente();
                String Nro_doc = txtNroDoc.Text;
                c = CN_Cliente .Intancia.BuscarCliente(0, Nro_doc);
                dgvCliente.Rows.Clear();
                String[] fila = new String[] {c.Id_Cliente.ToString(),1.ToString(),c.Nombre_Cliente,
                    c.tipodocumento.Nombre_TipDoc,c.NumeroDoc_Cliente,c.Telefono_Cliente,c.Celular_Cliente,
                    c.Correo_Cliente,c.Direccion_Cliente};
                dgvCliente.Rows.Add(fila);
            }
            catch (ApplicationException ae)
            {
                MessageBox.Show(ae.Message, "Información", MessageBoxButtons.OK,
MessageBoxIcon.Information); dgvCliente.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LlenarGrid()
        {
            try
            {
                int num = 0;
                dgvCliente.Rows.Clear();
                List<E_cliente > Lista = CN_Cliente .Intancia.ListarCliente();
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new String[] {Lista[i].Id_Cliente.ToString(),num.ToString(),Lista[i].Nombre_Cliente,
                    Lista[i].tipodocumento.Nombre_TipDoc,Lista[i].NumeroDoc_Cliente,Lista[i].Telefono_Cliente,Lista[i].Celular_Cliente,
                    Lista[i].Correo_Cliente,Lista[i].Direccion_Cliente};
                    dgvCliente.Rows.Add(fila);
                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception)
            {

                throw;
            }
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvCliente.Rows.Count > 0)
                {
                    int idCli = Convert.ToInt32(dgvCliente.CurrentRow.Cells[0].Value);
                    LlenarGrid();
                    foreach (DataGridViewRow fila in dgvCliente.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells[0].Value) == idCli)
                        {
                            fila.Selected = true;
                            return;
                        }
                    }
                }
                else LlenarGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        E_usuario u = new E_usuario();
      

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
