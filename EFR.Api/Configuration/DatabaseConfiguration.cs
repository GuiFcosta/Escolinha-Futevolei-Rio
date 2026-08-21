using EFR.Api.Data;
using Microsoft.EntityFrameworkCore;

namespace EFR.Api.Configuration;

public static class DatabaseConfiguration
{
    public static IServiceCollection AddDatabaseConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration["DatabaseSettings:ConnectionString"]
                               ?? configuration.GetConnectionString("DefaultConnection")
                               ?? "Data Source=efr.db";
        
        services.AddDbContext<AppDbContext>(options =>
            options.UseSqlite(connectionString));

        return services;
    }
}