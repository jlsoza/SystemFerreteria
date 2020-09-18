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
    public partial class Frm_Venta: Form
    {
        E_usuario  us = null;
        int id_user = 0;
        // int id_cliente = 0; // id_producto = 0;
        String ser, corr;
        E_Serie  serie = new E_Serie();
        AccionesEnControles ac = new AccionesEnControles();
        public Frm_Venta(int id_user)
        {
            InitializeComponent();
            this.id_user = id_user;
        }

        private void ControlBotones(Boolean nuevo, Boolean guardar, Boolean imprimir, Boolean quitaritem)
        {
            try
            {
                btnNuevo.Enabled = nuevo;
                btnGuardar.Enabled = guardar;
               // btnImprimir.Enabled = imprimir;
                btnQuitarItem.Enabled = quitaritem;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CrearGrid()
        {
            try
            {
                dgvDetalleBoleta.Columns.Add("ColumnIdProd", "Idprod");
                dgvDetalleBoleta.Columns.Add("ColumnNombreProd", "Producto");
                dgvDetalleBoleta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvDetalleBoleta.Columns.Add("ColumnPrecio", "Precio");
                dgvDetalleBoleta.Columns.Add("ColumnTotal", "Total");

                dgvDetalleBoleta.Columns[0].Visible = false;
                dgvDetalleBoleta.Columns[1].Width = 315;
                dgvDetalleBoleta.Columns[2].Width = 70;
                dgvDetalleBoleta.Columns[3].Width = 70;
                dgvDetalleBoleta.Columns[4].Width = 70;

                dgvDetalleBoleta.Columns[1].ReadOnly = true;
                dgvDetalleBoleta.Columns[2].ReadOnly = false;
                dgvDetalleBoleta.Columns[3].ReadOnly = false;
                dgvDetalleBoleta.Columns[4].ReadOnly = true;

                dgvDetalleBoleta.Columns[4].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvDetalleBoleta.DefaultCellStyle.Font = new Font("Arial", 9);


                dgvDetalleBoleta.AllowUserToAddRows = false;
                dgvDetalleBoleta.MultiSelect = false;
                dgvDetalleBoleta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ContarItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    num++;
                }
                lblNumItems.Text = "Nº Items:  " + num;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarGrid(List<E_Producto > Lista)
        {
            try
            {
                dgvDetalleBoleta.Rows.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    String[] fila = new string[] { Lista[i].Id_Prod.ToString(), Lista[i].Nombre_Prod, Lista[i].Cantidad_.ToString(), Lista[i].Precio_Prod.ToString(), (Lista[i].Precio_Prod * 5).ToString() };
                    dgvDetalleBoleta.Rows.Add(fila);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ActualizarMontosDgv()
        {
            try
            {
                double subtotal = 0.0;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    //  subtotal += Convert.ToDouble(row.Cells[4].Value);

                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    row.Cells[4].Value = (Convert.ToDouble((row.Cells[2].Value)) * Convert.ToDouble((row.Cells[3].Value)));
                    subtotal += Convert.ToDouble(row.Cells[4].Value);

                    // txtSubtotal.Text = subtotal.ToString(".00");
                    txtTotal.Text = subtotal.ToString("0.00");
                }
                if (dgvDetalleBoleta.Rows.Count == 0)
                {
                    //txtSubtotal.Text = "0"; txtDescuento.Text = "0";
                    txtTotal.Text = "0";
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void EscribirNuevoMonto()
        {
            try
            {
                int id_prod = 0, cantidad_ = 0;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    id_prod = Convert.ToInt32(row.Cells[0].Value); cantidad_ = Convert.ToInt32(row.Cells[2].Value);

                    if (cantidad_ > 1)
                    {
                        List<E_Producto > Lista = LOCAL.Instancia.ReturnDetVenta(1, id_prod, cantidad_);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void SoloNumCeldaGrid()
        {
            try
            {
                int i = 0; decimal j = 0; String valor, valor_01; Boolean res = false;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    if (row.Cells[2].Value == null) row.Cells[2].Value = 0;
                    valor = row.Cells[2].Value.ToString();
                    res = int.TryParse(valor, out i);
                    if (res == false)
                    {
                        MessageBox.Show("Intentó ingresar un valor no numérico en 'Cantidad', valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[2].Value = i;
                    }
                    if (row.Cells[3].Value == null) row.Cells[3].Value = 0;
                    valor_01 = row.Cells[3].Value.ToString().Replace(".", ",");
                    //  res_01 = SoloDecimales(valor);
                    if (!Decimal.TryParse(valor_01, out j))
                    {
                        MessageBox.Show("Intentó ingresar un valor no numérico en 'Precio', valor se reducira a cero", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        row.Cells[3].Value = 0;
                    }
                    else
                    {
                        row.Cells[3].Value = valor_01;

                    }


                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CargarSerie_correlativo()
        {
            try
            {
                serie = CN_Venta .Intancia.CargarSerie(1, 1);
                ser = serie.Numero_Serie;
                lblSerie.Text = serie.Numero_Serie + "-";
                lblCorrelativo.Text = "Nº " + CN_Venta .Intancia.CargarCorrelativo(1, serie.Numero_Serie);
                corr = CN_Venta .Intancia.CargarCorrelativo(1, serie.Numero_Serie);
            }
            catch (Exception)
            {

                throw;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

      

        private void Frm_Venta_Load(object sender, EventArgs e)
        {
            try
            {

                CrearGrid();
                ContarItems();
                ac.LlenarCboTipDoc(this.gbCliente);
                ac.LlenarCboMoneda(this.gbCliente);
                ac.LlenarTipoPago(this.gbCliente);
                ControlBotones(true, false, false, false); btnBuscarXid.Enabled = false;
                //txtSubtotal.Text = 0.ToString(); txtDescuento.Text = 0.ToString(); txtTotal.Text = 0.ToString();
                us = CD_Usuario.Instancia.BuscarUsario("Id", this.id_user.ToString());
                this.id_user = us.Id_Usuario;
                txtCodUsuario.Text = us.Codigo_Usuario;
                CargarSerie_correlativo();
                btnAnular.Enabled = false;
                int idCliente = LOCAL.Instancia.ReturnIdCliente(0, 0);
                if (idCliente != 0) { btnBuscarCliente.Enabled = false; btnBuscarXid.Enabled = true; }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            try
            { // si intent0==1 indica que ya existe un producto seleccionado, de los contrario abrira formulario de busqueda
                int intento = LOCAL.Instancia.ReturnIntento(0, 0);
                if (intento != 0)
                {
                    List<E_Producto > Lista = LOCAL.Instancia.ReturnDetVenta(0, 0, 0);
                    intento = LOCAL.Instancia.ReturnIntento(1, 0);
                    CargarGrid(Lista);
                    ContarItems();
                    ActualizarMontosDgv();
                }
                else
                {
                    LOCAL.Instancia.Invocar(1, 1);
                    Frm_ProductosVenta SearchProd = new Frm_ProductosVenta (id_user);
                    SearchProd.ShowDialog();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleBoleta_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ControlBotones(true, true, false, true);
                SoloNumCeldaGrid();
                EscribirNuevoMonto();
                ActualizarMontosDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea quitar producto seleccionado?", "Mensaje", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    int id_prod = Convert.ToInt32(dgvDetalleBoleta.CurrentRow.Cells[0].Value);
                    LOCAL.Instancia.QuitarItemPorducto(id_prod);
                    List<E_Producto > Lista = LOCAL.Instancia.ReturnDetVenta(0, 0, 0);
                    if (Lista.Count == 0) ControlBotones(true, false, false, false);
                    CargarGrid(Lista);
                    ContarItems();
                    ActualizarMontosDgv();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("¿Desea realizar una nueva venta?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {

                    int id_cli = LOCAL.Instancia.ReturnIdCliente(1, 0);
                    LOCAL.Instancia.LimpiarDetalleVenta();
                    List<E_Producto > Lista = LOCAL.Instancia.ReturnDetVenta(0, 0, 0);
                    CargarGrid(Lista);
                    ac.LimpiarText (this.gbCliente);
                    ContarItems();
                    ActualizarMontosDgv();
                    CargarSerie_correlativo();
                    dgvDetalleBoleta.Enabled = true; ControlBotones(true, true, false, false); btnAgregarItem.Enabled = true;
                    ac.BloquearText(this.gbCliente, true); ac.BloquearText(this.panel1, true);
                    lblMontoEnletras.Text = "";
                    btnAnular.Enabled = false;
                }
                else
                {  // no hacer nada 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvDetalleBoleta_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                SoloNumCeldaGrid();
                EscribirNuevoMonto();
                ActualizarMontosDgv();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                e.Handled = ac.EntradaSoloNumeros(e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarXid_Click(object sender, EventArgs e)
        {
            try
            {
                E_cliente  c = null;

                int id_cli = LOCAL.Instancia.ReturnIdCliente(0, 0);
                c = CN_Cliente .Intancia.BuscarCliente(id_cli, 0.ToString());
                btnBuscarXid.Enabled = false; btnBuscarCliente.Enabled = true;
                txtNombreCliente.Text = c.Nombre_Cliente;
                txtDireccionCliente.Text = c.Direccion_Cliente;
                cboTipDoc.SelectedValue = c.tipodocumento.Id_TipDoc;
                txtNumDoc.Text = c.NumeroDoc_Cliente.Trim();
            }
            catch (ApplicationException) { btnBuscarXid.Enabled = false; btnBuscarCliente.Enabled = true; }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            try
            {

                E_cliente c = null;
                String num_doc = txtNumDoc.Text;
                c = CN_Cliente .Intancia.BuscarCliente(0, num_doc);
                txtNombreCliente.Text = c.Nombre_Cliente;
                txtDireccionCliente.Text = c.Direccion_Cliente;
                cboTipDoc.SelectedValue = c.tipodocumento.Id_TipDoc;
                txtNumDoc.Text = c.NumeroDoc_Cliente.Trim();
                int i = LOCAL.Instancia.ReturnIdCliente(1, c.Id_Cliente);
            }
            catch (ApplicationException)
            {
                DialogResult r = MessageBox.Show("No se encontro registro, ¿Desea realiza búsqueda avanzada?", "Mensaje", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    /* escribe en el metodo el formulario q invoco a buscar cliente para saber en que lista
                     detalle agregar <este aplica en caso que se encuentre mas de 1 comprobante ejecutandose en paralelo>*/
                    LOCAL.Instancia.Invocar(1, 1);
                    //-----------------------------------------------------------------------------------------------------
                    Frm_ClienteVenta   SearchCli = new Frm_ClienteVenta(id_user);
                    SearchCli.ShowDialog();
                    btnBuscarCliente.Enabled = false; btnBuscarXid.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult r = MessageBox.Show("¿Desea guardar Boleta?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    SoloNumCeldaGrid();
                    EscribirNuevoMonto();
                    ActualizarMontosDgv();
                    E_Venta  v = new E_Venta();

                    E_cliente  c = new E_cliente();
                    c.Id_Cliente = LOCAL.Instancia.ReturnIdCliente(0, 0);
                    v.cliente = c;

                    E_usuario  u = new E_usuario();
                    u = us;
                    v.usuario = u;

                    E_Sucursal s = new E_Sucursal();
                    s.Id_Suc = LOCAL.Instancia.Id_Suc ;
                    v.sucursal = s;

                    E_Comprobante  tc = new E_Comprobante();
                    tc.Id_TipCom = 1;
                    v.tipocomprobante = tc;

                    E_Moneda  m = new E_Moneda();
                    m.Id_Moneda = Convert.ToInt32(CboMoneda.SelectedValue);
                    v.moneda = m;

                    E_TipoPago tp = new E_TipoPago();
                    tp.Id_TipPago = Convert.ToInt32(cboTipoPago.SelectedValue);
                    v.tipopago = tp;

                    v.Igv_Venta = 0;
                    v.Descuento_Venta = 0.0;

                    List<E_DetalleVenta > Detalle = new List<E_DetalleVenta>();
                    foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                    {
                        E_DetalleVenta dt = new E_DetalleVenta();
                        dt.Id_Prod_Det = Convert.ToInt32(row.Cells[0].Value);
                        dt.PrecProd_Det = Convert.ToDouble(row.Cells[3].Value);
                        dt.Cantidad_Det = Convert.ToInt32(row.Cells[2].Value);
                        Detalle.Add(dt);
                    }
                    v.detalleventa = Detalle;
                    v.Desc_Venta = "";
                    CargarSerie_correlativo();
                    int result = CN_Venta .Intancia.GuardarVenta(v, 1, serie.Numero_Serie);
                    MessageBox.Show("Se guardo de manera correcta!", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvDetalleBoleta.Enabled = false; ControlBotones(true, false, false, false); btnAgregarItem.Enabled = false; btnAnular.Enabled = true;
                    ac.BloquearText(this.gbCliente, false); ac.BloquearText(this.panel1, false);
                    lblMontoEnletras.Text = "Son: " + ac.enletras(txtTotal.Text).ToLower() + CboMoneda .Text ;

                }
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        int sw, sh;

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true;
        }
    }
}
