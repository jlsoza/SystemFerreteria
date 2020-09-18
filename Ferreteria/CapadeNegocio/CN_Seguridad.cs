using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapadeNegocio
{
    public class CN_Seguridad
    {
        #region singleton
        private static readonly CN_Seguridad _instancia = new CN_Seguridad();
        public static CN_Seguridad Instancia
        {
            get
            {
                return CN_Seguridad._instancia;
            }
        }
        #endregion

        public E_usuario  BuscarUsario(String por, String valor)
        {
            try
            {
                if (por.Equals("<<<< Seleccionar >>>>"))
                {
                    throw new ApplicationException("Seleccione el campo de busqueda");
                }
                E_usuario u = null;
                u = CD_Usuario .Instancia.BuscarUusario(por, valor);
                if (u == null)
                {
                    throw new ApplicationException("No se encontraron registros");
                }
                return u;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
