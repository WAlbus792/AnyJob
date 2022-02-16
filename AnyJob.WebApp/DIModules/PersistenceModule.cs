using AnyJob.Persistence;
using AnyJob.Persistence.Repositories;
using Autofac;

namespace AnyJob.WebApp.DIModules;

public class PersistenceModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
           .RegisterGeneric(typeof(Repository<,>))
           .As(typeof(IRepository<,>))
           .InstancePerLifetimeScope();

        builder
           .RegisterGeneric(typeof(Repository<>))
           .As(typeof(IRepository<>))
           .InstancePerLifetimeScope();

        builder
           .RegisterType<DbChangesUpdater<AppDbContext>>()
           .As<IDbChangesUpdater>()
           .InstancePerLifetimeScope();
    }
}