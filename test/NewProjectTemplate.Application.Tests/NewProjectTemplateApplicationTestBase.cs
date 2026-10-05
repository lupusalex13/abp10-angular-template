using Volo.Abp.Modularity;

namespace NewProjectTemplate;

public abstract class NewProjectTemplateApplicationTestBase<TStartupModule> : NewProjectTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
