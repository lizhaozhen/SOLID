using System;

namespace Lib
{
    public class Rectangle : Shape, IRectangle
    {
        public Rectangle(decimal width, decimal height, string name = "Rectangle") : base(name)
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
