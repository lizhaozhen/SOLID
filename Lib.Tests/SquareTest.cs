using System;
using Xunit;

namespace Lib.Tests
{
    public class SquareTest
    {
        [Fact]
        public void Area()
        {
            var square = new Square(3);

            Assert.Equal(9, square.Area());
        }
    }
}
