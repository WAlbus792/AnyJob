using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs
{
    public class JobPostingConfig : EntityTypeConfigurationBase<JobPosting>
    {
        protected override void ConfigureEntity(EntityTypeBuilder<JobPosting> builder)
        {
            builder.ToTable("JobPostings");

            builder.Property(e => e.EmploymentTypeId).HasConversion<int>();
        }
    }
}