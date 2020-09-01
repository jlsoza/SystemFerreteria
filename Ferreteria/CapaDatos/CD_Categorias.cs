using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;

namespace CapaDatos
{
    public class CD_Categorias
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCategoria()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeCategorias(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCategoria(string Codigo_Cat, string Nombre_Cat, string Descripcion_Cat, byte Estado_Categoria, string Fecha, byte[] Imagen)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo_Cat", Codigo_Cat);
            comando.Parameters.AddWithValue("@Nombre_Cat", Nombre_Cat);
            comando.Parameters.AddWithValue("@Descripcion_Cat", Descripcion_Cat);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Estado_Categoria", Estado_Categoria);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarCategorias(int Id_Cat,string Codigo_Cat, string Nombre_Cat, string Descripcion_Cat, byte Estado_Categoria, string Fecha, byte[] Imagen)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Cat", Id_Cat);
            comando.Parameters.AddWithValue("@Codigo_Cat", Codigo_Cat);
            comando.Parameters.AddWithValue("@Nombre_Cat", Nombre_Cat);
            comando.Parameters.AddWithValue("@Descripcion_Cat", Descripcion_Cat);
            comando.Parameters.AddWithValue("@Fecha", Fecha);
            comando.Parameters.AddWithValue("@Estado_Categoria", Estado_Categoria);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarCategoria(int Id_Cat)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Cat", Id_Cat);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }


}
