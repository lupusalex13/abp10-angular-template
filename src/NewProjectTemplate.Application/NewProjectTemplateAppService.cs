using NewProjectTemplate.Localization;
using Volo.Abp.Application.Services;

namespace NewProjectTemplate;

/* Inherit your application services from this class.
 */
public abstract class NewProjectTemplateAppService : ApplicationService
{
    protected NewProjectTemplateAppService()
    {
        LocalizationResource = typeof(NewProjectTemplateResource);
    }
}
