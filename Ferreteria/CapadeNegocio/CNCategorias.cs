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
    public class CNCategorias
    {
        private CD_Categorias objetoCD = new CD_Categorias();

        public DataTable Mostrarcategorias()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.Mostrar();
            return tabla;
        }
        public DataTable listaDeCategorias(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeCategorias (filtro);
            return tabla;
        }
        public void Insertarcategoria(string Codigo_Cat, string Nombre_Cat, string Descripcion_Cat, byte Estado_Categoria)
        {
            objetoCD.InsertarCategoria ( Codigo_Cat,  Nombre_Cat,  Descripcion_Cat,  Estado_Categoria);
        }
        public void Editarcategoria(int Id_Cat, string Codigo_Cat, string Nombre_Cat, string Descripcion_Cat, byte Estado_Categoria)
        {
            objetoCD.EditarCategorias (Convert.ToInt32(Id_Cat), Codigo_Cat, Nombre_Cat, Descripcion_Cat, Estado_Categoria);
        }
        public void Eliminarcategoria(string Id_Cat)
        {
            objetoCD.EliminarCategoria (Convert.ToInt32(Id_Cat));
        }
    }
}
