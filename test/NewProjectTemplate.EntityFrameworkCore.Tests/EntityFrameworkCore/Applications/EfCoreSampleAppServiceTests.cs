using NewProjectTemplate.Samples;
using Xunit;

namespace NewProjectTemplate.EntityFrameworkCore.Applications;

[Collection(NewProjectTemplateTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<NewProjectTemplateEntityFrameworkCoreTestModule>
{

}
