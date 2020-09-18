using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Serie
    {
        public int Id_Serie { get; set; }
        public String Numero_Serie { get; set; }

        public E_Sucursal  sucursal { get; set; }
        public E_Comprobante  tipocom { get; set; }
    }
}
