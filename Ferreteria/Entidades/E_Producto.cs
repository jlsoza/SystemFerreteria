using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Producto
    {
        public int Id_Prod { get; set; }
        public String Codigo_Prod { get; set; }
        public String Nombre_Prod { get; set; }
        public String Marca_Prod { get; set; }
        public Double PrecioCompra_Prod { get; set; }
        public Double Precio_Prod { get; set; }
        public int Stock_Prod { get; set; }
        public int StockProm_Prod { get; set; }
        public int StockMin_Prod { get; set; }
        public int UsuarioCreacion_Prod { get; set; }
        public int UsuarioUpdate_Prod { get; set; }

        // Relaciones
        public E_Categoria categoria { get; set; }
        public E_UnidadMedida unidmedida { get; set; }
        public E_Proveedor proveedor { get; set; }

        // guardar variable para detalle_venta

        public int Cantidad_ { get; set; }
    }
}
