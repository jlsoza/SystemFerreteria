using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos.System.Configuration
{
    internal class ConfigurationManager
    {
        private static ConfigurationManager _instancia = null;
        public static ConfigurationManager Instancia
        {
            get { if (_instancia == null) { _instancia = new ConfigurationManager(); } return _instancia; }
        }


        AppSettingsReader MyReader = new System.Configuration.AppSettingsReader();
        public string getServer { get { return MyReader.GetValue("server", typeof(string)).ToString(); } }
        public string getDatabase { get { return MyReader.GetValue("database", typeof(string)).ToString(); } }
        public string getUser { get { return MyReader.GetValue("user", typeof(string)).ToString(); } }
        public string getClave { get { return MyReader.GetValue("clave", typeof(string)).ToString(); } }
    }

    internal class AppSettingsReader : global::System.Configuration.AppSettingsReader
    {
    }
}
