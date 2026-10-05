using Microsoft.Extensions.Localization;
using NewProjectTemplate.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace NewProjectTemplate;

[Dependency(ReplaceServices = true)]
public class NewProjectTemplateBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<NewProjectTemplateResource> _localizer;

    public NewProjectTemplateBrandingProvider(IStringLocalizer<NewProjectTemplateResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
