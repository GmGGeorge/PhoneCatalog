using Microsoft.EntityFrameworkCore;
using PhoneCatalog.Models;

namespace PhoneCatalog.Repository;

public class Repositories : DbContext
{
    public Repositories(DbContextOptions<Repositories> options) : base(options)
    {

    }

    public DbSet<Person> Person { get; set; }
    
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
