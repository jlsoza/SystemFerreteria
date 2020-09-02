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
    public class CN_TipoMovimiento
    {
        private CD_TipoMovimiento objetoCD = new CD_TipoMovimiento();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarTipoMov()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTipoMovimiento();
            return tabla;
        }
        public DataTable listaDeTipoMov(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeTipoMov(filtro);
            return tabla;
        }
    }
}
