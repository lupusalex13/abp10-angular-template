using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NewProjectTemplate.Data;

/* This is used if database provider does't define
 * INewProjectTemplateDbSchemaMigrator implementation.
 */
public class NullNewProjectTemplateDbSchemaMigrator : INewProjectTemplateDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
