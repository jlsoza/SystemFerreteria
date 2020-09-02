using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapadeNegocio
{
   public class CN_Sucursal
    {
        private CD_Sucursal objetoCD = new CD_Sucursal();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarSucursal()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarSucursal ();
            return tabla;
        }
        public DataTable listaDeSucursal(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeSucursal (filtro);
            return tabla;
        }
        public void InsertarSucursal(string Codigo_Suc, string Direccion_Suc, byte Estado_Suc)
        {
            objetoCD.InsertarSucursal (Codigo_Suc, Direccion_Suc, Estado_Suc);
        }
        public void EditarSucursal(string Id_Suc, string Codigo_Suc, string Direccion_Suc, byte Estado_Suc)
        {
            objetoCD.EditarSucursal (Convert.ToInt32(Id_Suc), Codigo_Suc, Direccion_Suc, Estado_Suc);
        }
        public void EliminarSucursal(string Id_Suc)
        {
            objetoCD.EliminarSucursal (Convert.ToInt32(Id_Suc));
        }
    }
}
