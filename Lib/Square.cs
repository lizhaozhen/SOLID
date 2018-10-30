using System;

namespace Lib
{
    public class Square : Shape
    {
        public Square(decimal length)
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
