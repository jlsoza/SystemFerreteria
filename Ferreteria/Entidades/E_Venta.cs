﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Venta
    {

        public int Id_Venta { get; set; }
        public String Codigo_Venta { get; set; }
        public int Serie_Venta { get; set; }
        public String Correlativo_Venta { get; set; }
        public int Igv_Venta { get; set; }
        public Double MontoIgv_Venta { get; set; }
        public DateTime FechaVenta { get; set; }
        public String Estado_Venta { get; set; }
        public Double Descuento_Venta { get; set; }
        public string Desc_Venta { get; set; }
        public double Utilidad { get; set; }
        public double Inversion { get; set; }
        // campo calculado
        public double Total { get; set; }

        public E_cliente  cliente { get; set; }
        public E_usuario  usuario { get; set; }
        public E_Moneda  moneda { get; set; }
        public E_Sucursal sucursal { get; set; }
        public E_Comprobante tipocomprobante { get; set; }

        public E_TipoPago tipopago { get; set; }
        public List<E_DetalleVenta> detalleventa { get; set; }
    }
}
