using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Sucursal
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarSucursal()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeSucursal(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarSucursal(string Codigo_Suc, string Direccion_Suc, byte Estado_Suc)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo_Suc", Codigo_Suc);
            comando.Parameters.AddWithValue("@Direccion_Suc", Direccion_Suc);
            comando.Parameters.AddWithValue("@Estado_Suc", Estado_Suc);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarSucursal(int Id_Suc, string Codigo_Suc, string Direccion_Suc, byte Estado_Suc)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarSucursal";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Suc", Id_Suc);
            comando.Parameters.AddWithValue("@Codigo_Suc", Codigo_Suc);
            comando.Parameters.AddWithValue("@Direccion_Suc", Direccion_Suc);
            comando.Parameters.AddWithValue("@Estado_Suc", Estado_Suc);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarSucursal(int Id_Suc)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarSucursal";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Suc", Id_Suc);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
