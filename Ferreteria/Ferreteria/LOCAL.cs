using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapadeNegocio;

namespace Ferreteria
{
    public class LOCAL
    {
        private static readonly LOCAL _intancia = new LOCAL();
        public static LOCAL Instancia
        {
            get { return LOCAL._intancia; }
        }

        int Iidcliente = 0, idClienteNV = 0;
        int IdProd = 0;
        int intento = 0;
        // logica para comprbra que formulario invoco al frmbusqueda
        int invocador = 0; // 1: frmboleta, 2: frmnotaventa, 3: frmfactura
        private int _Id_Suc;
        public int Id_Suc
        {
            get { return _Id_Suc; }
            set { _Id_Suc = value; }
        }

        List<E_Producto > detBoleta = new List<E_Producto>();
        List<E_Producto> detNotaVenta = new List<E_Producto>();

        public int Invocar(int getset, int frm)
        {
            try
            {
                if (getset == 1) invocador = frm;
            }
            catch (Exception)
            {
                throw;
            }
            return invocador;
        }

        public int ReturnIntento(int getset, int intent)
        {
            try
            {
                if (getset == 1)
                {
                    intento = intent;
                }
                return intento;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ReturnIdClienteNV(int getset, int Id_Cliente)
        {
            try
            {
                if (getset == 1)
                {
                    idClienteNV = Id_Cliente;
                }
                return idClienteNV;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ReturnIdCliente(int getset, int Id_Cliente)
        {
            try
            {
                if (getset == 1)
                {
                    Iidcliente = Id_Cliente;
                }
                return Iidcliente;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int ReturnIdprod(int getset, int Id_Prod)
        {
            try
            {
                if (getset == 1)
                {
                    IdProd = Id_Prod;
                }
                return IdProd;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
