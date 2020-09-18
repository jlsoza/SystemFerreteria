﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Venta
    {
        #region singleton
        private static readonly CD_Venta _intancia = new CD_Venta();
        public static CD_Venta Instancia
        {
            get { return CD_Venta._intancia; }
        }
        #endregion singleton

        public E_Venta  LstVentaDetalle(int id_venta)
        {
            SqlCommand cmd = null;
            IDataReader idr = null;
            E_Venta v = null;
            List<E_DetalleVenta > det = null;
            try
            {
                SqlConnection cn = ConexionBD .Instancia.Conectar();
                cmd = new SqlCommand("spMostrarCabeceraVenta", cn);
                cmd.Parameters.AddWithValue("@prmid_venta", id_venta);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                idr = cmd.ExecuteReader();
                if (idr.Read())
                {
                    v = new E_Venta();
                    v.Codigo_Venta = idr["Codigo_Venta"].ToString();
                    v.Serie_Venta = Convert.ToInt32(idr["Serie_Venta"].ToString());
                    v.Correlativo_Venta = idr["Correlativo_Venta"].ToString();
                    v.Igv_Venta = Convert.ToInt32(idr["Igv_Venta"]);
                    v.FechaVenta = Convert.ToDateTime(idr["FechaVenta"]);
                    v.Estado_Venta = idr["Estado_Venta"].ToString();
                    v.Descuento_Venta = Convert.ToDouble(idr["Descuento_Venta"]);
                    v.Desc_Venta = idr["Desc_Venta"].ToString();

                    E_cliente  c = new E_cliente();
                    c.Nombre_Cliente = idr["Nombre_Cliente"].ToString();
                    c.NumeroDoc_Cliente = idr["NumeroDoc_Cliente"].ToString();

                    E_TipoDoc  td = new E_TipoDoc();
                    td.Nombre_TipDoc = idr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    v.cliente = c;

                    E_Sucursal  s = new E_Sucursal();
                    s.Direccion_Suc = idr["Direccion_Suc"].ToString();
                    v.sucursal = s;

                    E_usuario  u = new E_usuario();
                    u.Nombre_Usuario = idr["Nombre_Usuario"].ToString();
                    v.usuario = u;

                    E_Comprobante  tc = new E_Comprobante();
                    tc.Nombre_TipCom = idr["Nombre_TipCom"].ToString();
                    v.tipocomprobante = tc;

                    E_Moneda  m = new E_Moneda();
                    m.Descripcion_Moneda = idr["Descripcion_Moneda"].ToString();
                    v.moneda = m;

                    E_TipoPago  tp = new E_TipoPago();
                    tp.Descripcion_TipPago = idr["Descripcion_TipPago"].ToString();
                    v.tipopago = tp;

                    if (idr.NextResult())
                    {
                        det = new List<E_DetalleVenta >();
                        while (idr.Read())
                        {
                            E_DetalleVenta d = new E_DetalleVenta();
                            d.PrecProd_Det = Convert.ToDouble(idr["PrecProd_Det"]);
                            d.Cantidad_Det = Convert.ToInt32(idr["Cantidad_Det"]);
                            E_Producto  p = new E_Producto();
                            p.Codigo_Prod = idr["Codigo_Prod"].ToString();
                            p.Nombre_Prod = idr["Nombre_Prod"].ToString();
                            p.Precio_Prod = Convert.ToDouble(idr["Precio_Prod"]);
                            d.producto = p;
                            det.Add(d);
                        }
                        v.detalleventa = det;
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return v;
        }

        public int AnularVentaXid(int id_venta)
        {
            SqlCommand cmd = null;
            var retorno = 0;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spAnularBoletaXid", cn);
                cmd.Parameters.AddWithValue("@prmId_venta", id_venta);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                retorno = cmd.ExecuteNonQuery();
                return retorno;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public List<E_Venta > ListarVenta(String fechadesde, String fechahasta, int idSucursal)
        {
            SqlCommand cmd = null;
            List<E_Venta> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListaVenta", cn);
                cmd.Parameters.AddWithValue("@prmfinicio", fechadesde);
                cmd.Parameters.AddWithValue("@prmfin", fechahasta);
                cmd.Parameters.AddWithValue("@prmidsucursal", idSucursal);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Venta>();
                while (dr.Read())
                {
                    E_Venta v = new E_Venta();
                    v.Id_Venta = Convert.ToInt32(dr["Id_Venta"]);
                    v.Codigo_Venta = dr["Codigo_Venta"].ToString();
                    v.Estado_Venta = dr["Estado_Venta"].ToString();
                    v.Correlativo_Venta = dr["Correlativo_Venta"].ToString();
                    v.FechaVenta = Convert.ToDateTime(dr["FechaVenta"]);
                    v.Igv_Venta = Convert.ToInt32(dr["Igv_Venta"]);
                    v.Total = Convert.ToDouble(dr["Total"].ToString());
                    v.Descuento_Venta = Convert.ToDouble(dr["Descuento_Venta"]);
                    v.Utilidad = Convert.ToDouble(dr["Utilidad"]);
                    v.Inversion = Convert.ToDouble(dr["Inversion"]);

                    E_Comprobante  tc = new E_Comprobante();
                    tc.Id_TipCom = Convert.ToInt32(dr["Id_TipCom"]);
                    tc.Nombre_TipCom = dr["Nombre_TipCom"].ToString();
                    v.tipocomprobante = tc;

                    E_TipoPago  tp = new E_TipoPago();
                    tp.Id_TipPago = Convert.ToInt32(dr["Id_TipPago"]);
                    v.tipopago = tp;
                    Lista.Add(v);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }


        public List<E_TipoPago > CargarTipoPago()
        {
            SqlCommand cmd = null; SqlDataReader dr = null;
            List<E_TipoPago> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListaTipoPago", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_TipoPago>();
                while (dr.Read())
                {
                    E_TipoPago tp = new E_TipoPago();
                    tp.Id_TipPago = Convert.ToInt32(dr["Id_TipPago"]);
                    tp.Descripcion_TipPago = dr["Descripcion_TipPago"].ToString();
                    Lista.Add(tp);
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public int AnularComprobante(String serie, String correlativo, int tipComprobante)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spAnularComprobante", cn);
                cmd.Parameters.AddWithValue("@Serie", serie);
                cmd.Parameters.AddWithValue("@correlativo", correlativo);
                cmd.Parameters.AddWithValue("@idtipcom", tipComprobante);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }

        public String CargarCorrelativo(int id_tipcom, String serie)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            String correlativo = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spCargarCorrelativo", cn);
                cmd.Parameters.AddWithValue("@id_tipcom", id_tipcom);
                cmd.Parameters.AddWithValue("@NumSerie", serie);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    correlativo = dr["Correlativo"].ToString();
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return correlativo;
        }

        public E_Serie  CargarSerie(int id_Suc, int id_tipcom)
        {
            SqlCommand cmd = null;
            E_Serie s = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spCargarSerie", cn);
                cmd.Parameters.AddWithValue("@prmIdSuc", id_Suc);
                cmd.Parameters.AddWithValue("@prmIdTipcom", id_tipcom);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    s = new E_Serie();
                    s.Id_Serie = Convert.ToInt32(dr["Id_Serie"]);
                    s.Numero_Serie = dr["Numero_Serie"].ToString();
                    E_Sucursal  suc = new E_Sucursal();
                    suc.Id_Suc = Convert.ToInt32(dr["Id_Sucursal_Serie"]);
                    s.sucursal = suc;
                    E_Comprobante  tc = new E_Comprobante();
                    tc.Id_TipCom = Convert.ToInt32(dr["Id_TipCom_Serie"]);
                    s.tipocom = tc;
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return s;
        }

        public int GuardarVenta(String cadXml, int id_tipdocventa)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spGuardarVenta", cn);
                cmd.Parameters.AddWithValue("@Cadxml", cadXml);
                cmd.Parameters.AddWithValue("@TIPO_DOC_VENTA", id_tipdocventa);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                return result;
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
        }


        public List<E_Moneda > ListarMoneda()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Moneda> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarMoneda", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Moneda>();
                while (dr.Read())
                {
                    E_Moneda m = new E_Moneda();
                    m.Id_Moneda = Convert.ToInt32(dr["Id_Moneda"]);
                    m.Descripcion_Moneda = dr["Descripcion_Moneda"].ToString();
                    Lista.Add(m);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

    }
}
