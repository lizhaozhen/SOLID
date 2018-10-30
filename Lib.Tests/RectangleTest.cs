using System;
using Xunit;

namespace Lib.Tests
{
    public class RectangleTest
    {
        [Fact]
        public void Area()
        {
            var rectangle = new Rectangle(3,4);

            Assert.Equal(12, rectangle.Area());
        }
    }
}
