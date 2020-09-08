using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapadeNegocio
{
    public class CNProveedor
    {

        private static readonly CNProveedor _intancia = new CNProveedor();
        public static CNProveedor Instancia
        {
            get { return CNProveedor._intancia; }
        }

        public List<E_Proveedor> ListaProveedor()
        {
            try
            {
                return CDProveedor.Instancia.ListarProveedor();
            }
            catch (Exception)
            {
                throw;
            }

        }






        private CDProveedor objetoCD = new CDProveedor();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarProveedor()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarProveedor();
            return tabla;
        }
        public DataTable listaDeProveedor(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeProveedores(filtro);
            return tabla;
        }


        public void InsertarProveedor(string Cod_Proveedor, string RazSocial_Proveedor, string Ruc_Proveedor, string Direccion_proveedor, string Telefono_Proveedor, string Celular_Proveedor, string Correo_Proveedor, byte Estado_Proveedor, byte[] Imagen)
        {
            objetoCD.InsertarProveedor(Cod_Proveedor, RazSocial_Proveedor, Ruc_Proveedor, Direccion_proveedor, Telefono_Proveedor, Celular_Proveedor, Correo_Proveedor, Estado_Proveedor, Imagen);
        }
        public void EditarProveedor(string Id_Proveedor, string Cod_Proveedor, string RazSocial_Proveedor, string Ruc_Proveedor, string Direccion_proveedor, string Telefono_Proveedor, string Celular_Proveedor, string Correo_Proveedor, byte Estado_Proveedor, byte[] Imagen)
        {
            objetoCD.EditarProveedor(Convert.ToInt32(Id_Proveedor), Cod_Proveedor, RazSocial_Proveedor, Ruc_Proveedor, Direccion_proveedor, Telefono_Proveedor, Celular_Proveedor, Correo_Proveedor, Estado_Proveedor, Imagen);
        }
        public void EliminarProveedor(string Id_Proveedor)
        {
            objetoCD.EliminarProveedor(Convert.ToInt32(Id_Proveedor));
        }
    }
}
