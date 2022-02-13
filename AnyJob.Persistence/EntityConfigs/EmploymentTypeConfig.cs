using System.ComponentModel.DataAnnotations;
using System.Reflection;
using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs;

public class EmploymentTypeConfig : EntityTypeConfigurationBase<EmploymentType, EmploymentTypeId>
{
    protected override void ConfigureEntity(EntityTypeBuilder<EmploymentType> builder)
    {
        builder.ToTable("EmploymentTypes");
        builder.Property(e => e.Id).ValueGeneratedNever().HasConversion<int>();

        builder.HasMany(p => p.JobPostings)
           .WithOne(d => d.EmploymentType)
           .HasForeignKey(d => d.EmploymentTypeId)
           .OnDelete(DeleteBehavior.Restrict);

        builder.HasData(Enum.GetValues<EmploymentTypeId>()
           .Select(e => new EmploymentType
            {
                Id = e,
                Name = e.GetType().GetMember(e.ToString()).First().GetCustomAttribute<DisplayAttribute>().Name
            }));
    }
}