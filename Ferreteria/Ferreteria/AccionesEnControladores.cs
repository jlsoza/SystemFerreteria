using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapadeNegocio;
using Entidades;

namespace Ferreteria
{
    public class AccionesEnControladores
    {

        public void LimpiarText(Control control)
        {
            try
            {
                foreach (Control txt in control.Controls)
                {
                    if (txt is TextBox)
                    {
                        if (txt.Name != "txtCodUsuario")
                        {
                            ((TextBox)txt).Clear();
                        }
                    }
                    else if (txt is GroupBox)
                    {
                        foreach (Control txtgb in txt.Controls)
                        {
                            if (txtgb is TextBox)
                            {
                                ((TextBox)txtgb).Clear();
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }


        }
    }
}
