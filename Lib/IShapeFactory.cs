using System;
using System.Collections.Generic;

namespace Lib
{
    public interface IShapeFactory
    {
        List<IShape> CreateShapes();
    }
}
