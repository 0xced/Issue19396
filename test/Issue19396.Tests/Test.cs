using System;
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

        [Fact]
        public async Task WhatActuallyHappens()
        {
            var greeter = new Greeter();
            var exception = await Assert.ThrowsAsync<TypeInitializationException>(() => greeter.GetGreeting());

            Assert.Contains("Library e_sqlite3 not found", exception.ToString());
        }
    }
}
