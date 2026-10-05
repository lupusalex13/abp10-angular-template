using NewProjectTemplate.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace NewProjectTemplate.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class NewProjectTemplateController : AbpControllerBase
{
    protected NewProjectTemplateController()
    {
        LocalizationResource = typeof(NewProjectTemplateResource);
    }
}
