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
    public class CN_UnidadM
    {
        private CD_UnidadM objetoCD = new CD_UnidadM();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarUnidadM()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarUnidadM();
            return tabla;
        }
        public DataTable listaDeUnidadM(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeUnidadM(filtro);
            return tabla;
        }
    }
}
