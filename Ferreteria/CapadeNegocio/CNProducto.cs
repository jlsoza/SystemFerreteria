using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapadeNegocio
{
   public class CNProducto
    {

        private CD_Producto objetoCD = new CD_Producto();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        /// 

        public static DataTable Mostrar()
        {
            return new CD_Producto().Mostrar();
        }

        public DataTable MostrarProducto()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProducto();
            return tabla;
        }
        public DataTable listaDeProducto(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeProducto(filtro);
            return tabla;
        }
        public void InsertarProducto(string Codigo_Prod, string Nombre_Prod, int Id_Cat, int Id_Umed, int Id_Proveedor,
         string Marca_Prod,string FechCreacion_Prod,
          byte Estado_Prod,  byte[] CodigoBarra, byte[] Imagen, int UsuarioCreacion_Prod, int UsuarioUpdate_Prod)
        {
            objetoCD.InsertarProducto(Codigo_Prod, Nombre_Prod, Id_Cat, Id_Umed, Id_Proveedor,
                Marca_Prod,FechCreacion_Prod,
                Estado_Prod, CodigoBarra, Imagen, UsuarioCreacion_Prod, UsuarioUpdate_Prod);
        }
        public void EditarProducto(string Id_Prod, string Codigo_Prod, string Nombre_Prod, int Id_Cat, int Id_Umed, int Id_Proveedor,
         string Marca_Prod, string FechCreacion_Prod
         , byte Estado_Prod, byte[] CodigoBarra, byte[] Imagen, int UsuarioUpdate_Prod)
        {
            objetoCD.EditarProducto(Convert.ToInt32(Id_Prod), Codigo_Prod, Nombre_Prod, Id_Cat, Id_Umed, Id_Proveedor,
                Marca_Prod,FechCreacion_Prod,
                Estado_Prod, CodigoBarra, Imagen, UsuarioUpdate_Prod);
        }
        public void EliminarProducto(string Id_Prod)
        {
            objetoCD.EliminarProducto(Convert.ToInt32(Id_Prod));
        }




        private static readonly CNProducto _intancia = new CNProducto();
        public static CNProducto Instancia
        {
            get { return CNProducto._intancia; }
        }

        public List<E_Categoria> ListaCategoria()
        {
            try
            {
                return CD_Producto.Instancia.ListarCategoria();
            }
            catch (Exception)
            {
                throw;
            }

        }

        public List<E_Producto> ListarProducto()
        {
            try
            {
                List<E_Producto> Lista = null;
                Lista = CD_Producto.Instancia.ListarProducto();
                if (Lista.Count == 0) throw new ApplicationException("Lista de productos vacia");
                else if (Lista == null) throw new ApplicationException("Se produjo un error en la carga de la lista de productos");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public E_Producto  BuscarProducto(int id_producto)
        {
            try
            {
                E_Producto p = null;
                p = CD_Producto .Instancia.BuscarProducto(id_producto);
                if (p == null) throw new ApplicationException("No se encontro producto seleccionado en la BD");
                return p;
            }
            catch (Exception)
            {

                throw;
            }
        }


        public List<E_Producto> BuscarprodAvanzadaIndicador(String name)
        {
            try
            {
                List<E_Producto> Lista = null;
                Lista = CD_Producto.Instancia.LstProdIndicadorAvanzada(name);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<E_Producto> BuscarprodAvanzada(int tip_busq, String val_busqueda)
        {
            try
            {
                List<E_Producto> Lista = null;
                Lista = CD_Producto .Instancia.BuscarProductoAvanzada(tip_busq, val_busqueda);
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int MantenimientoProducto(E_Producto p, int tipoedicion)
        {
            try
            {

                String cadXml = "";
                cadXml += "<producto ";
                cadXml += "idproducto='" + p.Id_Prod + "' ";
                cadXml += "idcat='" + p.categoria.Id_Cat + "' ";
                cadXml += "idunmed='" + p.unidmedida.Id_Umed + "' ";
                cadXml += "idprov='" + p.proveedor.Id_Proveedor + "' ";
                cadXml += "nombre='" + p.Nombre_Prod + "' ";
                cadXml += "marca='" + p.Marca_Prod + "' ";
                cadXml += "preciocompra='" + p.PrecioCompra_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "precio='" + p.Precio_Prod.ToString().Replace(",", ".") + "' ";
                cadXml += "stock='" + p.Stock_Prod + "' ";
                cadXml += "stockprom='" + p.StockProm_Prod + "' ";
                cadXml += "stockmin='" + p.StockMin_Prod + "' ";
                cadXml += "usuariocreacion='" + p.UsuarioCreacion_Prod + "' ";
                cadXml += "usuarioupdate='" + p.UsuarioUpdate_Prod + "' ";
                cadXml += "tipoedicion='" + tipoedicion + "' ";
             

                cadXml = "<root>" + cadXml + "</root>";
                int i = CD_Producto.Instancia.MantenimientoProducto(cadXml);
                if (i <= 0)
                {
                    throw new ApplicationException("No se pudo completar la acción, Intentelo otra vez");
                }
                return i;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static DataTable Stock_Articulos()
        {
            return new CD_Producto ().Stock_Articulos();
        }

    }
}
