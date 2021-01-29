using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AdminLETDemo.Pages
{
    [Collection(AdminLETDemoTestConsts.CollectionDefinitionName)]
    public class Index_Tests : AdminLETDemoWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
