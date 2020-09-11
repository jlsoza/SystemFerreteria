using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class E_usuario
    {

        public int Id_Usuario { get; set; }
        public String Codigo_Usuario { get; set; }
        public String Nombre_Usuario { get; set; }
        public String Login_Usuario { get; set; }
        public String Password_Usuario { get; set; }
        public String Telefono_Usuario { get; set; }
        public String Celular_Usuario { get; set; }
        public String Correo_Usuario { get; set; }
        public Boolean Estado_Usuario { get; set; }
        public String Expiracion_Usuario { get; set; }
        public int UsuarioCreacion_Usuario { get; set; }
        public int UsuarioUpdate_Usuario { get; set; }
        public String DominoCorreo_Usuario { get; set; }

        public E_Nivel_Acceso nivel_acceso { get; set; }
        public E_Sucursal sucursal { get; set; }
    }
}
