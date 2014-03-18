using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock.System.Config
{
    public class ConfigHelper 
    {
        public static string AppSettings(string key)
        {
            return ConfigurationManager.AppSettings[key];
        }
    }
}
