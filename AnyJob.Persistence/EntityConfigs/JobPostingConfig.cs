﻿using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs;

public class JobPostingConfig : EntityTypeConfigurationBase<JobPosting>
{
    protected override void ConfigureEntity(EntityTypeBuilder<JobPosting> builder)
    {
        builder.ToTable("JobPostings");

        builder.Property(e => e.CreationDate).HasDefaultValueSql("getdate()");
        builder.HasIndex(e => e.CreationDate);

        builder.HasMany(p => p.Bookmarks)
           .WithOne(d => d.JobPosting)
           .HasForeignKey(d => d.JobPostingId)
           .OnDelete(DeleteBehavior.Cascade);
    }
}