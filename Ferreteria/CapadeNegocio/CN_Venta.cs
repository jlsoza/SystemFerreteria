using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapadeNegocio
{
   public class CN_Venta
    {
        #region singleton
        private static readonly CN_Venta _intancia = new CN_Venta();
        public static CN_Venta Intancia
        {
            get { return CN_Venta._intancia; }
        }
        #endregion singleton


        public E_Venta  VentaDetalle(int id_venta)
        {
            try
            {
                E_Venta v = CD_Venta .Instancia.LstVentaDetalle(id_venta);
                if (v == null) throw new ApplicationException("Ocurrio un error al tratar de mostrar detalle");
                //else if (v.detalleventa.Count == 0 || v.detalleventa == null) { throw new ApplicationException("No se encontraron items");return v; }
                return v;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<E_Venta > ListarVenta(String fdesde, String fhasta, int idSucursal)
        {
            try
            {
                List<E_Venta> Lista = CD_Venta .Instancia.ListarVenta(fdesde, fhasta, idSucursal);
                if (Lista == null) throw new ApplicationException("Error al cargar historial de ventas");
                else if (Lista.Count == 0) throw new ApplicationException("Lista de historial de ventas vacia");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<E_TipoPago > CargarTipoPago()
        {
            try
            {
                List<E_TipoPago> Lista = CD_Venta .Instancia.CargarTipoPago();
                if (Lista == null) throw new ApplicationException("Error al cargar tipo de pago");
                else if (Lista.Count == 0) throw new ApplicationException("Litsa tipo de pago vacia");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int AnularComprobante(String serie, String correlativo, int tipcomprobante)
        {
            try
            {
                int result = CD_Venta .Instancia.AnularComprobante(serie, correlativo, tipcomprobante);
                if (result <= 0) throw new ApplicationException("No se pudo anular comprobante");
                return result;
            }
            catch (Exception)
            {

                throw;
            }

        }

        public String CargarCorrelativo(int id_tipcom, String serie)
        {
            try
            {
                String correlativo = CD_Venta .Instancia.CargarCorrelativo(id_tipcom, serie);
                if (correlativo == null) throw new ApplicationException("Error al cargar número correlativo");
                return correlativo;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public E_Serie  CargarSerie(int id_suc, int id_tipcom)
        {
            try
            {
                E_Serie s = CD_Venta .Instancia.CargarSerie(id_suc, id_tipcom);
                if (s == null) throw new ApplicationException("Error al cargar serie, problema con dato de sucursal");
                return s;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GuardarVenta(E_Venta  v, int id_tipdocventa, String serie)
        {
            try
            {
                if (v.cliente.Id_Cliente == 0) throw new ApplicationException("Debe tener un cliente seleccionado");
                if (v.detalleventa.Count == 0) throw new ApplicationException("Debe selecionar como mínimo un producto");

                String Cadxml = "";
                Cadxml += "<Tbl_Venta ";
                Cadxml += "idcliente='" + v.cliente.Id_Cliente + "' ";
                Cadxml += "idusuario='" + v.usuario.Id_Usuario + "' ";
                Cadxml += "idsucursal='" + v.sucursal.Id_Suc + "' ";
                Cadxml += "istipcom='" + v.tipocomprobante.Id_TipCom + "' ";
                Cadxml += "idmoneda='" + v.moneda.Id_Moneda + "' ";
                Cadxml += "idtipopago='" + v.tipopago.Id_TipPago + "' ";
                Cadxml += "igv='" + v.Igv_Venta + "' ";
                Cadxml += "serie='" + serie + "' ";
                Cadxml += "descuento='" + v.Descuento_Venta.ToString().Replace(",", ".") + "' ";
                Cadxml += "descripcion='" + v.Desc_Venta.ToString() + "'>";

                foreach (E_DetalleVenta  dt in v.detalleventa)
                {
                    Cadxml += "<Tbl_DetalleVenta ";
                    Cadxml += "idproducto='" + dt.Id_Prod_Det + "' ";
                    Cadxml += "precioprod='" + dt.PrecProd_Det.ToString().Replace(",", ".") + "' ";
                    Cadxml += "cantidad='" + dt.Cantidad_Det + "'/>";
                }
                Cadxml += "</Tbl_Venta>";
                Cadxml = "<root>" + Cadxml + "</root>";
                int i = CD_Venta .Instancia.GuardarVenta(Cadxml, id_tipdocventa);
                if (i <= 0) throw new ApplicationException("Ocurrio un erro al guardar venta actual");
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<E_Moneda > ListarMoneda()
        {
            try
            {
                List<E_Moneda> Lista = CD_Venta.Instancia.ListarMoneda();
                if (Lista.Count <= 0) throw new ApplicationException("Lista moneda esta vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista de moneda");
                return Lista;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
