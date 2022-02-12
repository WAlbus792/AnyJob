using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs;

public class JobPostingBookmarkConfig : EntityTypeConfigurationBase<JobPostingBookmark>
{
    protected override void ConfigureEntity(EntityTypeBuilder<JobPostingBookmark> builder) => builder.ToTable("JobPostingBookmarks");
}