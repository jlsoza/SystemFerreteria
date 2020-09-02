﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using System.Data;
using System.Data.SqlClient;

namespace CapadeNegocio
{
    public class CN_TipoDoc
    {

        private CD_TipoDocumento objetoCD = new CD_TipoDocumento();
        /// <summary>
        /// //
        /// </summary>
        /// <returns></returns>
        public DataTable MostrarTipoDoc()
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.MostrarTipoDoc ();
            return tabla;
        }
        public DataTable listaDeTipoDoc(string filtro)
        {
            DataTable tabla = new DataTable();
            tabla = objetoCD.ListaDeTipoDoc (filtro);
            return tabla;
        }
        public void InsertarTipoDoc(string Nombre_TipDoc, string Abreviatura_TipDoc)
        {
            objetoCD.InsertarTipoDoc(Nombre_TipDoc, Abreviatura_TipDoc);
        }
        public void EditarTipoDoc(string Id_TipDoc, string Nombre_TipDoc, string Abreviatura_TipDoc)
        {
            objetoCD.EditarTipoDoc(Convert.ToInt32(Id_TipDoc), Nombre_TipDoc, Abreviatura_TipDoc);
        }
        public void EliminarTipoDoc(string Id_TipDoc)
        {
            objetoCD.EliminarTipoDoc(Convert.ToInt32(Id_TipDoc));
        }
    }
}
