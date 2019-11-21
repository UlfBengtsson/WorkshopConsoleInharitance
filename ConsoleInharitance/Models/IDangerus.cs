using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    interface IDangerus
    {
        // defualt access level is public !!!
        int Degree { get; set; }

        string DamageDescription();
    }
}
