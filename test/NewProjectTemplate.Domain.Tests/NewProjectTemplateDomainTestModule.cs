using Volo.Abp.Modularity;

namespace NewProjectTemplate;

[DependsOn(
    typeof(NewProjectTemplateDomainModule),
    typeof(NewProjectTemplateTestBaseModule)
)]
public class NewProjectTemplateDomainTestModule : AbpModule
{

}
