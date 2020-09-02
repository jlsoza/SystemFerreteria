using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
   public class CD_TipoDocumento
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

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
