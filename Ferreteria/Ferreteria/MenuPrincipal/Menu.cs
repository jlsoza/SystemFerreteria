using Ferreteria.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Login_Desing;

namespace Ferreteria.MenuPrincipal
{
    public partial class Menu : Form
    {
        E_usuario u = new E_usuario();

        public Menu(E_usuario usuario)
        {
            InitializeComponent();
            u = usuario;
            DeslizarArchivos.Start();
            DeslizarComponentes.Start();
            DeslizarMovimientos.Start();
        }

        private void RestriccionesUsuario()
        {
            try
            {
                if (u.nivel_acceso.Numero_NivelAcc == 1)
                {
                    btncatalogo.Enabled = true;
                    btnProducto.Enabled = true;
                    btnProveedor.Enabled = true;
                    btnUsuarios.Enabled = true;
                    btnclientes.Enabled = true;
                    btncategorias.Enabled = true;
                    BtnCompras.Enabled = true;
                    btnIngreso.Enabled = true;
                    btndetalleIngreso.Enabled = true;
                    Btnventas.Enabled = true;
                    btndetalleventas.Enabled = true; 
                }

                if (u.nivel_acceso.Numero_NivelAcc == 2)
                {
                    btncatalogo.Enabled = false ;
                    btnProducto.Enabled = false ;
                    btnProveedor.Enabled = false ;
                    btnUsuarios.Enabled = false ;
                    btnclientes.Enabled = true;
                    btncategorias.Enabled = false ;
                    BtnCompras.Enabled = true;
                    btnIngreso.Enabled = false ;
                    btndetalleIngreso.Enabled = false ;
                    Btnventas.Enabled = true;
                    btndetalleventas.Enabled = true;
                }

                if (u.nivel_acceso.Numero_NivelAcc == 3)
                {
                    btncatalogo.Enabled = false;
                    btnProducto.Enabled = true ;
                    btnProveedor.Visible  = false  ;
                    btnUsuarios.Enabled = false;
                    btnUsuarios.Visible  = false;
                    btnclientes.Enabled = false ;
                    btncategorias.Enabled = true ;
                    BtnCompras.Visible  = true ;
                    btnIngreso.Enabled = true ;
                    btndetalleIngreso.Enabled = true;
                    Btnventas.Visible  = true ;
                    btniventas.Visible = false;
                    btndetalleventas.Visible  = false ;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }



        private void btncatalogo_Click_1(object sender, EventArgs e)
        {
            DeslizarArchivos.Start();
            MinMov.Start();
            MinCom.Start();
            //SoundPlayer Player = new SoundPlayer();
            //Player.SoundLocation = "Audio\\mouse_click_single.wav";
            //Player.Play();
        }
        private bool DeslizarMenu1;
        private void DeslizarArchivos_Tick(object sender, EventArgs e)
        {
            if (DeslizarMenu1)
            {
                btncatalogo.Iconimage_right = Resources.menossRex_64;
                panelSubmenuC.Height += 5;
                if (panelSubmenuC.Size == panelSubmenuC.MaximumSize)
                {
                    DeslizarArchivos.Stop();
                    DeslizarMenu1 = false;
                }
            }
            else
            {
                btncatalogo.Iconimage_right = Resources.massRexx_64;
                panelSubmenuC.Height -= 5;
                if (panelSubmenuC.Size == panelSubmenuC.MinimumSize)
                {
                    DeslizarArchivos.Stop();
                    DeslizarMenu1 = true;
                }
            }
        }

        private void BtnCompras_Click(object sender, EventArgs e)
        {
            DeslizarComponentes.Start();
            MinMov.Start();
            MinArc.Start();
        }

        private bool DeslizarMenu2;
        private void DeslizarComponentes_Tick(object sender, EventArgs e)
        {
            if (DeslizarMenu2)
            {
                BtnCompras.Iconimage_right = Resources.menossRex_64;
                Compras.Height += 5;
                if (Compras.Size == Compras.MaximumSize)
                {
                    DeslizarComponentes.Stop();
                    DeslizarMenu2 = false;
                }
            }
            else
            {
                BtnCompras.Iconimage_right = Resources.massRexx_64;
                Compras.Height -= 5;
                if (Compras.Size == Compras.MinimumSize)
                {
                    DeslizarComponentes.Stop();
                    DeslizarMenu2 = true;
                }
            }
        }

        private void MinCom_Tick(object sender, EventArgs e)
        {
            BtnCompras.Iconimage_right = Resources.massRexx_64;
            Compras.Height -= 5;
            if (Compras.Size == Compras.MinimumSize)
            {
                MinCom.Stop();
                DeslizarMenu2 = true;
            }
        }

        private void MinArc_Tick(object sender, EventArgs e)
        {
            btncatalogo.Iconimage_right = Resources.massRexx_64;
            panelSubmenuC.Height -= 5;
            if (panelSubmenuC.Size == panelSubmenuC.MinimumSize)
            {
                MinArc.Stop();
                DeslizarMenu1 = true;
            }
        }
               
        private void btnCerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("¿Esta seguro de cerrar?", "Alerta!!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btnventas_Click(object sender, EventArgs e)
        {
            DeslizarMovimientos.Start();
            MinMov.Start();
            MinArc.Start();
        }
        private bool DeslizarMenu3;
        private void MinMov_Tick(object sender, EventArgs e)
        {
            Btnventas.Iconimage_right = Resources.massRexx_64;
            VentasPanel.Height -= 5;
            if (VentasPanel.Size == VentasPanel.MinimumSize)
            {
                MinMov.Stop();
                DeslizarMenu3 = true;
            }
        }

        private void DeslizarMovimientos_Tick(object sender, EventArgs e)
        {
            if (DeslizarMenu3)
            {
                Btnventas.Iconimage_right = Resources.menossRex_64;
                VentasPanel.Height += 5;
                if (VentasPanel.Size == VentasPanel.MaximumSize)
                {
                    DeslizarMovimientos.Stop();
                    DeslizarMenu3 = false;
                }
            }
            else
            {
                Btnventas.Iconimage_right = Resources.massRexx_64;
                VentasPanel.Height -= 5;
                if (VentasPanel.Size == VentasPanel.MinimumSize)
                {
                    DeslizarMovimientos.Stop();
                    DeslizarMenu3 = true;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {

            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(55, 61, 69));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO  TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 15;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.Contenedor.Region = region;
            this.Invalidate();
        }

        //METODO PARA ABRIR FORM DENTRO DE PANEL-----------------------------------------------------
        private void AbrirFormEnPanel(object formHijo)
        {
            if (this.FormPanel.Controls.Count > 0)
                this.FormPanel.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.StartPosition = FormStartPosition.CenterParent;
            // fh.Dock = DockStyle.Fill;
            this.FormPanel.Controls.Add(fh);
            this.FormPanel.Tag = fh;
            fh.Show();
        }
        private void btnProducto_Click(object sender, EventArgs e)
        {
            Frm_Producto fm = new Frm_Producto();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void tmFechaHora_Tick(object sender, EventArgs e)
        {
            lbFecha.Text = DateTime.Now.ToLongDateString();
            lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Frm_Proveedor fm = new Frm_Proveedor();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            Frm_Cliente fm = new Frm_Cliente();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            Frm_IngresoAlmacen fm = new Frm_IngresoAlmacen();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void btncategorias_Click(object sender, EventArgs e)
        {
            Frm_Categoria fm = new Frm_Categoria();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            try
            {
                // recorre todos los formularios abiertos en busca de frmLogeo
                Form frmlogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Login);
                if (frmlogin != null)
                {
                    frmlogin.Visible = false;
                }

                Form frnselecsuc = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_Sucursal);
                // si existe una instancia de frmlogeo:  visible = false (oculta)
                if (frnselecsuc != null)
                {
                    frnselecsuc.Visible = false;
                }

                lblusuario .Text = "Bienvenido: " + u.Nombre_Usuario  ;
                lbldescripcion2.Text = "Sucursal : "+ u.sucursal.Direccion_Suc + " Nivel de acceso:" + u.nivel_acceso.Numero_NivelAcc   ;

                RestriccionesUsuario();
            }
            catch (ArgumentNullException ne)
            {

                MessageBox.Show(ne.Message, "Aviso",
                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Frm_Usuario fm = new Frm_Usuario();
            //fm.FormClosed += new FormClosedEventHandler(MostrarFormLogoAlCerrarForms);
            AbrirFormEnPanel(fm);
        }
    }
}
