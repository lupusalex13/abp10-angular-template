using NewProjectTemplate.Samples;
using Xunit;

namespace NewProjectTemplate.EntityFrameworkCore.Domains;

[Collection(NewProjectTemplateTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<NewProjectTemplateEntityFrameworkCoreTestModule>
{

}
