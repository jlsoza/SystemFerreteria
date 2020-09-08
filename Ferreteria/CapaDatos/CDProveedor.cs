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
    public class CDProveedor
    {

        private ConexionBD conexion = new ConexionBD();
        private static readonly CDProveedor _intancia = new CDProveedor();
        public static CDProveedor Instancia
        {
            get { return CDProveedor._intancia; }
        }

        public List<E_Proveedor> ListarProveedor()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Proveedor> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarProveedorCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Proveedor>();
                while (dr.Read())
                {
                    E_Proveedor pr = new E_Proveedor();
                    pr.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    pr.Cod_Proveedor = dr["Cod_Proveedor"].ToString();
                    pr.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    pr.Ruc_Proveedor = dr["Ruc_Proveedor"].ToString();
                    //pr.Direccion_Proveedor = dr["Direccion_Proveedor"].ToString();
                    //pr.Telefono_Proveedor = dr["Telefono_Proveedor"].ToString();
                    //pr.Celular_Proveedor = dr["Celular_Proveedor"].ToString();
                    //pr.Correo_Proveedor = dr["Correo_Proveedor"].ToString();
                    //pr.Estado_Proveedor = Convert.ToInt32(dr["Estado_Proveedor"]);
                    Lista.Add(pr);

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

        public DataTable MostrarProveedor()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeProveedores(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProveedor(string Cod_Proveedor, string RazSocial_Proveedor, string Ruc_Proveedor, string  Direccion_proveedor, string Telefono_Proveedor, string Celular_Proveedor, string Correo_Proveedor, byte Estado_Proveedor, byte[] Imagen)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Cod_Proveedor", Cod_Proveedor);
            comando.Parameters.AddWithValue("@RazSocial_Proveedor", RazSocial_Proveedor);
            comando.Parameters.AddWithValue("@Ruc_Proveedor", Ruc_Proveedor);
            comando.Parameters.AddWithValue("@Direccion_proveedor", Direccion_proveedor);
            comando.Parameters.AddWithValue("@Telefono_Proveedor", Telefono_Proveedor);
            comando.Parameters.AddWithValue("@Celular_Proveedor", Celular_Proveedor);
            comando.Parameters.AddWithValue("@Correo_Proveedor", Correo_Proveedor);
            comando.Parameters.AddWithValue("@Estado_Proveedor", Estado_Proveedor);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarProveedor(int Id_Proveedor, string Cod_Proveedor, string RazSocial_Proveedor, string Ruc_Proveedor, string Direccion_proveedor, string Telefono_Proveedor, string Celular_Proveedor, string Correo_Proveedor, byte Estado_Proveedor, byte[] Imagen)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarProveedor";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            comando.Parameters.AddWithValue("@Cod_Proveedor", Cod_Proveedor);
            comando.Parameters.AddWithValue("@RazSocial_Proveedor", RazSocial_Proveedor);
            comando.Parameters.AddWithValue("@Ruc_Proveedor", Ruc_Proveedor);
            comando.Parameters.AddWithValue("@Direccion_proveedor", Direccion_proveedor);
            comando.Parameters.AddWithValue("@Telefono_Proveedor", Telefono_Proveedor);
            comando.Parameters.AddWithValue("@Celular_Proveedor", Celular_Proveedor);
            comando.Parameters.AddWithValue("@Correo_Proveedor", Correo_Proveedor);
            comando.Parameters.AddWithValue("@Estado_Proveedor", Estado_Proveedor);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarProveedor(int Id_Proveedor)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarProveedor";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
