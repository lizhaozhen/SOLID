using System;

namespace Lib
{
    public class Circle : Shape, ICircle
    {
        public Circle(decimal r, string name = "Circle") : base(name)
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
