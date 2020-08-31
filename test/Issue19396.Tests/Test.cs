using System.Threading.Tasks;
using Xunit;

namespace Issue19396.Tests
{
    public class Test
    {
        [Fact]
        public async Task WhatShouldHappen()
        {
            var greeter = new Greeter();
            var greeting = await greeter.GetGreeting();

            Assert.Equal("Hello, world", greeting);
        }
    }
}
