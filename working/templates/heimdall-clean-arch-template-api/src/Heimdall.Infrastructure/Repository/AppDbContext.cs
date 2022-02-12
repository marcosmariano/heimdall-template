using System.Reflection;
using Heimdall.Domain;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Heimdall.Infrastructure.Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public const string Schema = "heimdall";

        public virtual DbSet<World> Worlds { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}