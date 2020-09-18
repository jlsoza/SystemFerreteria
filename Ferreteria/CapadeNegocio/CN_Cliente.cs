using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace CapadeNegocio
{
    public class CN_Cliente
    {

        #region singleton
        private static readonly CN_Cliente _intancia = new CN_Cliente();
        public static CN_Cliente Intancia
        {
            get { return CN_Cliente._intancia; }
        }
        #endregion singleton

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


        public List<E_TipoDoc > ListarTipDoc()
        {
            try
            {
                List<E_TipoDoc> Lista = CD_Cliente .Intancia.ListarTipDoc();
                if (Lista.Count <= 0) throw new ApplicationException("Lista tipo documento vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista tipo documento");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public E_cliente  BuscarCliente(int id_cli, String nro_Doc)
        {
            try
            {
                E_cliente c = null;
                c = CD_Cliente.Intancia.BuscarCliente(id_cli, nro_Doc);
                if (c == null) throw new ApplicationException("No se encontro registro en la BD");
                return c;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<E_cliente > ListarCliente()
        {
            try
            {
                List<E_cliente> Lista = CD_Cliente .Intancia.ListarCliente();
                if (Lista.Count <= 0) throw new ApplicationException("Lista de clientes vacia");
                else if (Lista == null) throw new ApplicationException("Error al cargar lista de clientes");
                return Lista;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
