using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleInharitance.Models
{
    class WhiteboardPen : Pen// base = Pen
    {
        public readonly string color;
        private ConsoleColor consoleColor;

        public WhiteboardPen(string color, int textLeft) : base(textLeft)
        {
            this.color = color;
            GetConsoleColor(color);
        }

        //Hide / Shadowing with new keyword
        public new void WriteTextLine(string text)
        {
            if (CapOff)
            {
                Console.ForegroundColor = consoleColor;
                int index = 0;
                while (index < text.Length && TextLeft > 0)
                {
                    Console.Write(text[index++]);
                    TextLeft--;
                }
                Console.WriteLine();
                Console.ResetColor();
            }
        }

        private void GetConsoleColor(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    consoleColor = ConsoleColor.Red;
                    break;
                case "blue":
                    consoleColor = ConsoleColor.Blue;
                    break;
                default:
                    consoleColor = ConsoleColor.Black;
                    break;
            }
        }
    }
}
