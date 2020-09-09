using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapadeNegocio
{
    public class CN_Cliente
    {
        private CD_Cliente objetoCD = new CD_Cliente();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarCliente()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarCliente ();
            return tabla;
        }
        public DataTable listaDeCliente(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeCliente (filtro);
            return tabla;
        }
      

        public void Insertarcliente(int Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, string FechaNac_Cliente, string Sexo_Cliente, string Telefono_Cliente, string Celular_Cliente, string Correo_Cliente, string Direccion_Cliente, byte Estado_Cliente, string FechCreacion_Cliente, byte[] Foto)
        {
            
            objetoCD.InsertarCliente(Id_TipDoc, NumeroDoc_Cliente, Nombre_Cliente, FechaNac_Cliente, Sexo_Cliente, Telefono_Cliente, Celular_Cliente, Correo_Cliente, Direccion_Cliente, Estado_Cliente, FechCreacion_Cliente, Foto);
        }
        public void Editarcliente(string Id_Cliente, int Id_TipDoc, string NumeroDoc_Cliente, string Nombre_Cliente, string FechaNac_Cliente, string Sexo_Cliente, string Telefono_Cliente, string Celular_Cliente, string Correo_Cliente, string Direccion_Cliente, byte Estado_Cliente, string FechCreacion_Cliente, byte[] Foto)
        {
            objetoCD.EditarCliente(Convert.ToInt32(Id_Cliente), Id_TipDoc, NumeroDoc_Cliente, Nombre_Cliente, Estado_Cliente, FechaNac_Cliente, Sexo_Cliente, Telefono_Cliente, Celular_Cliente, Correo_Cliente, Direccion_Cliente, FechCreacion_Cliente, Foto);
        }
        public void Eliminarcliente(string Id_Cliente)
        {
            objetoCD.EliminarCliente (Convert.ToInt32(Id_Cliente));
        }
    }
}
