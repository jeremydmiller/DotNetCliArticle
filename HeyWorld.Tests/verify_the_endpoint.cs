using System.Threading.Tasks;
using Alba;
using Xunit;

namespace HeyWorld.Tests
{
    public class verify_the_endpoint
    {
        [Fact]
        public async Task check_it_out()
        {
            using (var system = SystemUnderTest.ForStartup<Startup>())
            {
                await system.Scenario(s =>
                {
                    s.Get.Url("/");
                    s.ContentShouldBe("Hey, world!");
                    s.ContentTypeShouldBe("text/plain; charset=utf-8");
                });
            }
        }
    }
}