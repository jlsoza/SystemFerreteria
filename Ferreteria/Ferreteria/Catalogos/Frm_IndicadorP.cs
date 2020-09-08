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
    public partial class Frm_IndicadorP: Form
    {
        CNProveedor objetoCN = new CNProveedor();
        private string Id_Proveedor = null;
        private bool Editar = false;
        public Frm_IndicadorP()
        {
            InitializeComponent();
        }

        private void CrearGrid()
        {
            try
            {
                dgvProducto.Columns.Add("ColumnId", "Id");
                dgvProducto.Columns.Add("ColumnCodigo", "Código");
                dgvProducto.Columns.Add("ColumnNombre", "Producto");
                dgvProducto.Columns.Add("ColumnPrecioCompra", "P Compra");
                dgvProducto.Columns.Add("ColumnPrecio", "P Venta");
                dgvProducto.Columns.Add("ColumnStock", "Stock");
                dgvProducto.Columns.Add("ColumnUniMedida", "Categoria");
                dgvProducto.Columns.Add("ColumnMaterila", "Uni. Medida");
                dgvProducto.Columns.Add("ColumnUniMedida", "Material");
                DataGridViewImageColumn dgvImagenColumn = new DataGridViewImageColumn();
                dgvImagenColumn.HeaderText = "Estado";
                dgvImagenColumn.Name = "ColumnEstado";
                dgvProducto.Columns.Add(dgvImagenColumn);

                dgvProducto.Columns[0].Visible = false;
                dgvProducto.Columns[2].Width = 198;
                dgvProducto.Columns[3].Width = 88;
                dgvProducto.Columns[4].Width = 88;
                dgvProducto.Columns[5].Width = 88;
                dgvProducto.Columns[6].Visible = false;
                dgvProducto.Columns[7].Width = 100;
                dgvProducto.Columns[8].Visible = false;
                dgvProducto.Columns[9].Width = 65;


                DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
                cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvProducto.ColumnHeadersDefaultCellStyle = cssCabecera;

                dgvProducto.AllowUserToAddRows = false;
                dgvProducto.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvProducto.AllowUserToResizeColumns = false;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void LlenarGrid(String name)
        {
            try
            {
                int cat = 0;
                if (name == null)
                {
                    if (cboCategoria.SelectedValue == null) throw new ApplicationException("Debe seleccionar una categoria");
                }
                if (!String.IsNullOrEmpty(Convert.ToString(cboCategoria.SelectedValue))) cat = (int)cboCategoria.SelectedValue;
                dgvProducto.Rows.Clear();
                int rango = 0;
                Image img = null;
                if (rbStock.Checked == true) rango = 3;
                else if (rbStockPromedio.Checked == true) rango = 2;
                else if (rbStcokMin.Checked == true) rango = 1;
                else if (rbstockcero.Checked == true) rango = 0;
                List<E_Producto> Lista = null;
                if (name == null) { Lista = CD_Producto.Instancia.ListarProductoIndicador(txtCod_Producto.Text, (int)cat, rango); }
                else { Lista = CNProducto.Instancia.BuscarprodAvanzadaIndicador(name); }
                for (int i = 0; i < Lista.Count; i++)
                {
                    if (Lista[i].Stock_Prod >= 0 && Lista[i].Stock_Prod <= Lista[i].StockMin_Prod)
                    {
                        img = Properties.Resources.circulorojo_24x24;
                    }

                    else if (Lista[i].Stock_Prod > Lista[i].StockMin_Prod && Lista[i].Stock_Prod <= Lista[i].StockProm_Prod)
                    {
                        img = Properties.Resources.CirculoNaranja24x24;  //Image.FromFile(Path.Combine(Application.StartupPath, "ImgAplicacion\\CirculoNaranja24x24.png"));
                    }

                    else if (Lista[i].Stock_Prod > Lista[i].StockProm_Prod)
                    {
                        img = Properties.Resources.circulo_verde24x24; //Image.FromFile(Path.Combine(Application.StartupPath, "ImgAplicacion\\circulo_verde24x24.png"));
                    }

                    String[] fila = new String[] { Lista[i].Id_Prod.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].PrecioCompra_Prod.ToString(),Lista[i].Precio_Prod.ToString(),
                    Lista[i].Stock_Prod.ToString(),Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Abreviatura_Umed};
                    dgvProducto.Rows.Add(fila);
                    dgvProducto.Rows[i].Cells[9].Value = img;
                }
            }
            catch (Exception)
            {

                throw;
            }
            labelContador.Text = dgvProducto.Rows.Count.ToString();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
        ///    if (e.KeyChar == 13)
                //Mostrarcategoria();
        }
        private void LlenarCombo()
        {
            try
            {
                cboCategoria.ValueMember = "Id_Cat";
                cboCategoria.DisplayMember = "Nombre_Cat";
                cboCategoria.DataSource = CNProducto.Instancia.ListaCategoria();
                // cargar estado rbstock
                rbStock.Checked = true;
            }

            catch (Exception)
            {
                throw;
            }

        }

        private void Frm_IndicadorP_Load(object sender, EventArgs e)
        {

            try
            {
                CrearGrid();
               LlenarCombo();
               labelContador.Text = dgvProducto.Rows.Count.ToString();
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
        int sw, sh;

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid(null);
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                LlenarGrid(null);
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
