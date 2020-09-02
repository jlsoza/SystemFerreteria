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
    public class CN_Moneda
    {
        private CD_Moneda objetoCD = new CD_Moneda();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarMoneda()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarMoneda ();
            return tabla;
        }
        public DataTable listaDeMoneda(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeMoneda (filtro);
            return tabla;
        }
       
    }
}
