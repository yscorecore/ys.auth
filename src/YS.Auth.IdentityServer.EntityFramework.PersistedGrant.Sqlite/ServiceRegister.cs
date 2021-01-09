using System;
using System.Reflection;
using IdentityServer4.Configuration;
using IdentityServer4.EntityFramework.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using YS.Knife;

namespace YS.Auth.IdentityServer.EntityFramework.PersistedGrant
{

    class ServiceRegister : IServiceRegister
    {
        public const string ConnectionStringKey = "id4grant";
        public void RegisterServices(IServiceCollection services, IRegisterContext context)
        {
            var connection = context.Configuration.GetConnectionString(ConnectionStringKey);
            if (string.IsNullOrEmpty(connection))
            {
                throw new ApplicationException($"Can not find connection string by key \"{ConnectionStringKey}\".");
            }
            var currentAssembly = Assembly.GetExecutingAssembly().FullName;
            new IdentityServerBuilder(services)
                .AddOperationalStore(options =>
                {
                    options.ConfigureDbContext = b =>
                    {
                        b.UseSqlite(connection, contextbuilder => {
                            contextbuilder.MigrationsAssembly(currentAssembly);
                        });
                    };
                    options.DefaultSchema = "id4grant";
                });
        }
    }
}
