using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Volo.Abp.TenantManagement.EntityFrameworkCore;

public class TenantManagementHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<TenantManagementHttpApiHostMigrationsDbContext>
{
    public TenantManagementHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<TenantManagementHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("TenantManagement"));

        return new TenantManagementHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
