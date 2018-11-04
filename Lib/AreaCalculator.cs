using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class AreaCalculator
    {
        private readonly IShapeFactory _factory;

        public AreaCalculator(IShapeFactory factory)
        {
            _factory = factory;
        }

        public IEnumerable<decimal> Calculate()
        {
            return _factory.CreateShapes().Select(x => x.Area());
        }

        public decimal Sum(IEnumerable<Shape> shapes)
        {
            return Calculate().Sum();
        }
    }
}
