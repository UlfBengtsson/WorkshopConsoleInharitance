using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    class Cube : Shape
    {
        public double Deep { get; set; }
        public Cube(double heigth, double width, double deep) : base(heigth, width)
        {
            Deep = deep;
        }

        public override double Area => Heigth * Width;

        public double Volume()
        {
            return Heigth * Width * Deep;
        }
    }
}
