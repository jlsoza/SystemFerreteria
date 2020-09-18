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


        public List<E_Producto > ReturnDetVenta(int getset, int idprod, int cantidad)
        {
            try
            {
                if (getset == 1)
                {
                    if (cantidad > 1)
                    {
                        for (int i = 0; i < detBoleta.Count; i++)
                        {
                            if (detBoleta[i].Id_Prod == idprod)
                            {
                                detBoleta[i].Cantidad_ = cantidad;
                                break;
                            }
                        }
                    }
                    else
                    {

                        for (int i = 0; i < detBoleta.Count; i++)
                        {
                            if (detBoleta[i].Id_Prod == idprod)
                            {
                                throw new ApplicationException("Este producto ya fue agreado");
                            }
                        }
                        E_Producto  pr = CNProducto .Instancia.BuscarProducto(idprod);
                        pr.Cantidad_ = cantidad;
                        detBoleta.Add(pr);
                    }
                }
                return detBoleta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<E_Producto > ReturnDetNotaVenta(int getset, int idprod, int cantidad)
        {
            try
            {
                if (getset == 1)
                {
                    if (cantidad > 1)
                    {
                        for (int i = 0; i < detNotaVenta.Count; i++)
                        {
                            if (detNotaVenta[i].Id_Prod == idprod)
                            {
                                detNotaVenta[i].Cantidad_ = cantidad;
                                break;
                            }
                        }
                    }
                    else
                    {
                        for (int i = 0; i < detNotaVenta.Count; i++)
                        {
                            if (detNotaVenta[i].Id_Prod == idprod)
                            {
                                throw new ApplicationException("Este producto ya fue agreado");
                            }
                        }
                        E_Producto pr = CNProducto .Instancia.BuscarProducto(idprod);
                        pr.Cantidad_ = cantidad;
                        detNotaVenta.Add(pr);
                    }
                }
                return detNotaVenta;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void QuitarItemPorducto(int id_prod)
        {
            try
            {
                foreach (E_Producto  p in detBoleta)
                {
                    if (p.Id_Prod == id_prod)
                    {
                        detBoleta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void QuitarItemPorductoNV(int id_prod)
        {
            try
            {
                foreach (E_Producto  p in detNotaVenta)
                {
                    if (p.Id_Prod == id_prod)
                    {
                        detNotaVenta.Remove(p);
                        return;
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void LimpiarDetalleVenta()
        {
            try
            {
                detBoleta.RemoveRange(0, detBoleta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void LimpiarDetalNV()
        {
            try
            {
                detNotaVenta.RemoveRange(0, detNotaVenta.Count);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
