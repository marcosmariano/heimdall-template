using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Npgsql;

namespace Heimdall.Infrastructure.Repository
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var connectionString = new NpgsqlConnectionStringBuilder
            {
                Host = "localhost",
                Database = "heimdall",
                Port = 5432
            };

            var builder =  new DbContextOptionsBuilder<AppDbContext>();

            builder.UseNpgsql(connectionString.ToString(),options=>
            {
                options.SetPostgresVersion(new Version(10,5));
            });

            return new AppDbContext(builder.Options);
        }
    }
}