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
    public partial class Frm_ListadoProductos : Form
    {
        CNCategorias objetoCN = new CNCategorias();
        private string Id_Cat = null;
        private bool Editar = false;
        public Frm_ListadoProductos()
        {
            InitializeComponent();
        }

       
        private void eliminarErrorProvider()
        {
          
        }
        private void limpiarForm()
        {
           
           
        }

        private void habilitarCampos(bool sw)
        {
            
        }

       
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            eliminarErrorProvider();
            limpiarForm();
            habilitarCampos(true);

         
            btnbuscar.Enabled = false;
          

        }
        private void Mostrarcategoria()
        {
            CNCategorias objeto = new CNCategorias();
            string filtro;
            filtro = txtFiltro.Text.Replace("'", "");
           
        }
     

        private void btnguardar_Click(object sender, EventArgs e)
        {


        
          
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            habilitarCampos(true);
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            Mostrarcategoria();
        }

        private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                Mostrarcategoria();
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


        private void OcultarColumnas()
        {
            this.dataListado.Columns[0].Visible = false;
            this.dataListado.Columns[1].Visible = false;
           this.dataListado.Columns[5].Visible = false;
           
        }
        private void Mostrar()
        {
            this.dataListado.DataSource =CNProducto.Mostrar();
            this.OcultarColumnas();
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataListado.Rows.Count);
        }

        private void Frm_ListadoProductos_Load(object sender, EventArgs e)
        {


            this.Mostrar();


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
               
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        //METODOS PARA CERRAR,MAXIMIZAR, MINIMIZAR FORMULARIO------------------------------------------------------
        int lx, ly;
        int sw, sh;
        Int32 idUsuario;

        E_usuario u = new E_usuario();
        private void dataListado_DoubleClick(object sender, EventArgs e)
        {
            Frm_IngresoAlmacen IngresoA = Frm_IngresoAlmacen.GetInstancia(idUsuario);
            string par1, par2;
            par1 = Convert.ToString(this.dataListado.CurrentRow.Cells["Id_Prod"].Value);
            par2 = Convert.ToString(this.dataListado.CurrentRow.Cells["Nombre_Prod"].Value);
            IngresoA.setArticulo(par1, par2);
            this.Hide();
        }

        private void btnnormal_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnnormal.Visible = true ;
        }
    }
 }
