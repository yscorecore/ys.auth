using System;
using Microsoft.EntityFrameworkCore;

namespace YS.Auth.Identity.EFCore.Sqlite
{
    [SqliteEFContext("auth_sqlite")]
    public class SqliteAuthDbContext : EFCore.AuthDbContext
    {
        public SqliteAuthDbContext(DbContextOptions<AuthDbContext> options):base(options)
        {

        }
    }
}
