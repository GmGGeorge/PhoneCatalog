using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace PhoneCatalog.Repository;

public class PhoneCatalogDbContextFactory : IDesignTimeDbContextFactory<Repositories>
{
    public Repositories CreateDbContext(string[] args)
    {
        var optionBuilder = new DbContextOptionsBuilder<Repositories>();

        optionBuilder.UseSqlServer("Server=localhost;Database=PhoneCatalog; User Id=Thanos\\thano; Trusted_Connection=True; TrustServerCertificate=True;");

        return new Repositories(optionBuilder.Options);
    }
}
