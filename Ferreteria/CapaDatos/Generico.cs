using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.IO;

namespace CapaDatos
{
  public class Generico
    {
        public static void grabar(object obj, string archivo)
        {
            PropertyInfo[] propiedades = obj.GetType().GetProperties();
            using (StreamWriter sw =  new StreamWriter(archivo))
            {
                object valor;
                foreach (PropertyInfo propiedad in propiedades)
                {
                    valor = propiedad.GetValue(obj, null);
                    sw.WriteLine("{0} = {1}", propiedad.Name, valor != null ? valor.ToString() : "");
                }
                sw.WriteLine(new string('_', 60));
            }
        }
    }
}
