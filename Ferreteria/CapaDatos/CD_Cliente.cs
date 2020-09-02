using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_Cliente
    {
        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        public DataTable MostrarCliente()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeCliente(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarCliente(string Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, byte Estado_Cliente, string FechaNac_Cliente,string Sexo_Cliente,string Telefono_Cliente,string Celular_Cliente,string Correo_Cliente,string Direccion_Cliente, string FechCreacion_Cliente, byte[] Foto)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_TipDoc", Id_TipDoc);
            comando.Parameters.AddWithValue("@NumeroDoc_Cliente", NumeroDoc_Cliente);
            comando.Parameters.AddWithValue("@Nombre_Cliente", Nombre_Cliente);
            comando.Parameters.AddWithValue("@FechaNac_Cliente", FechaNac_Cliente);
            comando.Parameters.AddWithValue("@Sexo_Cliente", Sexo_Cliente);
            comando.Parameters.AddWithValue("@Telefono_Cliente", Telefono_Cliente);
            comando.Parameters.AddWithValue("@Celular_Cliente", Celular_Cliente);
            comando.Parameters.AddWithValue("@Correo_Cliente", Correo_Cliente);
            comando.Parameters.AddWithValue("@Direccion_Cliente", Direccion_Cliente);
            comando.Parameters.AddWithValue("@Estado_Cliente", Estado_Cliente);
            comando.Parameters.AddWithValue("@FechCreacion_Cliente", FechCreacion_Cliente);
            comando.Parameters.AddWithValue("@Foto", Foto);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarCliente(int Id_Cliente, string Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, byte Estado_Cliente, string FechaNac_Cliente, string Sexo_Cliente, string Telefono_Cliente, string Celular_Cliente, string Correo_Cliente, string Direccion_Cliente, string FechCreacion_Cliente, byte[] Foto)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);
            comando.Parameters.AddWithValue("@Id_TipDoc", Id_TipDoc);
            comando.Parameters.AddWithValue("@NumeroDoc_Cliente", NumeroDoc_Cliente);
            comando.Parameters.AddWithValue("@Nombre_Cliente", Nombre_Cliente);
            comando.Parameters.AddWithValue("@FechaNac_Cliente", FechaNac_Cliente);
            comando.Parameters.AddWithValue("@Sexo_Cliente", Sexo_Cliente);
            comando.Parameters.AddWithValue("@Telefono_Cliente", Telefono_Cliente);
            comando.Parameters.AddWithValue("@Celular_Cliente", Celular_Cliente);
            comando.Parameters.AddWithValue("@Correo_Cliente", Correo_Cliente);
            comando.Parameters.AddWithValue("@Direccion_Cliente", Direccion_Cliente);
            comando.Parameters.AddWithValue("@Estado_Cliente", Estado_Cliente);
            comando.Parameters.AddWithValue("@FechCreacion_Cliente", FechCreacion_Cliente);
            comando.Parameters.AddWithValue("@Foto", Foto);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarCliente(int Id_Cliente)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Cliente", Id_Cliente);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
