﻿using System;
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
    public partial class Frm_ProductosVenta : Form
    {
        int id_Usario = 0;

        public Frm_ProductosVenta(int? idUs)
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
            dgvProductos.Columns.Add("ColumnId", "Id");
            dgvProductos.Columns.Add("ColumnNumero", "#");
            dgvProductos.Columns.Add("ColumnCodigo", "Codigo");
            dgvProductos.Columns.Add("ColumnNombre", "Nombre");
            dgvProductos.Columns.Add("ColumnMarca", "Marca");
            dgvProductos.Columns.Add("ColumnCategoria", "Categoria");
            dgvProductos.Columns.Add("ColumnUnidMed", "Unid. Med");
            dgvProductos.Columns.Add("ColumnPecio", "Precio");
            dgvProductos.Columns.Add("ColumnStock", "Stock");


            dgvProductos.Columns[0].Visible = false;
            dgvProductos.Columns[1].Width = 30;
            dgvProductos.Columns[4].Width = 150;
            dgvProductos.Columns[3].Width = 250;
            dgvProductos.Columns[6].Width = 200;
            dgvProductos.Columns[6].Width = 200;
            dgvProductos.Columns[8].Width = 80;
          


            DataGridViewCellStyle cssCabecera = new DataGridViewCellStyle();
            cssCabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvProductos.ColumnHeadersDefaultCellStyle = cssCabecera;

            dgvProductos.AllowUserToAddRows = false;
            dgvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }



        private void Frm_ProductosVenta_Load(object sender, EventArgs e)
        {


            try
            {
                CrearGrid();
                rbNombreProd.Checked = true; tip_busqueda = 1;
                btnVender.Enabled = false;
                btnMantenimiento.Enabled = false;
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
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
        Int32 idUsuario;
        // variable globar captura estado o que tipo de busqueda dse estara realizando
        int tip_busqueda = 0;
        private void txtBusqProd_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Back)
                {
                    String val_entrada = txtBusqProd.Text;
                    int num = 0;
                    List<E_Producto > Lista = CNProducto .Instancia.BuscarprodAvanzada(tip_busqueda, val_entrada);
                    dgvProductos.Rows.Clear();
                    for (int i = 0; i < Lista.Count; i++)
                    {
                        num++;
                        String[] fila = new string[] {Lista[i].Id_Prod.ToString(),num.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].Marca_Prod,
                        Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Descripcion_Umed,Lista[i].Precio_Prod.ToString(),Lista[i].Stock_Prod.ToString()
                };
                        dgvProductos.Rows.Add(fila);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbNombreProd_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tip_busqueda = 1;
                dgvProductos.Rows.Clear();
                btnVender.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tip_busqueda = 2;
                dgvProductos.Rows.Clear();
                btnVender.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbPrecio_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                tip_busqueda = 3;
                dgvProductos.Rows.Clear();
                btnVender.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                try
                {
                    btnVender.Enabled = true;
                    btnMantenimiento.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                btnVender.Enabled = false;
                int num = 0;
                List<E_Producto > Lista = CNProducto .Instancia.BuscarprodAvanzada(tip_busqueda, "");
                dgvProductos.Rows.Clear();
                for (int i = 0; i < Lista.Count; i++)
                {
                    num++;
                    String[] fila = new string[] {Lista[i].Id_Prod.ToString(),num.ToString(),Lista[i].Codigo_Prod,Lista[i].Nombre_Prod,Lista[i].Marca_Prod,
                    Lista[i].categoria.Nombre_Cat,Lista[i].unidmedida.Descripcion_Umed,Lista[i].Precio_Prod.ToString(),Lista[i].Stock_Prod.ToString()
                };
                    dgvProductos.Rows.Add(fila);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            try
            {
                //int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                //List<entProducto> AgregarProdAlista = LocalBD.Instancia.ReturnDetVenta(1, id_prod, 1);
                //frmBoletaVenta frmbv = new frmBoletaVenta(this.id_Usario);
                int intento = LOCAL.Instancia.ReturnIntento(1, 1);
                int invocador = LOCAL.Instancia.Invocar(0, 0);
                if (invocador == 1)
                {
                    int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    LOCAL.Instancia.ReturnDetVenta(1, id_prod, 1);
                }
                else if (invocador == 2)
                {
                    int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                    LOCAL.Instancia.ReturnDetNotaVenta(1, id_prod, 1);
                }
                else
                {
                    LOCAL.Instancia.Invocar(1, 0);
                }
                this.Close();
                //frmbv.txtidcli.Text = id_cli.ToString();
                //foreach (Form frm in Application.OpenForms)
                //{
                //    if (frm.GetType() == typeof(frmBoletaVenta))
                //    {
                //        frm.Show();
                //        this.Visible = false;
                //        return;
                //    }
                //}
                //frmbv.Show();
            }
            catch (ApplicationException ae) { MessageBox.Show(ae.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            try
            {
                int id_prod = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value);
                LOCAL.Instancia.ReturnIdprod(1, id_prod);
                this.Dispose();
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
