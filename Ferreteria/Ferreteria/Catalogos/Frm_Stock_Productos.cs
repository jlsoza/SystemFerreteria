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
using Entidades;
namespace Ferreteria
{
    public partial class Frm_Stock_Productos: Form
    {
        CNProveedor objetoCN = new CNProveedor();
        private string Id_Proveedor = null;
        private bool Editar = false;
        public Frm_Stock_Productos()
        {
            InitializeComponent();
        }

      

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      

        private void Frm_Stock_Productos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
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
            

        private void Mostrar()
        {
            this.dataListado.DataSource = CNProducto.Stock_Articulos();
            //this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void spmostrar_detalle_ingresoNombre()
        {
            this.dataListado.DataSource = CN_Ingresos .spmostrar_detalle_ingresoNombre(this.txtBuscar.Text);

        }

        private void spmostrar_detalle_ingresoCodigo()
        {
            this.dataListado.DataSource = CN_Ingresos.spmostrar_detalle_ingresoCodigo(this.txtBuscarCodigo.Text);

        }

        private void chProducto_Nuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (chProducto_Nuevo.Checked == false)
            {
                txtBuscarCodigo.Visible = false;

            }
            else
              if (chProducto_Nuevo.Checked == true)
            {

                txtBuscarCodigo.Visible = true;
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            this.spmostrar_detalle_ingresoNombre();
        }

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {
            this.spmostrar_detalle_ingresoCodigo();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                //LlenarGrid(null);
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
