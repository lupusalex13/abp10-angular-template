using NewProjectTemplate.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace NewProjectTemplate.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(NewProjectTemplateEntityFrameworkCoreModule),
    typeof(NewProjectTemplateApplicationContractsModule)
)]
public class NewProjectTemplateDbMigratorModule : AbpModule
{
}
