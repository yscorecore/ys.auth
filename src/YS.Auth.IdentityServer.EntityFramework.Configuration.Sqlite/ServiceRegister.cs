using IdentityServer4.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.Extensions.DependencyInjection;
using YS.Knife;
using System.Reflection;
using System;

namespace YS.Auth.IdentityServer.EntityFramework.Configuration.Sqlite
{
    class ServiceRegister : IServiceRegister
    {
        public const string ConnectionStringKey = "id4cfg";
        public void RegisterServices(IServiceCollection services, IRegisterContext context)
        {
            var connection = context.Configuration.GetConnectionString(ConnectionStringKey);
            if (string.IsNullOrEmpty(connection))
            {
                throw new ApplicationException($"Can not find connection string by key \"{ConnectionStringKey}\".");
            }
            var currentAssembly = Assembly.GetExecutingAssembly().FullName;
            new IdentityServerBuilder(services)
                .AddConfigurationStore(options =>
                {
                    options.ConfigureDbContext = b =>
                    {
                        b.UseSqlite(connection, contextbuilder=> {
                            contextbuilder.MigrationsAssembly(currentAssembly);
                        });
                    };
                    options.DefaultSchema = "id4cfg";
                });
        }
    }
}
