using Volo.Abp.Settings;

namespace NewProjectTemplate.Settings;

public class NewProjectTemplateSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(NewProjectTemplateSettings.MySetting1));
    }
}
