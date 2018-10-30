using System;
using System.Collections.Generic;
using System.Linq;

namespace Lib
{
    public class AreaCalculator
    {
        public IEnumerable<decimal> Calculate(IEnumerable<Shape> shapes)
        {
            return shapes.Select(x => x.Area());
        }

        public decimal Sum(IEnumerable<Shape> shapes)
        {
            return Calculate(shapes).Sum();
        }
    }
}
