using NewProjectTemplate.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace NewProjectTemplate.Permissions;

public class NewProjectTemplatePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(NewProjectTemplatePermissions.GroupName, L("Permission:NewProjectTemplate"));

        //Define your own permissions here. Example:
        //myGroup.AddPermission(NewProjectTemplatePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<NewProjectTemplateResource>(name);
    }
}
