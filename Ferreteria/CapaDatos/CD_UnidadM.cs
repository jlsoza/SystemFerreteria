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
    public class CD_UnidadM
    {
        private ConexionBD conexion = new ConexionBD();
        private static readonly CD_UnidadM _intancia = new CD_UnidadM();
        public static CD_UnidadM Instancia
        {
            get { return CD_UnidadM._intancia; }
        }
        public List<E_UnidadMedida> ListarUniMedida()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_UnidadMedida> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarUnidMedCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_UnidadMedida>();
                while (dr.Read())
                {
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    um.Codigo_Umed = dr["Codigo_Umed"].ToString();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    um.Estado_Umed = Convert.ToInt32(dr["Estado_Umed"]);
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

             

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarUnidadM()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarUnidadM";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeUnidadM(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoUnidadM";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

    }
}
