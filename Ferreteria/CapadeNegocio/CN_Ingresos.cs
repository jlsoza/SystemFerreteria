using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using CapaDatos;


namespace CapadeNegocio
{
    public class CN_Ingresos
    {
        //Método Insertar que llama al método Insertar de la clase DIngreso  
        //de la CapaDatos  

        public int UsuarioCreacion_Ingreso { get; set; }
        public int UsuarioUpdate_Ingreso { get; set; }

        public static string Insertar( int idproveedor, DateTime fecha, int tipo_comprobante, string serie, string correlativo, decimal igv, string estado,  int UsuarioCreacion_Ingreso, int UsuarioUpdate_Ingreso, DataTable dtDetalles)
        {
            CD_Ingreso Obj = new CD_Ingreso();
          

            Obj.Idproveedor = idproveedor;
            Obj.Fecha = fecha;
            Obj.Tipo_Comprobante = tipo_comprobante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Igv = igv;
            Obj.Estado = estado;
            Obj.UsuarioCreacion_Ingreso = UsuarioCreacion_Ingreso;
            Obj.UsuarioUpdate_Ingreso  = UsuarioUpdate_Ingreso ;


            List<CD_DetalleIngreso> detalles = new List<CD_DetalleIngreso>();
            foreach (DataRow row in dtDetalles.Rows)
            {
                CD_DetalleIngreso detalle = new CD_DetalleIngreso();
                detalle.Id_Prod = Convert.ToInt32(row["Id_Prod"].ToString());
                detalle.Precio_Compra = Convert.ToDecimal(row["precio_compra"].ToString());
                detalle.Precio_Venta = Convert.ToDecimal(row["precio_venta"].ToString());
                detalle.Stock_Inicial = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Stock_Actual = Convert.ToInt32(row["stock_inicial"].ToString());
                detalle.Fecha_Produccion = Convert.ToDateTime(row["fecha_produccion"].ToString());
                detalle.Fecha_Vencimiento = Convert.ToDateTime(row["fecha_vencimiento"].ToString());
                detalles.Add(detalle);
            }


            return Obj.Insertar(Obj, detalles);
        }

        //de la CapaDatos  
        public static string Anular(int idingreso)
        {
            CD_Ingreso  Obj = new CD_Ingreso();
            Obj.Idingreso = idingreso;
            return Obj.Anular(Obj);
        }

        //de la CapaDatos  
        public static DataTable Mostrar()
        {
            return new CD_Ingreso().Mostrar();
        }

        //Método BuscarApellidos que llama al método BuscarApellidos  
        //de la clase DCliente de la CapaDatos  
        public static DataTable BuscarFechas(string textobuscar, string textobuscar2)
        {
            CD_Ingreso Obj = new CD_Ingreso();
            return Obj.BuscarFechas(textobuscar, textobuscar2);
        }
        public static DataTable MostrarDetalle(string textobuscar)
        {
            CD_Ingreso Obj = new CD_Ingreso();
            return Obj.MostrarDetalle(textobuscar);
        }

        public static DataTable spmostrar_detalle_ingresoymodificar()
        {
            return new CD_DetalleIngreso ().spmostrar_detalle_ingresoymodificar();
        }

        public static DataTable spmostrar_detalle_ingresoNombre(string textobuscar)
        {
            CD_DetalleIngreso Obj = new CD_DetalleIngreso();
            Obj.TextoBuscar = textobuscar;
            return Obj.spmostrar_detalle_ingresoNombre(Obj);
        }
        public static DataTable spmostrar_detalle_ingresoCodigo(string textobuscar)
        {
            CD_DetalleIngreso Obj = new CD_DetalleIngreso();
            Obj.TextoBuscar = textobuscar;
            return Obj.spmostrar_detalle_ingresoCodigo(Obj);
        }

        public static DataTable speditar_detallesingreso(int iddetalle_ingreso, decimal precio_compra, decimal precio_Venta, DateTime fecha_Vencimiento, int stock_inicial, int stock_actual)
        {
            CD_DetalleIngreso Obj = new CD_DetalleIngreso();
            return Obj.speditar_detallesingreso(iddetalle_ingreso, precio_compra, precio_Venta, fecha_Vencimiento, stock_inicial, stock_actual);
        }
    }
}
