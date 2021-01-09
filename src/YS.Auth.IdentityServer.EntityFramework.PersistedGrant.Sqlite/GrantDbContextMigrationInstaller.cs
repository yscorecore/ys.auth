using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using YS.Knife.Stages;

namespace YS.Auth.IdentityServer.EntityFramework.PersistedGrant.Sqlite
{
    [Stage("install")]
    public class GrantDbContextMigrationInstaller : DbContextMigrationInstaller<PersistedGrantDbContext>
    {
        public GrantDbContextMigrationInstaller(PersistedGrantDbContext context) : base(context)
        {
        }
    }
}
