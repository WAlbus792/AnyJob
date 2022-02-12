using AnyJob.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs;

public class UserConfig : EntityTypeConfigurationBase<User>
{
    protected override void ConfigureEntity(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasMany(p => p.Bookmarks)
           .WithOne(d => d.User)
           .HasForeignKey(d => d.UserId)
           .OnDelete(DeleteBehavior.Cascade);
    }
}