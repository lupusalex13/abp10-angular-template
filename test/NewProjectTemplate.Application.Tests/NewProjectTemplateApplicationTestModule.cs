using Volo.Abp.Modularity;

namespace NewProjectTemplate;

[DependsOn(
    typeof(NewProjectTemplateApplicationModule),
    typeof(NewProjectTemplateDomainTestModule)
)]
public class NewProjectTemplateApplicationTestModule : AbpModule
{

}
