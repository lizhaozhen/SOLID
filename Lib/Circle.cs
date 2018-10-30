using System;

namespace Lib
{
    public class Circle : Shape
    {
        public Circle(decimal r)
        {
            Radius = r;
        }

        public decimal Radius { get; set; }

        public override decimal Area()
        {
            return (decimal)Math.PI * Radius * Radius;
        }
    }
}
