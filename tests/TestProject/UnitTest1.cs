using System;
using Xunit;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var factory = new CustomWebApplicationFactory();

            factory.CreateClient();

            Assert.NotNull(factory);
        }
    }
}
