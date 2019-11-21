using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    public abstract class Shape
    {
        public double Heigth { get; set; }
        public double Width { get; set; }

        public Shape(double heigth, double width)
        {
            Heigth = heigth;
            Width = width;
        }

        public abstract double Area { get; }
    }
}
