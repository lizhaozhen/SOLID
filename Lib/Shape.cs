using System;

namespace Lib
{
    public abstract class Shape : IShape
    {
        public Shape(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public abstract decimal Area();
    }
}
