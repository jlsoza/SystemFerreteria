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
    public class CD_Cliente
    {

        #region singleton
        private static readonly CD_Cliente _intancia = new CD_Cliente();
        public static CD_Cliente Intancia
        {
            get { return CD_Cliente._intancia; }
        }
        #endregion singleton

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

        public void InsertarCliente(int Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, string FechaNac_Cliente, string Sexo_Cliente, string Telefono_Cliente, string Celular_Cliente, string Correo_Cliente,string Direccion_Cliente, byte Estado_Cliente, string FechCreacion_Cliente, byte[] Foto)
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

        public void EditarCliente(int Id_Cliente, int Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, byte Estado_Cliente, string FechaNac_Cliente, string Sexo_Cliente, string Telefono_Cliente, string Celular_Cliente, string Correo_Cliente, string Direccion_Cliente, string FechCreacion_Cliente, byte[] Foto)
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


        public List<E_TipoDoc> ListarTipDoc()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_TipoDoc> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarTipDoc", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_TipoDoc>();
                while (dr.Read())
                {
                    E_TipoDoc td = new E_TipoDoc();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc"]);
                    td.Abreviatura_TipDoc = dr["Abreviatura_TipDoc"].ToString();
                    Lista.Add(td);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public E_cliente BuscarCliente(int id_Cli, String nro_Doc)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            E_cliente c = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarCliente", cn);
                cmd.Parameters.AddWithValue("@prmidCliente", id_Cli);
                cmd.Parameters.AddWithValue("@prmNroDoc", nro_Doc);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    c = new E_cliente();
                    c.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    E_TipoDoc td = new E_TipoDoc();
                    td.Id_TipDoc = Convert.ToInt32(dr["Id_TipDoc"].ToString());
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    c.NumeroDoc_Cliente = dr["NumeroDoc_Cliente"].ToString();
                    c.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    c.Telefono_Cliente = dr["Telefono_Cliente"].ToString();
                    c.Celular_Cliente = dr["Celular_Cliente"].ToString();
                    c.Correo_Cliente = dr["Correo_Cliente"].ToString();
                    c.Direccion_Cliente = dr["Direccion_Cliente"].ToString();
                    c.FechaNac_Cliente = dr["FechaNac_Cliente"].ToString();
                    c.Sexo_Cliente = dr["Sexo_Cliente"].ToString();


                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return c;
        }
        public List<E_cliente > ListarCliente()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_cliente> Lista = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_cliente>();
                while (dr.Read())
                {
                    E_cliente c = new E_cliente();
                    c.Id_Cliente = Convert.ToInt32(dr["Id_Cliente"]);
                    E_TipoDoc  td = new E_TipoDoc();
                    td.Nombre_TipDoc = dr["Nombre_TipDoc"].ToString();
                    c.tipodocumento = td;
                    c.NumeroDoc_Cliente = dr["NumeroDoc_Cliente"].ToString();
                    c.Nombre_Cliente = dr["Nombre_Cliente"].ToString();
                    c.Telefono_Cliente = dr["Telefono_Cliente"].ToString();
                    c.Celular_Cliente = dr["Celular_Cliente"].ToString();
                    c.Correo_Cliente = dr["Correo_Cliente"].ToString();
                    c.Direccion_Cliente = dr["Direccion_Cliente"].ToString();
                    Lista.Add(c);
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
