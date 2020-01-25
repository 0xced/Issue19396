using System.Threading.Tasks;
using Xunit;

namespace Issue19396.Tests
{
    public class GreeterTest
    {
        [Fact]
        public async Task GetGreetingTest()
        {
            var greeter = new Greeter();
            var greeting = await greeter.GetGreeting();

            Assert.Equal("Hello, world", greeting);
        }
    }
}
