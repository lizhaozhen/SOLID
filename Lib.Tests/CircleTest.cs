using System;
using Xunit;

namespace Lib.Tests
{
    public class CircleTest
    {
        [Fact]
        public void Area()
        {
            var circle = new Circle(1);

            Assert.Equal((decimal)Math.PI, circle.Area());
        }
    }
}
