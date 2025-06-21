using PhoneCatalog.Models;
using PhoneCatalog.Repository;

namespace MainProgram;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        // Add services to the container.

        builder.Services.AddScoped<Connection>();
        builder.Services.AddScoped<PersonRepository>();

        var app = builder.Build();

        // Configure the HTTP request pipeline. Or else Middleware
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.MapControllers();

        app.MapGet("/",  context =>
        {
            context.Response.Redirect("/mainpage");
            return Task.CompletedTask;
        });

        app.Run();
    }
}
