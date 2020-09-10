using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace CapaDatos
{
    public class CD_Comprobante
    {
        private static readonly CD_Comprobante _intancia = new CD_Comprobante();
        public static CD_Comprobante Instancia
        {
            get { return CD_Comprobante._intancia; }
        }
        public List<E_Comprobante > ListarTipoComprobante()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Comprobante> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipoComprobanteCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Comprobante>();
                while (dr.Read())
                {
                    E_Comprobante um = new E_Comprobante();
                    um.Id_TipCom  = Convert.ToInt32(dr["Id_TipCom"]);
                    um.Codigo_TipCom  = dr["Codigo_TipCom"].ToString();
                    um.Descripcion_TipDoc = dr["Descripcion_TipDoc"].ToString();
                    um.Nombre_TipCom = dr["Nombre_TipCom"].ToString();
                    um.Descripcion_TipCom = dr["Descripcion_TipCom"].ToString();
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
