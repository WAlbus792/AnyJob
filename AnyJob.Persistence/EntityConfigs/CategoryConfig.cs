using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs
{
    public class CategoryConfig : EntityTypeConfigurationBase<Category>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Categories");

            builder.HasMany(p => p.JobPostings)
               .WithOne(d => d.Category)
               .HasForeignKey(d => d.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}