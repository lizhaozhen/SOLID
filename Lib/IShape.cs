using System;

namespace Lib
{
    public interface IShape
    {
        string Name {get;set;}
        decimal Area();
    }
}
