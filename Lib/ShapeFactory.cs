using System;
using System.Collections.Generic;

namespace Lib
{
    public class ShapeFactory
    {
        public List<Shape> CreateShapes()
        {
            return new List<Shape>{
                new Circle(3),
                new Square(2),
                new Rectangle(4, 5)
            };
        }
    }
}
