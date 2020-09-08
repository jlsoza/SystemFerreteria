using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime;
using CapaDatos.System.Configuration;

namespace CapaDatos
{
    public class ConexionBD
    {
        private static readonly ConexionBD _instancia = new ConexionBD();
        public static ConexionBD Instancia
        {
            get
            {
                return ConexionBD._instancia;
            }
        }





        public SqlConnection Conexion = new SqlConnection(@"Server = DESKTOP-OBLOVHB\SQLEXPRESS; DataBase = BDFerreteria; Integrated Security = true");

        public SqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
                Conexion.Open();
            return Conexion;
        }

        public SqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }


        public SqlConnection Conectar()
        {
            try
            {
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Data Source=DESKTOP-OBLOVHB\SQLEXPRESS; Initial Catalog=BDFerreteria;User ID=sa; Password=123";
                // cn.ConnectionString = "Data Source=servidorsqleu2016.database.windows.net Initial Catalog=BDLibreria;User ID=master; Password=123456ed*";

                string servidor = ConfigurationManager.Instancia.getServer;
                string database = ConfigurationManager.Instancia.getDatabase;
                string user = ConfigurationManager.Instancia.getUser;
                string clave = ConfigurationManager.Instancia.getClave;


                cn.ConnectionString = "Data Source=" + servidor + "; Initial Catalog = " +
                    database + "; User ID =" + user + " ; Password =" + clave;

                /*Server = tcp:servidorsqleu2016.database.windows.net,1433; Initial Catalog = BDLibreria;
                Persist Security Info = False; User ID = { your_username }; Password ={ your_password};
                MultipleActiveResultSets = False; Encrypt = True; TrustServerCertificate = False; Connection Timeout = 30;
                */
                return cn;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
