using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace CapaDatos
{
    public class CD_NivelAcceso
    {

        private static readonly CD_NivelAcceso _intancia = new CD_NivelAcceso();
        public static CD_NivelAcceso Instancia
        {
            get { return CD_NivelAcceso._intancia; }
        }


        public List<E_Nivel_Acceso > ListarNivelAcceso()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Nivel_Acceso> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarNivelAccesoCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Nivel_Acceso>();
                while (dr.Read())
                {
                    E_Nivel_Acceso um = new E_Nivel_Acceso();
                    um.Id_NivelAcc  = Convert.ToInt32(dr["Id_NivelAcc"]);
                    um.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    um.Descripcion_NivelAcc  = dr["Descripcion_NivelAcc"].ToString();
                    Lista.Add(um);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }
    }
}
