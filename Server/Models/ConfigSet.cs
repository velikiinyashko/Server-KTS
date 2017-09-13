using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace Server.Models
{
    class ConfigSet
    {

        public IPAddress AddrServer { get; set; }
        public int PortServer { get; set; }
        public string AddrDatabase { get; set; }
        public int PortDatabase { get; set; }
        public string UserDatabase { get; set; }
        public string PasswdDatabae { get; set; }
        public string NameDatabase { get; set; }

        public ConfigSet()
        {
            ConfigContext context = new ConfigContext();
        }

        public void ConfigLoad()
        {

        }

        public void ConfigSave()
        {

        }
    }
}
