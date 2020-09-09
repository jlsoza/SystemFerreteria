using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace CapaDatos
{
    public class CD_DetalleIngreso
    {

        //Variables  
        private int _Iddetalle_ingreso;
        private int _Idingreso;
        private int _Idarticulo;
        private decimal _Precio_Compra;
        private decimal _precio_Venta;
        private int _Stock_Inicial;
        private int _Stock_Actual;
        private DateTime _Fecha_Produccion;
        private DateTime _Fecha_Vencimiento;
        private string _TextoBuscar;
        private string textobuscar;


        public string TextoBuscar
        {
            get { return _TextoBuscar; }
            set { _TextoBuscar = value; }
        }

        //Propiedades  
        public int Iddetalle_ingreso
        {
            get { return _Iddetalle_ingreso; }
            set { _Iddetalle_ingreso = value; }
        }

        public int Idingreso
        {
            get { return _Idingreso; }
            set { _Idingreso = value; }
        }

        public int Idarticulo
        {
            get { return _Idarticulo; }
            set { _Idarticulo = value; }
        }

        public decimal Precio_Compra
        {
            get { return _Precio_Compra; }
            set { _Precio_Compra = value; }
        }

        public decimal Precio_Venta
        {
            get { return _precio_Venta; }
            set { _precio_Venta = value; }
        }

        public int Stock_Inicial
        {
            get { return _Stock_Inicial; }
            set { _Stock_Inicial = value; }
        }

        public int Stock_Actual
        {
            get { return _Stock_Actual; }
            set { _Stock_Actual = value; }
        }


        public DateTime Fecha_Produccion
        {
            get { return _Fecha_Produccion; }
            set { _Fecha_Produccion = value; }
        }

        public DateTime Fecha_Vencimiento
        {
            get { return _Fecha_Vencimiento; }
            set { _Fecha_Vencimiento = value; }
        }

        //Constructores  
        public CD_DetalleIngreso()
        {


        }
        public CD_DetalleIngreso(int iddetalle_ingreso, int idingreso, int idarticulo, decimal precio_compra, decimal precio_venta, int stock_inicial, int stock_actual, DateTime fecha_produccion, DateTime fecha_vencimiento, string textoBuscar)
        {
            this.Iddetalle_ingreso = iddetalle_ingreso;
            this.Idingreso = idingreso;
            this.Idarticulo = idarticulo;
            this.Precio_Compra = precio_compra;
            this.Precio_Venta = precio_venta;
            this.Stock_Inicial = stock_inicial;
            this.Stock_Actual = stock_actual;
            this.Fecha_Produccion = fecha_produccion;
            this.Fecha_Vencimiento = fecha_vencimiento;
            this.TextoBuscar = textobuscar;


        }


        //Método Insertar  
        public string Insertar(CD_DetalleIngreso Detalle_Ingreso, ref SqlConnection SqlCon, ref SqlTransaction SqlTra)
        {
            string rpta = "";
            try
            {

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinsertar_detalle_ingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParIddetalle_ingreso = new SqlParameter();
                ParIddetalle_ingreso.ParameterName = "@iddetalle_ingreso";
                ParIddetalle_ingreso.SqlDbType = SqlDbType.Int;
                ParIddetalle_ingreso.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParIddetalle_ingreso);

                SqlParameter ParIdingreso = new SqlParameter();
                ParIdingreso.ParameterName = "@idingreso";
                ParIdingreso.SqlDbType = SqlDbType.Int;
                ParIdingreso.Value = Detalle_Ingreso.Idingreso;
                SqlCmd.Parameters.Add(ParIdingreso);

                SqlParameter ParIdarticulo = new SqlParameter();
                ParIdarticulo.ParameterName = "@idarticulo";
                ParIdarticulo.SqlDbType = SqlDbType.Int;
                ParIdarticulo.Value = Detalle_Ingreso.Idarticulo;
                SqlCmd.Parameters.Add(ParIdarticulo);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@precio_compra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Decimal;
                //ParPrecio_Compra.Precision = 10;
                //ParPrecio_Compra.Scale = 2;
                ParPrecio_Compra.Value = Detalle_Ingreso.Precio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@precio_venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                //ParPrecio_Venta.Precision = 10;
                //ParPrecio_Venta.Scale = 2;
                ParPrecio_Venta.Value = Detalle_Ingreso.Precio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParStock_Inicial = new SqlParameter();
                ParStock_Inicial.ParameterName = "@stock_inicial";
                ParStock_Inicial.SqlDbType = SqlDbType.Int;
                ParStock_Inicial.Value = Detalle_Ingreso.Stock_Inicial;
                SqlCmd.Parameters.Add(ParStock_Inicial);

                SqlParameter ParStock_Actual = new SqlParameter();
                ParStock_Actual.ParameterName = "@stock_actual";
                ParStock_Actual.SqlDbType = SqlDbType.Int;
                ParStock_Actual.Value = Detalle_Ingreso.Stock_Actual;
                SqlCmd.Parameters.Add(ParStock_Actual);

                SqlParameter ParFecha_Produccion = new SqlParameter();
                ParFecha_Produccion.ParameterName = "@fecha_produccion";
                ParFecha_Produccion.SqlDbType = SqlDbType.DateTime;
                ParFecha_Produccion.Value = Detalle_Ingreso.Fecha_Produccion;
                SqlCmd.Parameters.Add(ParFecha_Produccion);

                SqlParameter ParFecha_Vencimiento = new SqlParameter();
                ParFecha_Vencimiento.ParameterName = "@fecha_vencimiento";
                ParFecha_Vencimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Vencimiento.Value = Detalle_Ingreso.Fecha_Vencimiento;
                SqlCmd.Parameters.Add(ParFecha_Vencimiento);


                //Ejecutamos nuestro comando  
                rpta = SqlCmd.ExecuteNonQuery() == 1 ? "OK" : "NO se Ingreso el Registro";

            }
            catch (Exception ex)
            {
                rpta = ex.Message;
            }

            return rpta;

        }

        //Método spStock General
        public DataTable Stock_y_Ganacias()
        {
            DataTable DtResultado = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {

                SqlConnection cn = ConexionBD.Instancia.Conectar();
               // SqlCon.ConnectionString = Conexion.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spStock_y_Ganancias";
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


        //Método Mostrar  
        public DataTable spmostrar_detalle_ingresoymodificar()
        {
            DataTable DtResultado = new DataTable("articulo");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalle_ingresoymodificar";
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

        //Método BuscarNombre  
        public DataTable spmostrar_detalle_ingresoNombre(CD_DetalleIngreso Producto)
        {
            DataTable DtResultado = new DataTable("articulo");
          //  SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = cn;
                SqlCmd.CommandText = "spmostrar_detalle_ingresoNombre";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Producto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;

        }

        public DataTable spmostrar_detalle_ingresoCodigo(CD_DetalleIngreso Producto)
        {
            DataTable DtResultado = new DataTable("articulo");
           /// SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = cn;
                SqlCmd.CommandText = "spmostrar_detalle_ingresoCodigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Producto.TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                SqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable speditar_detallesingreso(int iddetalle_ingreso, decimal precio_Compra, decimal precio_Venta, DateTime fecha_Vencimiento, int stock_inicial, int stock_actual)
        {
            DataTable DtResultado = new DataTable("detalle_ingreso");
           // SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlConnection cn = ConexionBD.Instancia.Conectar();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = cn;
                SqlCmd.CommandText = "speditar_detallesingreso";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter Pariddetalle_ingreso = new SqlParameter();
                Pariddetalle_ingreso.ParameterName = "@iddetalle_ingreso";
                Pariddetalle_ingreso.SqlDbType = SqlDbType.VarChar;
                Pariddetalle_ingreso.Value = iddetalle_ingreso;
                SqlCmd.Parameters.Add(Pariddetalle_ingreso);

                SqlParameter Parstock_inicial = new SqlParameter();
                Parstock_inicial.ParameterName = "@stock_inicial";
                Parstock_inicial.SqlDbType = SqlDbType.VarChar;
                Parstock_inicial.Value = stock_inicial;
                SqlCmd.Parameters.Add(Parstock_inicial);

                SqlParameter Parstock_actual = new SqlParameter();
                Parstock_actual.ParameterName = "@stock_actual";
                Parstock_actual.SqlDbType = SqlDbType.VarChar;
                Parstock_actual.Value = stock_actual;
                SqlCmd.Parameters.Add(Parstock_actual);

                SqlParameter ParPrecio_Compra = new SqlParameter();
                ParPrecio_Compra.ParameterName = "@precio_compra";
                ParPrecio_Compra.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Compra.Value = precio_Compra;
                SqlCmd.Parameters.Add(ParPrecio_Compra);

                SqlParameter ParPrecio_Venta = new SqlParameter();
                ParPrecio_Venta.ParameterName = "@precio_venta";
                ParPrecio_Venta.SqlDbType = SqlDbType.Decimal;
                ParPrecio_Venta.Value = precio_Venta;
                SqlCmd.Parameters.Add(ParPrecio_Venta);

                SqlParameter ParFecha_Vencimiento = new SqlParameter();
                ParFecha_Vencimiento.ParameterName = "@fecha_vencimiento";
                ParFecha_Vencimiento.SqlDbType = SqlDbType.DateTime;
                ParFecha_Vencimiento.Value = fecha_Vencimiento;
                SqlCmd.Parameters.Add(ParFecha_Vencimiento);


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
