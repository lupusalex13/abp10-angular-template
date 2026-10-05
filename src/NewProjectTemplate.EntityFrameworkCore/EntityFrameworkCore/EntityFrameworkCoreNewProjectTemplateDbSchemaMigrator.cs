using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using NewProjectTemplate.Data;
using Volo.Abp.DependencyInjection;

namespace NewProjectTemplate.EntityFrameworkCore;

public class EntityFrameworkCoreNewProjectTemplateDbSchemaMigrator
    : INewProjectTemplateDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreNewProjectTemplateDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the NewProjectTemplateDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<NewProjectTemplateDbContext>()
            .Database
            .MigrateAsync();
    }
}
