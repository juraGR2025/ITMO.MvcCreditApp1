using System;
using WebApplication1.Controllers;
using Xunit;

namespace TestProject2
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            BidsController controller = new BidsController();
            var result = controller.Index();
            Assert.NotNull(result);

        }
    }
}
