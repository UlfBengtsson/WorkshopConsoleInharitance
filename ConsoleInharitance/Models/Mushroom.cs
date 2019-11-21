using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    class Mushroom : IDangerus
    {
        private int degree;
        public string Name { get; set; }
        public int Degree { get => degree; set => value = degree; }

        public string DamageDescription()
        {
            return "Poison";
        }
    }
}
