﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_DetalleVenta
    {
        public int Id_Det { get; set; }
        public int Id_Prod_Det { get; set; }
        public Double PrecProd_Det { get; set; }
        public int Cantidad_Det { get; set; }
        public Double Descuento_det { get; set; }


        // relaciones 

        public E_Venta venta { get; set; }
        public E_Producto producto { get; set; }
    }
}
