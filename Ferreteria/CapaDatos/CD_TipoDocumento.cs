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
   public class CD_TipoDocumento
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private static readonly CD_TipoDocumento _intancia = new CD_TipoDocumento();
        public static CD_TipoDocumento Instancia
        {
            get { return CD_TipoDocumento._intancia; }
        }


        public List<E_TipoDoc> ListarTipoDoc()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_TipoDoc> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipDocCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_TipoDoc>();
                while (dr.Read())
                {
                    E_TipoDoc um = new E_TipoDoc();
                    um.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc"]);
                    um.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    um.Abreviatura_TipDoc = dr["Abreviatura_TipDoc"].ToString();
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


        public DataTable MostrarTipoDoc()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarTipoDocumento";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeTipoDoc(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoTipoDoc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarTipoDoc(string Nombre_TipDoc, string Abreviatura_TipDoc)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoTipoDoc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Nombre_TipDoc", Nombre_TipDoc);
            comando.Parameters.AddWithValue("@Abreviatura_TipDoc", Abreviatura_TipDoc);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarTipoDoc(int Id_TipDoc, string Nombre_TipDoc, string Abreviatura_TipDoc)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarTipoDoc";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_TipDoc", Id_TipDoc);
            comando.Parameters.AddWithValue("@Nombre_TipDoc", Nombre_TipDoc);
            comando.Parameters.AddWithValue("@Abreviatura_TipDoc", Abreviatura_TipDoc);
         
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarTipoDoc(int Id_TipDoc)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarTipoDoc";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_TipDoc", Id_TipDoc);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
