using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs
{
    public class LocationConfig : EntityTypeConfigurationBase<Location>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Location> builder)
        {
            builder.ToTable("Locations");

            builder.HasMany(p => p.JobPostings)
               .WithOne(d => d.Location)
               .HasForeignKey(d => d.LocationId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}