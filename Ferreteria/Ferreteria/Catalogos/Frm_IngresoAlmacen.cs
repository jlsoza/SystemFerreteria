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
using System.Data.SqlClient;

namespace Ferreteria
{
    public partial class Frm_IngresoAlmacen: Form
    {
        SqlConnection conexion = new SqlConnection(@"Server = DESKTOP-OBLOVHB\SQLEXPRESS; DataBase = BDFerreteria; Integrated Security = true");

        CNProducto objetoCN = new CNProducto();
        
        private static Frm_IngresoAlmacen _instancia;
        public static Frm_IngresoAlmacen GetInstancia()
        {
            if (_instancia == null)
            {
                _instancia = new Frm_IngresoAlmacen();
            }
            return _instancia;
        }

        //Creamos un método para enviar los valores recibidos  
        //del artículo  
        public void setArticulo(string Id_Prod, string Nombre_Prod)
        {
            this.txtIdproducto.Text = Id_Prod;
            this.txtproducto.Text = Nombre_Prod;
        }

        public Frm_IngresoAlmacen()
        {
            InitializeComponent();
            this.txtproducto.ReadOnly = true;
        }

                  
     
        private void LlenarCombos()
        {
            try
            {
                           

                cboProveedor.ValueMember = "Id_Proveedor";
                cboProveedor.DisplayMember = "RazSocial_Proveedor";
                cboProveedor.DataSource = CNProveedor.Instancia.ListaProveedor();

                cmbComprobante.ValueMember = "Id_TipCom";
                cmbComprobante.DisplayMember = "Nombre_TipCom";
                cmbComprobante.DataSource = CN_Comprobante .Instancia.ListaTipoComprobante();
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
               
               
        private void Frm_IngresoAlmacen_Load(object sender, EventArgs e)
        {

            //Para ubicar al formulario en la parte superior del contenedor  
            this.Top = 0;
            this.Left = 0;
            //Mostrar  
            //this.Mostrar();
            //Deshabilita los controles  
            this.Habilitar(false);
            LlenarCombos();
            //Establece los botones  
            this.Botones();
            this.crearTabla();

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

             

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
      
                     
                
        private void btnbuscarp_Click(object sender, EventArgs e)
        {
            Frm_ListadoProductos  Producto = new Frm_ListadoProductos();
            Producto.ShowDialog();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Ferretero", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void limpiarDetalle()
        {

            this.txtIdproducto.Text = string.Empty;
            this.txtproducto.Text = string.Empty;
            this.txtStock.Text = string.Empty;
            this.txtPrecioCompra.Text = string.Empty;
            this.txtPrecioventa.Text = string.Empty;
            this.dtpfecha.Text = string.Empty;
            this.dtFecha_Produccion.Text = string.Empty;
            this.dtFecha_Vencimiento.Text = string.Empty;
        }


        private bool IsNuevo = false;
        public int Id_Usuario;
        private DataTable dtDetalle;
        private decimal totalPagado = 0;
        private void btnagregar_Click(object sender, EventArgs e)
        {
            try
            {


                string Rpta = "";
                if (this.txtIdproducto .Text == string.Empty || this.txtStock.Text == string.Empty || txtPrecioCompra .Text == string.Empty || txtPrecioventa .Text == string.Empty)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1.SetError(txtserie , "Ingrese la serie del comprobante");
                    errorProvider1.SetError(txtcorrelativo , "Ingrese el número del comprobante");
                    errorProvider1.SetError(txtigv , "Ingrese el porcentaje de IGV");
                    errorProvider1.SetError(dataListadoDetalle, "para generar un ingreso debe haber como minimo un Producto");
                }

                else
                {
                    //Variable que va a indicar si podemos registrar el detalle  
                    bool registrar = true;

                    foreach (DataRow row in dtDetalle.Rows)
                    {
                        if (Convert.ToInt32(row["Id_Prod"]) == Convert.ToInt32(this.txtIdproducto.Text))
                        {
                            registrar = false;
                            this.MensajeError("Ya se encuentra el artículo en el detalle");
                        }
                    }
                    //Si podemos registrar el producto en el detalle  
                    if (registrar)
                    {
                        

                        //Calculamos el sub total del detalle sin descuento  
                        decimal subTotal = Convert.ToDecimal(this.txtPrecioCompra .Text) * Convert.ToDecimal(txtStock.Text);
                        totalPagado = totalPagado + subTotal;
                        this.lblTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                        //Agregamos al fila a nuestro datatable  
                        DataRow row = this.dtDetalle.NewRow();
                        row["Id_Prod"] = Convert.ToInt32(this.txtIdproducto.Text);
                        row["Nombre_Prod"] = this.txtproducto.Text;
                        row["precio_compra"] = Convert.ToDecimal(this.txtPrecioCompra.Text);
                        row["precio_venta"] = Convert.ToDecimal(this.txtPrecioventa.Text);
                        row["stock_inicial"] = Convert.ToInt32(this.txtStock.Text);
                        row["fecha_produccion"] = this.dtFecha_Produccion.Value;
                        row["fecha_vencimiento"] = this.dtFecha_Vencimiento.Value;
                        row["subTotal"] = subTotal;
                        this.dtDetalle.Rows.Add(row);
                        this.limpiarDetalle();
                    }
                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private ConexionBD con = new ConexionBD();

        private void Buscar1(string codigo)
        {
            string sql = string.Format(@"SELECT Id_Prod, Codigo_Prod, Nombre_Prod
            FROM   Tbl_Producto
            WHERE  Codigo_Prod=Codigo_Prod and (Codigo_Prod = '{0}')", codigo);


            SqlCommand comando = new SqlCommand(sql, conexion);
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                leer.Read();

                txtIdproducto .Text = leer["Id_Prod"].ToString();
                txtproducto .Text = leer["Nombre_Prod"].ToString();

                txtfiltro.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(string.Format("Producto: {0},  no existe, valida con el administrador", codigo),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfiltro.Text = string.Empty;
            }

            conexion.Close();
        }



        private void txtfiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && txtfiltro.Text != string.Empty)
            {
                this.Buscar1(txtfiltro.Text);
            }
        }

        private void chProducto_Nuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (chProducto_Nuevo.Checked == false)
            {
                txtcodigoN .Visible = false;
            }

            else
                 if (chProducto_Nuevo.Checked == true)
            {
                txtcodigoN.Visible = true;

            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            try
            {
                //Indice dila actualmente seleccionado y que vamos a eliminar  
                int indiceFila = this.dataListadoDetalle.CurrentCell.RowIndex;
                //Fila que vamos a eliminar  
                DataRow row = this.dtDetalle.Rows[indiceFila];
                //Disminuimos el total a pagar  
                this.totalPagado = this.totalPagado - Convert.ToDecimal(row["subTotal"].ToString());
                this.lblTotal_Pagado.Text = totalPagado.ToString("#0.00#");
                //Removemos la fila  
                this.dtDetalle.Rows.Remove(row);
            }
            catch (Exception ex)
            {
                MensajeError("No hay fila para remover");
            }
        }

        private void Habilitar(bool valor)
        {
            this.txtId_Ingreso.ReadOnly = !valor;
            this.txtserie.ReadOnly = !valor;
            this.txtcorrelativo.ReadOnly = !valor;
            this.txtigv .Enabled = valor;
            this.dtpfecha .Enabled = valor;
           // this.cbTipo_Comprobante.Enabled = valor;
            this.txtStock.ReadOnly = !valor;
            this.txtPrecioCompra .ReadOnly = !valor;
            this.txtPrecioventa .ReadOnly = !valor;
            this.dtFecha_Produccion.Enabled = valor;
            this.dtFecha_Vencimiento.Enabled = valor;
            this.btnagregar .Enabled = valor;
            this.btnquitar .Enabled = valor;
            this.btnbuscarp .Enabled = valor;
            this.txtcodigoN.Enabled = valor;
            this.txtfiltro .Enabled = valor;

        }
        private void Botones()
        {
            if (this.IsNuevo) //Alt + 124  
            {
                this.Habilitar(true);
                this.Nuevo.Enabled = false;
                this.Guardar .Enabled = true;
                this.btncancelar .Enabled = true;
            }
            else
            {
                this.Habilitar(false);
                this.Nuevo.Enabled = true;
                this.Guardar.Enabled = false;
                this.btncancelar.Enabled = false;
            }

        }
        private void Buscar(string codigo)
        {
            string sql = string.Format(
             @"SELECT P.Codigo_Prod, P.Nombre_Prod,P.Id_Prod, 
             MAX (I.precio_venta) as precio_venta,
             max (I.precio_compra) as precio_compra
             FROM  Tbl_Producto AS P INNER JOIN
             Tbl_Detalle_ingreso AS I ON 
             P.Id_Prod = I.Id_Prod
             where P.Codigo_Prod = Codigo_Prod  and (Codigo_Prod = '{0}')
             GROUP BY Codigo_Prod, Nombre_Prod, P.Id_Prod  ", codigo);


            SqlCommand comando = new SqlCommand(sql, conexion );
            conexion.Open();
            SqlDataReader leer = comando.ExecuteReader();

            if (leer.HasRows)
            {
                leer.Read();
                txtIdproducto .Text = leer["Id_Prod"].ToString();
                txtproducto.Text = leer["Nombre_Prod"].ToString();
                txtPrecioventa .Text = leer["precio_venta"].ToString();
                txtPrecioCompra .Text = leer["precio_compra"].ToString();
                txtcodigoN.Text = string.Empty;
            }
            else
            {
                MessageBox.Show(string.Format("Producto: {0},  no se ha vendido,  por lo que se debe registrar como nuevo", codigo),
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcodigoN.Text = string.Empty;
                txtproducto.Text = string.Empty;
                txtIdproducto.Text = string.Empty;
                txtPrecioventa.Text = string.Empty;
                txtPrecioCompra.Text = string.Empty;

            }

            conexion.Close();
        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter && txtcodigoN.Text != string.Empty)
            {
                this.Buscar(txtcodigoN.Text);
            }
        }

        private void crearTabla()
        {
            //Crea la tabla con el nombre de Detalle  
            this.dtDetalle = new DataTable("Detalle");
            //Agrega las columnas que tendra la tabla  
            this.dtDetalle.Columns.Add("Id_Prod", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("Nombre_Prod", System.Type.GetType("System.String"));
            this.dtDetalle.Columns.Add("precio_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("precio_venta", System.Type.GetType("System.Decimal"));
            this.dtDetalle.Columns.Add("stock_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalle.Columns.Add("fecha_produccion", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("fecha_vencimiento", System.Type.GetType("System.DateTime"));
            this.dtDetalle.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            //Relacionamos nuestro datagridview con nuestro datatable  
            this.dataListadoDetalle.DataSource = this.dtDetalle;
        }
        //Limpiar todos los controles del formulario  
        private void Limpiar()
        {
            this.txtId_Ingreso .Text = string.Empty;
            this.cboProveedor.Text = "Seleccione un Proveedor";
            this.cmbComprobante .Text = "Seleccione una Comprobante";
            this.txtserie .Text = string.Empty;
            this.txtcorrelativo .Text = string.Empty;
            this.txtigv .Text = "0";
            this.txtserie .Text = "0";
            this.txtcorrelativo .Text = "0";
            this.lblTotal_Pagado.Text = "0";
            this.crearTabla();

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.IsNuevo = false;
            this.Botones();
            this.Limpiar();
            this.Limpiar();
            this.txtId_Ingreso .Text = string.Empty;
            this.txtfiltro.Focus();
        }

        private void MensajeOk(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema de Ventas", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
      
        private void Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if ( this.txtserie .Text == string.Empty || txtcorrelativo .Text == string.Empty || txtigv .Text == string.Empty || dataListadoDetalle.Rows.Count == 0)
                {
                    MensajeError("Falta ingresar algunos datos, serán remarcados");
                    errorProvider1 .SetError(txtserie , "Ingrese la serie del comprobante");
                    errorProvider1.SetError(txtcorrelativo , "Ingrese el número del comprobante");
                    errorProvider1.SetError(txtigv , "Ingrese el porcentaje de IGV");
                    errorProvider1.SetError(dataListadoDetalle, "para generar un ingreso debe haber como minimo un Producto");
                }
                else
                {
                    if (this.IsNuevo)
                    {

                        int Comprobante;
                        Comprobante = Convert.ToInt32(cmbComprobante.SelectedValue);

                        int Proveedor;
                        Proveedor = Convert.ToInt32(cboProveedor.SelectedValue);


                        //Vamos a insertar un Ingreso   
                        Rpta = CN_Ingresos .Insertar(Id_Usuario, Proveedor,
                        dtpfecha .Value, Comprobante, txtserie.Text, txtcorrelativo.Text,
                        Convert.ToDecimal(txtigv.Text), "EMITIDO", dtDetalle);

                    }

                    //Si la respuesta fue OK, fue porque se modifico   
                    //o inserto el Ingreso  
                    //de forma correcta  
                    if (Rpta.Equals("OK"))
                    {

                        this.MensajeOk("Se insertó de forma correcta el registro");


                    }
                    else
                    {
                        //Mostramos el mensaje de error  
                        this.MensajeError(Rpta);
                    }
                    this.IsNuevo = false;
                    this.Botones();
                    this.Limpiar();
                    this.limpiarDetalle();
                   // this.Mostrar();


                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
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

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtId_Ingreso_TextChanged(object sender, EventArgs e)
        {
            if (txtId_Ingreso.Text != string.Empty)
            {
                this.Habilitar(false);
                this.Nuevo .Enabled = true;
                this.Guardar .Enabled = false;
                this.btncancelar .Enabled = false;


            }
            else
            {
                this.Habilitar(true);
                this.Nuevo.Enabled = false;
                this.Guardar.Enabled = true;
                this.btncancelar.Enabled = true;

            }
        }

        private void Nuevo_Click(object sender, EventArgs e)
        {
            this.IsNuevo = true;
            this.Botones();
            this.Limpiar();
            this.limpiarDetalle();
            this.Habilitar(true);
            this.txtcodigoN.Focus();
        }

        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
