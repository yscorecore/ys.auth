using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;

namespace YS.Auth.IdentityServer.EntityFramework.PersistedGrant.Sqlite
{
     class GrantDbContextDesignTimeFactory: DesignTimeDbContextFactoryBase<PersistedGrantDbContext>
    {
    }
}
