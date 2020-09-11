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
    public class CD_Sucursal
    {
        private static readonly CD_Sucursal _intancia = new CD_Sucursal();
        public static CD_Sucursal Instancia
        {
            get { return CD_Sucursal._intancia; }
        }

        public List<E_Sucursal> ListarSucursalCombo()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Sucursal> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarSucursalCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Sucursal>();
                while (dr.Read())
                {
                    E_Sucursal um = new E_Sucursal();
                    um.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    um.Codigo_Suc = dr["Codigo_Suc"].ToString();
                    um.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    um.Estado_Suc = dr["Estado_Suc"].ToString();
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
