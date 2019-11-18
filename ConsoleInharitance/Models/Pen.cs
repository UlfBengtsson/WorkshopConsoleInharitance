using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    class Pen
    {
        public int TextLeft { get; protected set; }
        public bool CapOff { get; set; }

        public Pen(int textLeft)
        {
            TextLeft = textLeft;
        }

        public void WriteTextLine(string text)
        {
            if (CapOff)
            {
                int index = 0;
                while (index < text.Length && TextLeft > 0)
                {
                    Console.Write(text[index++]);
                    TextLeft--;
                }
                Console.WriteLine();
            }
        }
    }
}
