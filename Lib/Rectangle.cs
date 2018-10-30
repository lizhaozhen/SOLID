using System;

namespace Lib
{
    public class Rectangle : Shape
    {
        public Rectangle(decimal width, decimal height)
        {
            Width = width;
            Height = height;
        }

        public decimal Width { get; set; }
        public decimal Height { get; set; }

        public override decimal Area()
        {
            return Width * Height;
        }
    }
}
