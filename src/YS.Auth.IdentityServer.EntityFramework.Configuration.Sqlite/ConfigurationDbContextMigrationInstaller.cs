using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using YS.Knife.Stages;

namespace YS.Auth.IdentityServer.EntityFramework.Configuration.Sqlite
{
    [Stage("install")]
    public class ConfigurationDbContextMigrationInstaller : DbContextMigrationInstaller<ConfigurationDbContext>
    {
        public ConfigurationDbContextMigrationInstaller(ConfigurationDbContext context) : base(context)
        {
        }
    }
}
