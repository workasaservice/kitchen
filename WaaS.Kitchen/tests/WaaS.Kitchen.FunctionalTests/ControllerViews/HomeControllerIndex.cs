using System.Net.Http;
using System.Threading.Tasks;
using WaaS.Kitchen.Web;
using Xunit;

namespace WaaS.Kitchen.FunctionalTests.ControllerViews
{
    [Collection("Sequential")]
    public class HomeControllerIndex : IClassFixture<CustomWebApplicationFactory<Startup>>
    {
        private readonly HttpClient _client;

        public HomeControllerIndex(CustomWebApplicationFactory<Startup> factory)
        {
            _client = factory.CreateClient();
        }

        [Fact]
        public async Task ReturnsViewWithCorrectMessage()
        {
            HttpResponseMessage response = await _client.GetAsync("/");
            response.EnsureSuccessStatusCode();
            string stringResponse = await response.Content.ReadAsStringAsync();

            Assert.Contains("WaaS.Kitchen.Web", stringResponse);
        }
    }
}
