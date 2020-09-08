using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_Categoria
    {

        public int Id_Cat { get; set; }
        public String Codigo_Cat { get; set; }
        public String Nombre_Cat { get; set; }
        public String Descripcion_Cat { get; set; }
        
        public String Fecha { get; set; }
        public int Estado_Categoria { get; set; }
    }
}
