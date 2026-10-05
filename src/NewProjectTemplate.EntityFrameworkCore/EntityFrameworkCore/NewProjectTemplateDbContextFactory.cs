using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace NewProjectTemplate.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class NewProjectTemplateDbContextFactory : IDesignTimeDbContextFactory<NewProjectTemplateDbContext>
{
    public NewProjectTemplateDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();
        
        NewProjectTemplateEfCoreEntityExtensionMappings.Configure();

        var builder = new DbContextOptionsBuilder<NewProjectTemplateDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));
        
        return new NewProjectTemplateDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../NewProjectTemplate.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false)
            .AddEnvironmentVariables();

        return builder.Build();
    }
}
