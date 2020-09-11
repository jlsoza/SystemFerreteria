using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;
namespace CapadeNegocio
{
    public class CN_NivelAcceso
    {
        private static readonly CN_NivelAcceso _intancia = new CN_NivelAcceso();
        public static CN_NivelAcceso Instancia
        {
            get { return CN_NivelAcceso._intancia; }
        }

        public List<E_Nivel_Acceso > ListaNivelAcceso()
        {
            try
            {
                return CD_NivelAcceso .Instancia.ListarNivelAcceso ();
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
