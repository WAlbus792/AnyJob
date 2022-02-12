using AnyJob.Domain.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AnyJob.Persistence.EntityConfigs;

public abstract class EntityTypeConfigurationBase<TEntity> : EntityTypeConfigurationBase<TEntity, int>
    where TEntity : EntityWithId { }

public abstract class EntityTypeConfigurationBase<TEntity, T> : IEntityTypeConfiguration<TEntity>
    where TEntity : class, IEntityWithId<T>
    where T : IComparable
{
    public void Configure(EntityTypeBuilder<TEntity> builder)
    {
        builder.HasKey(e => e.Id);

        ConfigureEntity(builder);
    }

    protected virtual void ConfigureEntity(EntityTypeBuilder<TEntity> builder) { }
}