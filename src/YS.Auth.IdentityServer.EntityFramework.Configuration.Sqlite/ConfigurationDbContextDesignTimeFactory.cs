using System;
using System.Collections.Generic;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using YS.Knife;

namespace YS.Auth.IdentityServer.EntityFramework.Configuration.Sqlite
{
    public class ConfigurationDbContextDesignTimeFactory : DesignTimeDbContextFactoryBase<ConfigurationDbContext>
    {
       
    }
}
