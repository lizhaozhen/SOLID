using System;
using System.Collections.Generic;

namespace Lib
{
    public class ShapeFactory : IShapeFactory
    {
        public List<IShape> CreateShapes()
        {
            return new List<IShape>{
                new Circle(3),
                new Square(2),
                new Rectangle(4, 5)
            };
        }
    }
}
