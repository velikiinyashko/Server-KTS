using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;

namespace Server.Models
{
    public class ConfigContext : DbContext
    {
        public ConfigContext() : base("Config")
        {

        }

        public DbSet<ApplicationConfig> Config { get; set; }
    }
}
