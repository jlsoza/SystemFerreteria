using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using CapaDatos;
using Entidades;

namespace CapadeNegocio
{
    public class CN_Usuario
    {

        private static readonly CN_Usuario _instancia = new CN_Usuario();
        public static CN_Usuario Instancia
        {
            get
            {
                return CN_Usuario._instancia;
            }
        }
        public E_usuario  IngresoSisema(String usuario, String password)
        {
            try
            {
                if (usuario == "") throw new ApplicationException("Ingrese un usuario");
                if (password == "") throw new ApplicationException("Ingrese una contraseña");
                E_usuario u = null;
                u = CD_Usuario .Instancia.VerificarAcceso(usuario, password);
                if (u == null)
                {
                    throw new ApplicationException("Usuario ó password invalido");
                }
                else if (u != null)
                {
                    if (u.Estado_Usuario == false)
                    {
                        throw new ApplicationException("Usuario Inactivo");
                    }
                    else if (Convert.ToDateTime(u.Expiracion_Usuario) < DateTime.Now)
                    {
                        throw new ApplicationException("Su fecha de acceso ah expirado");
                    }
                }
                return u;
            }
            catch (Exception)
            {
                throw;
            }

        }



        private CD_Usuario objetoCD = new CD_Usuario();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarUsuario()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarUsuarios ();
            return tabla;
        }
        public DataTable listaDeusuario(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeUsuario (filtro);
            return tabla;
        }
        public void InsertarUsuario(string Codigo_Usuario, int Id_nivelAcc_Usuario, int Id_Suc_Usuario,
            string Nombre_Usuario, string Login_Usuario, string Password_Usuario, string Telefono_Usuario,
            string Celular_Usuario, string Correo_Usuario, Boolean Estado_Usuario, string Expiracion_Usuario,
            string FechCreacion_Usuario)
        {
            objetoCD.InsertarUsuario ( Codigo_Usuario,  Id_nivelAcc_Usuario,  Id_Suc_Usuario,
             Nombre_Usuario,  Login_Usuario,  Password_Usuario,  Telefono_Usuario,
             Celular_Usuario,  Correo_Usuario,  Estado_Usuario,  Expiracion_Usuario,
             FechCreacion_Usuario);
        }
        public void Editarusuario(string  Id_Usuario, string Codigo_Usuario, int Id_nivelAcc_Usuario, int Id_Suc_Usuario,
            string Nombre_Usuario, string Login_Usuario, string Password_Usuario, string Telefono_Usuario,
            string Celular_Usuario, string Correo_Usuario, Boolean Estado_Usuario, string Expiracion_Usuario,
            string FechCreacion_Usuario)
        {
            objetoCD.EditarUsuario (Convert.ToInt32(Id_Usuario),  Codigo_Usuario,  Id_nivelAcc_Usuario,  Id_Suc_Usuario,
             Nombre_Usuario,  Login_Usuario,  Password_Usuario,  Telefono_Usuario,
             Celular_Usuario,  Correo_Usuario,  Estado_Usuario,  Expiracion_Usuario,
             FechCreacion_Usuario);
        }
        public void Eliminarusuario(string Id_Usuario)
        {
            objetoCD.EliminarUsuario (Convert.ToInt32(Id_Usuario));
        }


    }
}
