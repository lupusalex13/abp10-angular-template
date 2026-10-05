using System.Threading.Tasks;

namespace NewProjectTemplate.Data;

public interface INewProjectTemplateDbSchemaMigrator
{
    Task MigrateAsync();
}
