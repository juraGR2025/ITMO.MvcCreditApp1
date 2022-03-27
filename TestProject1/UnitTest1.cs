using System;
using Xunit;
using WebApplication1.Controllers;

namespace TestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            HomeController controller = new HomeController();
            var result = controller.Index();
            Assert.NotNull(result);
        }
    }
}
