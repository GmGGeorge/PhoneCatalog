using Microsoft.EntityFrameworkCore;
using PhoneCatalog.Models;

namespace PhoneCatalog.Repository;

public class Repository: DbContext
{
    public DbSet<Person> Person { get; set; }
}
