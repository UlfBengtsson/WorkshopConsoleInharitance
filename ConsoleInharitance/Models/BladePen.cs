using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    public class BladePen : Pen /* Can ONLY inherit ONE class !!!*/ 
                          , IDangerus /* Can implement as meny Interfaces as you like */
    {
        private int degree;
        public double BladeWidth { get; set; }
        public double BladeLength { get; set; }

        public BladePen(int cutsLeft) : base(cutsLeft) {}

        public BladePen(int cutsLeft, double bladeLength, double bladeWidth) : this(cutsLeft) 
        {
            BladeLength = bladeLength;
            BladeWidth = bladeWidth;
        }

        public int Degree { get => degree; set => degree = value; }

        public string DamageDescription()
        {
            return "Cut & stab wounds.";
        }
    }
}
