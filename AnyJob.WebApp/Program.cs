using System.Reflection;
using AnyJob.Application;
using AnyJob.Application.Contracts;
using AnyJob.Persistence;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

// Add services to the container.
WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Logging.AddConsole();

// React
builder.Services.AddSpaStaticFiles(configuration => configuration.RootPath = "ClientApp/build");

// db
string connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(connectionString));

// Automapper (for mapping models)
builder.Services.AddAutoMapper(typeof(UserInfoProvider));

// Autofac
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(containerBuilder => containerBuilder.RegisterAssemblyModules(Assembly.GetExecutingAssembly()));

WebApplication app = builder.Build();

// -----------------------------------------------------------------------------------------------------

using (AppDbContext dbContext = app.Services.GetService<AppDbContext>()!)
    dbContext.Database.Migrate();

bool isDev = app.Environment.IsDevelopment();
if (isDev)
    app.UseDeveloperExceptionPage();
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSpaStaticFiles();

app.UseRouting();

// Sets the information in UserInfoProvider
app.Use((context, next) =>
{
    if (Guid.TryParse(context.Request.Headers["AnonymousId"], out Guid anonymousId))
    {
        IUserInfoSetter userInfoProvider = context.RequestServices.GetService<IUserInfoSetter>()!;
        userInfoProvider.AnonymousId = anonymousId;
    }

    return next();
});

app.UseEndpoints(endpoints => endpoints.MapControllers());

app.UseSpa(spa =>
{
    spa.Options.SourcePath = "ClientApp";

    spa.Options.DefaultPageStaticFileOptions = new StaticFileOptions
    {
        // never cache index.html
        OnPrepareResponse = context =>
        {
            context.Context.Response.Headers.Add("Cache-Control", "no-cache, no-store");
            context.Context.Response.Headers.Add("Expires", "-1");
        }
    };

    if (isDev)
        spa.UseProxyToSpaDevelopmentServer("http://localhost:3000");
});

app.Run();