using Heimdall.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Heimdall.Infrastructure.Repository.Config
{
    internal class WorldEntityTypeConfiguration : BaseEntityTypeConfiguration<World>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<World> builder)
        {
            builder.ToTable("world", AppDbContext.Schema);

            builder.Property(x => x.Name)
                .HasColumnName("name");
            
            builder.Property(x => x.Description)
                .HasColumnName("description");
            
            builder.Property(x => x.Size)
                .HasColumnName("size");
        }
    }
}