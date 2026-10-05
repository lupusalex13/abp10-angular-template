using Xunit;

namespace NewProjectTemplate.EntityFrameworkCore;

[CollectionDefinition(NewProjectTemplateTestConsts.CollectionDefinitionName)]
public class NewProjectTemplateEntityFrameworkCoreCollection : ICollectionFixture<NewProjectTemplateEntityFrameworkCoreFixture>
{

}
