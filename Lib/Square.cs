using System;

namespace Lib
{
    public class Square : Shape, ISquare
    {
        public Square(decimal length, string name = "Square") : base(name)
        {
            Length = length;
        }
        public decimal Length { get; set; }

        public override decimal Area()
        {
            return Length * Length;
        }
    }
}
