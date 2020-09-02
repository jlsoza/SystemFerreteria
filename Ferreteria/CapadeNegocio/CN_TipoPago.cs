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
    public class CN_TipoPago
    {
        private CD_TipoPago objetoCD = new CD_TipoPago();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarTipoPago()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTipoPago ();
            return tabla;
        }
        public DataTable listaDeTipoPago(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeTipoPago (filtro);
            return tabla;
        }
    }
}
