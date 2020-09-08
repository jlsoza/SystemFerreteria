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
    public class CN_UnidadM
    {

        private static readonly CN_UnidadM _intancia = new CN_UnidadM();
        public static CN_UnidadM Instancia
        {
            get { return CN_UnidadM._intancia; }
        }

        public List<E_UnidadMedida> ListaUnidadMed()
        {
            try
            {
                return CD_UnidadM.Instancia.ListarUniMedida();
            }
            catch (Exception)
            {
                throw;
            }

        }





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
