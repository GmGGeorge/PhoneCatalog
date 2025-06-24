using PhoneCatalog.Repository;
using Microsoft.EntityFrameworkCore;

namespace MainProgram;

class Program
{
    static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<Repositories>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
        var app = builder.Build();

        // Configure the HTTP request pipeline. Or else Middleware
        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.MapControllers();

        app.MapGet("/", context =>
        {
            context.Response.Redirect("/mainpage");
            return Task.CompletedTask;
        });

        app.Run();
    }
}
