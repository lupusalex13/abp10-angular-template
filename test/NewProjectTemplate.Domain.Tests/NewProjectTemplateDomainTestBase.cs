using Volo.Abp.Modularity;

namespace NewProjectTemplate;

/* Inherit from this class for your domain layer tests. */
public abstract class NewProjectTemplateDomainTestBase<TStartupModule> : NewProjectTemplateTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
