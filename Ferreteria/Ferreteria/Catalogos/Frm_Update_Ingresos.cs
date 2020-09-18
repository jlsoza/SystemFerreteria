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
    public partial class Frm_Update_Ingresos: Form
    {
        CNProveedor objetoCN = new CNProveedor();
        private string Id_Proveedor = null;
        private bool Editar = false;
        public Frm_Update_Ingresos()
        {
            InitializeComponent();
        }

      

       

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      

        private void Frm_Update_Ingresos_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;

            this.spmostrar_detalle_ingresoymodificar();

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
            

   

        

       

      

        private void txtBuscarCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtstockinicial_TextChanged(object sender, EventArgs e)
        {

        }

        private void chProducto_CheckedChanged(object sender, EventArgs e)
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

        private void spmostrar_detalle_ingresoCodigo()
        {
            this.dataListadoDetalleIngreso.DataSource = CN_Ingresos.spmostrar_detalle_ingresoCodigo(this.txtBuscarCodigo.Text);

        }

        private void txtBuscarCodigo_TextChanged_1(object sender, EventArgs e)
        {
            this.spmostrar_detalle_ingresoCodigo();
        }

        private void spmostrar_detalle_ingresoNombre()
        {
            this.dataListadoDetalleIngreso.DataSource = CN_Ingresos.spmostrar_detalle_ingresoNombre(this.txtBuscar.Text);

        }
        private void txtBuscar_TextChanged_1(object sender, EventArgs e)
        {
            this.spmostrar_detalle_ingresoNombre();
        }

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double total = 0;
            foreach (DataGridViewRow row in dataListadoDetalleIngreso.Rows)
                if (Convert.ToInt32(txtiddetalle_ingreso.Text) == Convert.ToInt32(row.Cells["iddetalle_ingreso"].Value))
                {

                    total = (Convert.ToDouble(row.Cells["stock_inicial"].Value) - Convert.ToDouble(row.Cells["stock_actual"].Value));
                }
            txtvendidas.Text = Convert.ToString(total);
        }

        private void dataListadoDetalleIngreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)

            {
                DataGridViewRow row = dataListadoDetalleIngreso.Rows[e.RowIndex];
                txtArticulo.Text = row.Cells["Nombre_Prod"].Value.ToString();
                txtPrecioCompra .Text = row.Cells["precio_compra"].Value.ToString();
                txtPrecioventa .Text = row.Cells["precio_venta"].Value.ToString();
                txtiddetalle_ingreso.Text = row.Cells["iddetalle_ingreso"].Value.ToString();
                dtFecha_Produccion.Text = row.Cells["fecha_produccion"].Value.ToString();
                dtFecha_Vencimiento.Text = row.Cells["fecha_vencimiento"].Value.ToString();
                txtstockinicial .Text = row.Cells["stock_inicial"].Value.ToString();
                txtstockactual .Text = row.Cells["stock_actual"].Value.ToString();
                btnsuma_Click(new Object(), new EventArgs());

            }
        }
        private void speditar_detallesingreso()
        {

            this.dataListadoDetalleIngreso.DataSource = CN_Ingresos .speditar_detallesingreso(Convert.ToInt32(this.txtiddetalle_ingreso.Text), Convert.ToDecimal(this.txtPrecioCompra .Text), Convert.ToDecimal(this.txtPrecioventa .Text), Convert.ToDateTime(this.dtFecha_Vencimiento.Text), Convert.ToInt32(this.txtstockinicial .Text), Convert.ToInt32(this.txtstockactual .Text));
        }

        private void spmostrar_detalle_ingresoymodificar()
        {
            this.dataListadoDetalleIngreso.DataSource = CN_Ingresos.spmostrar_detalle_ingresoymodificar();

        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtiddetalle_ingreso.Text == string.Empty)
            {
                MessageBox.Show("Selecciona un Producto `para modificar");
                return;
            }
            else
            this.speditar_detallesingreso();
            this.spmostrar_detalle_ingresoymodificar();
            txtArticulo.Text = string.Empty;
            txtPrecioCompra .Text = string.Empty;
            txtPrecioventa .Text = string.Empty;
            txtiddetalle_ingreso.Text = string.Empty;
            txtstockinicial .Text = string.Empty;
            txtvendidas.Text = string.Empty;
            txtstockactual .Text = string.Empty;
            dtFecha_Produccion.Text = string.Empty;
            dtFecha_Vencimiento.Text = string.Empty;
            this.spmostrar_detalle_ingresoCodigo();
            this.spmostrar_detalle_ingresoNombre();
        }

        private void txtstockinicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrecioventa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtstockactual_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtBuscarCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.spmostrar_detalle_ingresoCodigo();
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.spmostrar_detalle_ingresoNombre();
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
