using Microsoft.Extensions.Configuration;

namespace PhoneCatalog.Models;

public class Connection
{
    public string DefaultConnection { get; set; } = string.Empty;

    public Connection(IConfiguration configuration)
    {
        DefaultConnection = configuration.GetConnectionString("DefaultConnection")!;
    }
}

