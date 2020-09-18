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
   public class CD_Producto
    {
        private ConexionBD conexion = new ConexionBD();
        SqlDataReader leer;
        DataTable tabla = new DataTable();
        SqlCommand comando = new SqlCommand();

        private static readonly CD_Producto _intancia = new CD_Producto();
        public static CD_Producto Instancia
        {
            get { return CD_Producto._intancia; }
        }

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("Tbl_Producto");
            //SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = cn;
                SqlCmd.CommandText = "Sp_Listado_Articulo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }


        public DataTable MostrarProducto()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_MostrarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public DataTable ListaDeProducto(string filtro)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_listadoProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@filtro", filtro);

            leer = comando.ExecuteReader();
            tabla.Clear();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void InsertarProducto(string Codigo_Prod, string Nombre_Prod, int Id_Cat, int Id_Umed, int Id_Proveedor,
         string Marca_Prod, string FechCreacion_Prod, 
         byte Estado_Prod, byte [] CodigoBarra, byte[] Imagen, int UsuarioCreacion_Prod, int UsuarioUpdate_Prod)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_InsertarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Codigo_Prod", Codigo_Prod);
            comando.Parameters.AddWithValue("@Nombre_Prod", Nombre_Prod);
            comando.Parameters.AddWithValue("@Id_Cat", Id_Cat);
            comando.Parameters.AddWithValue("@Id_Umed", Id_Umed);
            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            comando.Parameters.AddWithValue("@Marca_Prod", Marca_Prod);
            //comando.Parameters.AddWithValue("@PrecioCompra_Prod", PrecioCompra_Prod);
            //comando.Parameters.AddWithValue("@Precio_Prod", Precio_Prod);
            //comando.Parameters.AddWithValue("@Stock_Prod", Stock_Prod);
            //comando.Parameters.AddWithValue("@StockProm_Prod", StockProm_Prod);
            //comando.Parameters.AddWithValue("@StockMin_Prod", StockMin_Prod);
            comando.Parameters.AddWithValue("@FechCreacion_Prod", FechCreacion_Prod);
            //comando.Parameters.AddWithValue("@UsuarioCreacion_Prod", UsuarioCreacion_Prod);
            //comando.Parameters.AddWithValue("@FechUpdate_Prod", FechUpdate_Prod);
            //comando.Parameters.AddWithValue("@UsuarioUpdate_Prod", UsuarioUpdate_Prod);
            comando.Parameters.AddWithValue("@Estado_Prod", Estado_Prod);
            comando.Parameters.AddWithValue("@CodigoBarra", CodigoBarra);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            comando.Parameters.AddWithValue("@UsuarioCreacion_Prod", UsuarioCreacion_Prod);
            comando.Parameters.AddWithValue("@UsuarioUpdate_Prod", UsuarioUpdate_Prod);


            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public void EditarProducto(int Id_Prod, string Codigo_Prod, string Nombre_Prod, int Id_Cat, int Id_Umed, int Id_Proveedor,
         string Marca_Prod,string FechCreacion_Prod,
          byte Estado_Prod, byte[] CodigoBarra, byte[] Imagen,  int UsuarioUpdate_Prod)
        {
            //PROCEDIMIENTO
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EditarProducto";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@Id_Prod", Id_Prod);
            comando.Parameters.AddWithValue("@Codigo_Prod", Codigo_Prod);
            comando.Parameters.AddWithValue("@Nombre_Prod", Nombre_Prod);
            comando.Parameters.AddWithValue("@Id_Cat", Id_Cat);
            comando.Parameters.AddWithValue("@Id_Umed", Id_Umed);
            comando.Parameters.AddWithValue("@Id_Proveedor", Id_Proveedor);
            comando.Parameters.AddWithValue("@Marca_Prod", Marca_Prod);
            //comando.Parameters.AddWithValue("@PrecioCompra_Prod", PrecioCompra_Prod);
            //comando.Parameters.AddWithValue("@Precio_Prod", Precio_Prod);
            //comando.Parameters.AddWithValue("@Stock_Prod", Stock_Prod);
            //comando.Parameters.AddWithValue("@StockProm_Prod", StockProm_Prod);
            //comando.Parameters.AddWithValue("@StockMin_Prod", StockMin_Prod);
            comando.Parameters.AddWithValue("@FechCreacion_Prod", FechCreacion_Prod);
            //comando.Parameters.AddWithValue("@UsuarioCreacion_Prod", UsuarioCreacion_Prod);
            //comando.Parameters.AddWithValue("@FechUpdate_Prod", FechUpdate_Prod);
            //comando.Parameters.AddWithValue("@UsuarioUpdate_Prod", UsuarioUpdate_Prod);
            comando.Parameters.AddWithValue("@Estado_Prod", Estado_Prod);
            comando.Parameters.AddWithValue("@CodigoBarra", CodigoBarra);
            comando.Parameters.AddWithValue("@Imagen", Imagen);
            //comando.Parameters.AddWithValue("@UsuarioCreacion_Prod", UsuarioCreacion_Prod);
            comando.Parameters.AddWithValue("@UsuarioUpdate_Prod", UsuarioUpdate_Prod);
            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        public void EliminarProducto(int Id_Prod)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "Sp_EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@Id_Prod", Id_Prod);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }


        public List<E_Categoria> ListarCategoria()
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Categoria> Lista = null;
            try
            {

                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spListarCategoriaCombo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Categoria>();
                while (dr.Read())
                {
                    E_Categoria c = new E_Categoria();
                    c.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    c.Codigo_Cat = dr["Codigo_Cat"].ToString();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    c.Descripcion_Cat = dr["Descripcion_Cat"].ToString();
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

        public List<E_Producto> ListarProductoIndicador(String codigo, int id_cat, int rango)
        {
            SqlCommand cmd = null;
            List<E_Producto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                //// cmd.Connection = conexion.AbrirConexion();
                // cmd.Connection = conexion.AbrirConexion();
                // cmd.CommandText = "Sp_ListarProdStatus";
                // cmd.CommandType = CommandType.StoredProcedure;
                // cmd.Parameters.AddWithValue("@prmCodigo", codigo);
                // cmd.Parameters.AddWithValue("@prmcat", id_cat);
                // cmd.Parameters.AddWithValue("@prmstockrango", rango);
                // dr = cmd.ExecuteReader();
                // cmd.Parameters.Clear();


                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarProdStatus", cn);
                cmd.Parameters.AddWithValue("@prmCodigo", codigo);
                cmd.Parameters.AddWithValue("@prmcat", id_cat);
                cmd.Parameters.AddWithValue("@prmstockrango", rango);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Producto>();
                while (dr.Read())
                {
                    E_Producto p = new E_Producto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    p.Precio_Prod = Convert.ToDouble(dr["Precio_Prod"]);
                    p.Stock_Prod = Convert.ToInt32(dr["Stock_Prod"]);
                    p.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    p.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    E_Categoria c = new E_Categoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
                    p.unidmedida = um;
                    //entMaterial m = new entMaterial();
                    //m.Nombre = dr["Nombre_Material"].ToString();
                    //p.material = m;
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public E_Producto BuscarProducto(int id_producto)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            E_Producto p = null;
            try
            {
                //cmd.Connection = conexion.AbrirConexion();
                //cmd.CommandText = "spBuscarProducto";
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@prmId_Prod", id_producto);
                //dr = cmd.ExecuteReader();
                //cmd.Parameters.Clear();


                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProducto", cn);
                cmd.Parameters.AddWithValue("@prmId_Prod", id_producto);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    p = new E_Producto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    p.PrecioCompra_Prod = Convert.ToDouble(dr["precio_venta"].ToString());
                    p.Precio_Prod = Convert.ToDouble(dr["stock_actual"].ToString());
                    E_Categoria c = new E_Categoria();
                    c.Id_Cat = Convert.ToInt32(dr["Id_Cat"]);
                    p.categoria = c;
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Id_Umed = Convert.ToInt32(dr["Id_Umed"]);
                    p.unidmedida = um;
                    E_Proveedor pr = new E_Proveedor();
                    pr.Id_Proveedor = Convert.ToInt32(dr["Id_Proveedor"]);
                    p.proveedor = pr;
                    //entMaterial m = new entMaterial();
                    //m.Id = Convert.ToInt32(dr["Id_Material"]);
                    //p.material = m;


                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return p;
        }


        public List<E_Producto> BuscarProductoAvanzada(int tip_entrada, String valor_entrada)
        {
            SqlCommand cmd = null;
            SqlDataReader dr = null;
            List<E_Producto> Lista = null;
            try
            {

                //cmd.Connection = conexion.AbrirConexion();
                //cmd.CommandText = "spBuscarProdAvanzada";
                //cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.AddWithValue("@prmTipEntrada", tip_entrada);
                //cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);
                //dr= cmd.ExecuteReader();
                //cmd.Parameters.Clear();


                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("spBuscarProdAvanzada", cn);
                cmd.Parameters.AddWithValue("@prmTipEntrada", tip_entrada);
                cmd.Parameters.AddWithValue("@prmValorEntrada", valor_entrada);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Producto>();
                while (dr.Read())
                {
                    E_Producto p = new E_Producto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    p.Precio_Prod = Convert.ToDouble(dr["precio_venta"].ToString());
                    p.Stock_Prod = Convert.ToInt32(dr["stock_actual"]);
                    E_Categoria c = new E_Categoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    p.unidmedida = um;
                    //entMaterial m = new entMaterial();
                    //m.Nombre = dr["Nombre_Material"].ToString();
                    //p.material = m;
                    Lista.Add(p);

                }
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }


        public List<E_Producto> ListarProducto()
        {
            SqlCommand cmd = null;
            List<E_Producto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                

                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("Sp_ListarProducto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Producto>();
                while (dr.Read())
                {
                    E_Producto p = new E_Producto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.Marca_Prod = dr["Marca_Prod"].ToString();
                    E_Categoria c = new E_Categoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Descripcion_Umed = dr["Descripcion_Umed"].ToString();
                    p.unidmedida = um;
                    E_Proveedor pr = new E_Proveedor();
                    pr.RazSocial_Proveedor = dr["RazSocial_Proveedor"].ToString();
                    p.proveedor = pr;
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public List<E_Producto> LstProdIndicadorAvanzada(String name)
        {
            SqlCommand cmd = null;
            List<E_Producto> Lista = null;
            SqlDataReader dr = null;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("splistarProdIndicador", cn);
                cmd.Parameters.AddWithValue("@prmname", name);

                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                dr = cmd.ExecuteReader();
                Lista = new List<E_Producto>();
                while (dr.Read())
                {
                    E_Producto p = new E_Producto();
                    p.Id_Prod = Convert.ToInt32(dr["Id_Prod"]);
                    p.Codigo_Prod = dr["Codigo_Prod"].ToString();
                    p.Nombre_Prod = dr["Nombre_Prod"].ToString();
                    p.PrecioCompra_Prod = Convert.ToDouble(dr["PrecioCompra_Prod"]);
                    p.Precio_Prod = Convert.ToDouble(dr["precio_venta"]);
                    p.Stock_Prod = Convert.ToInt32(dr["stock_actual"]);
                    //p.StockProm_Prod = Convert.ToInt32(dr["StockProm_Prod"]);
                    //p.StockMin_Prod = Convert.ToInt32(dr["StockMin_Prod"]);

                    E_Categoria c = new E_Categoria();
                    c.Nombre_Cat = dr["Nombre_Cat"].ToString();
                    p.categoria = c;
                    E_UnidadMedida um = new E_UnidadMedida();
                    um.Abreviatura_Umed = dr["Abreviatura_Umed"].ToString();
               
                    Lista.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally { cmd.Connection.Close(); }
            return Lista;
        }

        public int MantenimientoProducto(String cadXml)
        {
            SqlCommand cmd = null;
            var result = 0;
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                cmd = new SqlCommand("Sp_Ins_Edit_Elim_Producto", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@prmCadXml", cadXml);
                cmd.CommandType = CommandType.StoredProcedure;
                cn.Open();
                result = cmd.ExecuteNonQuery();
                             
            }
            catch (Exception)
            {
                throw;
            }
            finally { cmd.Connection.Close(); }
            return result;
        }

        public DataTable Stock_Articulos()
        {
            DataTable DtResultado = new DataTable("Tbl_Producto");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
               // SqlCon.ConnectionString = Conexion.Cn;
                SqlConnection cn = ConexionBD.Instancia.Conectar();

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = cn;
                SqlCmd.CommandText = "spstock_articulos";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

    }
}
