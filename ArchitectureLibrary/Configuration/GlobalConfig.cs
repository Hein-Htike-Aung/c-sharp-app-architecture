using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArchitectureLibrary.Configuration
{
    public class GlobalConfig
    {
        public const string ConnectionStringName = "Architecture";

        public static string ConnectionString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
