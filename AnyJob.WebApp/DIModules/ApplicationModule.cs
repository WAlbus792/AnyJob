using System.Reflection;
using AnyJob.Application;
using AnyJob.Application.Contracts;
using Autofac;
using Module = Autofac.Module;

namespace AnyJob.WebApp.DIModules;

public class ApplicationModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder
           .RegisterAssemblyTypes(Assembly.GetAssembly(typeof(UserInfoProvider))!)
           .AsImplementedInterfaces()
           .InstancePerLifetimeScope();
        builder
           .RegisterAssemblyTypes(Assembly.GetAssembly(typeof(UserInfoProvider))!)
           .InstancePerLifetimeScope();

        builder
           .RegisterType<UserInfoProvider>()
           .As<IUserInfoProvider>()
           .As<IUserInfoSetter>()
           .InstancePerLifetimeScope();
    }
}