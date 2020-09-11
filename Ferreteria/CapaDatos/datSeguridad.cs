using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class datSeguridad
    {
        private static readonly datSeguridad _instancia = new datSeguridad();
        public static datSeguridad Instancia
        {
            get { return datSeguridad._instancia; }
        }
    }
}
