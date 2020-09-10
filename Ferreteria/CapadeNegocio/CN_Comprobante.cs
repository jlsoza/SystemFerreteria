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
    public class CN_Comprobante
    {
        private static readonly CN_Comprobante _intancia = new CN_Comprobante();
        public static CN_Comprobante Instancia
        {
            get { return CN_Comprobante._intancia; }
        }

        public List<E_Comprobante > ListaTipoComprobante()
        {
            try
            {
                return CD_Comprobante .Instancia.ListarTipoComprobante();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
