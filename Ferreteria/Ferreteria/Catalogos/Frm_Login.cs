using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaDatos;
using CapadeNegocio;

namespace Login_Desing
{
    public partial class Frm_Login: Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtusuario .Focus();
        }

        private void chkmostrarPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkmostrarPass.CheckState == CheckState.Checked)
            {
                txtpassword .UseSystemPasswordChar = false;
            }
            else
            {
                txtpassword.UseSystemPasswordChar = true;
            }
        }


        private void btningresar_Click(object sender, EventArgs e)
        {
            try
            {
                String usuario = txtusuario .Text;
                String password = txtpassword .Text;
                E_usuario  u = null;
                u = CN_Usuario .Instancia.IngresoSisema(usuario, password);
                Ferreteria.Frm_Sucursal  S = new Ferreteria.Frm_Sucursal(u);
                S.Show();
            }
            catch (ApplicationException ae)
            {

                MessageBox.Show(ae.Message, "Aviso",
                   MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                try
                {
                    String usuario = txtusuario.Text;
                    String password = txtpassword.Text;
                    E_usuario u = null;
                    u = CN_Usuario.Instancia.IngresoSisema(usuario, password);
                    Ferreteria.Frm_Sucursal S = new Ferreteria.Frm_Sucursal(u);
                    S.Show();
                }
                catch (ApplicationException ae)
                {

                    MessageBox.Show(ae.Message, "Aviso",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
