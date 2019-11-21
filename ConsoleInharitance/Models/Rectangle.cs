using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    class Rectangle : Shape
    {
        public Rectangle(double heigth, double width) : base(heigth, width)
        {
        }

        public override double Area
        { 
            get 
            {
                return Width * Heigth;
            }
        }
    }
}
