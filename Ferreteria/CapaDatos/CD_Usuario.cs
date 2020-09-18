using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace CapaDatos
{
    public class CD_Usuario
    {

        private static readonly CD_Usuario _instancia = new CD_Usuario();
        public static CD_Usuario Instancia
        {
            get { return CD_Usuario._instancia; }
        }

        private ConexionBD conexion = new ConexionBD();

        SqlDataReader leer;
        DataTable tabla = new DataTable();

        SqlCommand comando = new SqlCommand();

  //      public int Id_Usuario { get; set; }
		//public String Codigo_Usuario { get; set; }
		//public int Id_nivelAcc_Usuario { get; set; }
		//public int Id_Suc_Usuario { get; set; }
		//public String Nombre_Usuario { get; set; }
		//public String Login_Usuario { get; set; }
		//public String Password_Usuario { get; set; }

		//public String Telefono_Usuario { get; set; }
		//public String Celular_Usuario { get; set; }
		//public String Correo_Usuario { get; set; }
		//public byte  Estado_Usuario { get; set; }

		//public DateTime Expiracion_Usuario { get; set; }
	 //   public DateTime FechCreacion_Usuario { get; set; }


        public DataTable MostrarUsuarios()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeUsuario(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoUsuarios";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarUsuario(string Codigo_Usuario, int Id_nivelAcc_Usuario, int Id_Suc_Usuario,
            string Nombre_Usuario, string Login_Usuario, string Password_Usuario, string Telefono_Usuario,
            string Celular_Usuario, string Correo_Usuario, Boolean Estado_Usuario, string Expiracion_Usuario,
            string FechCreacion_Usuario)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo_Usuario", Codigo_Usuario);
            comando.Parameters.AddWithValue("@Id_nivelAcc_Usuario", Id_nivelAcc_Usuario);
            comando.Parameters.AddWithValue("@Id_Suc_Usuario", Id_Suc_Usuario);
            comando.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
            comando.Parameters.AddWithValue("@Login_Usuario", Login_Usuario);
            comando.Parameters.AddWithValue("@Password_Usuario", Password_Usuario);
            comando.Parameters.AddWithValue("@Telefono_Usuario", Telefono_Usuario);
            comando.Parameters.AddWithValue("@Celular_Usuario", Celular_Usuario);
            comando.Parameters.AddWithValue("@Correo_Usuario", Correo_Usuario);
            comando.Parameters.AddWithValue("@Estado_Usuario", Estado_Usuario);
            comando.Parameters.AddWithValue("@Expiracion_Usuario", Expiracion_Usuario);
            comando.Parameters.AddWithValue("@FechCreacion_Usuario", FechCreacion_Usuario);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarUsuario(int Id_Usuario, string Codigo_Usuario, int Id_nivelAcc_Usuario, int Id_Suc_Usuario,
            string Nombre_Usuario, string Login_Usuario, string Password_Usuario, string Telefono_Usuario,
            string Celular_Usuario, string Correo_Usuario, bool  Estado_Usuario, string Expiracion_Usuario,
            string FechCreacion_Usuario)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarUsuario";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);
            comando.Parameters.AddWithValue("@Codigo_Usuario", Codigo_Usuario);
            comando.Parameters.AddWithValue("@Id_nivelAcc_Usuario", Id_nivelAcc_Usuario);
            comando.Parameters.AddWithValue("@Id_Suc_Usuario", Id_Suc_Usuario);
            comando.Parameters.AddWithValue("@Nombre_Usuario", Nombre_Usuario);
            comando.Parameters.AddWithValue("@Login_Usuario", Login_Usuario);
            comando.Parameters.AddWithValue("@Password_Usuario", Password_Usuario);
            comando.Parameters.AddWithValue("@Telefono_Usuario", Telefono_Usuario);
            comando.Parameters.AddWithValue("@Celular_Usuario", Celular_Usuario);
            comando.Parameters.AddWithValue("@Correo_Usuario", Correo_Usuario);
            comando.Parameters.AddWithValue("@Estado_Usuario", Estado_Usuario);
            comando.Parameters.AddWithValue("@Expiracion_Usuario", Expiracion_Usuario);
            comando.Parameters.AddWithValue("@FechCreacion_Usuario", FechCreacion_Usuario);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
        public void EliminarUsuario(int Id_Usuario)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarUsuario";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Usuario", Id_Usuario);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }




        public E_usuario VerificarAcceso(String usuario, String clave)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            E_usuario u = null;
            try
            {

                SqlConnection cn = ConexionBD.Instancia.Conectar();

                //SqlConnection cn = Conexion.Instancia.Conectar();
                cmd = new SqlCommand("spVerificarAcceso", cn);
                cmd.Parameters.AddWithValue("@prmUsuario", usuario);
                cmd.Parameters.AddWithValue("@prmpassword", clave);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new E_usuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                    u.Expiracion_Usuario = dr["Expiracion_Usuario"].ToString();
                    u.Estado_Usuario = Convert.ToBoolean(dr["Estado_Usuario"]);
                    E_Nivel_Acceso  na = new E_Nivel_Acceso();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    u.nivel_acceso = na;
                    E_Sucursal  s = new E_Sucursal();
                    s.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    s.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    u.sucursal = s;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }


        public E_usuario  BuscarUusario(String por, String valor)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            E_usuario u = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarUsuario", cn);
                cmd.Parameters.AddWithValue("@prmBusqueda", por);
                cmd.Parameters.AddWithValue("@prmValor", valor);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    u = new E_usuario();
                    u.Id_Usuario = Convert.ToInt32(dr["Id_Usuario"]);
                    u.Codigo_Usuario = dr["Codigo_Usuario"].ToString();
                    u.Nombre_Usuario = dr["Nombre_Usuario"].ToString();
                    u.Login_Usuario = dr["Login_Usuario"].ToString();
                    u.Password_Usuario = dr["Password_Usuario"].ToString();
                    u.Telefono_Usuario = dr["Telefono_Usuario"].ToString();
                    u.Celular_Usuario = dr["Celular_Usuario"].ToString();
                    u.Correo_Usuario = dr["Correo_Usuario"].ToString();
                    //u.DominoCorreo_Usuario = dr["DominoCorreo_Usuario"].ToString();
                    u.Estado_Usuario = Convert.ToBoolean(dr["Estado_Usuario"]);
                    u.Expiracion_Usuario = dr["Expiracion_Usuario"].ToString();
                    E_Nivel_Acceso na = new E_Nivel_Acceso();
                    na.Id_NivelAcc = Convert.ToInt32(dr["Id_NivelAcc"]);
                    na.Numero_NivelAcc = Convert.ToInt32(dr["Numero_NivelAcc"]);
                    u.nivel_acceso = na;
                    E_Sucursal  s = new E_Sucursal();
                    s.Id_Suc = Convert.ToInt32(dr["Id_Suc"]);
                    s.Direccion_Suc = dr["Direccion_Suc"].ToString();
                    s.Codigo_Suc = dr["Codigo_Suc"].ToString();
                    u.sucursal = s;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return u;
        }

        public E_usuario  BuscarUsario(String por, String valor)
        {
            try
            {
                if (por.Equals("<<<< Seleccionar >>>>"))
                {
                    throw new ApplicationException("Seleccione el campo de busqueda");
                }
                E_usuario u = null;
                u = BuscarUusario(por, valor);
                if (u == null)
                {
                    throw new ApplicationException("No se encontraron registros");
                }
                return u;
            }
            catch (Exception)
            {

                throw;
            }
        }


















    }
}
