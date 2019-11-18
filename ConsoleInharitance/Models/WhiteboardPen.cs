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
            consoleColor = GetConsoleColor(color);
        }

        //overrides virtual from parent class even if it is polymorth to parent Pen
        public override void WriteTextLine(string text)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = consoleColor;
            base.WriteTextLine(text);
            Console.ResetColor();
        }

        private static ConsoleColor GetConsoleColor(string color)
        {
            switch (color.ToLower())
            {
                case "red":
                    return ConsoleColor.Red;
                case "blue":
                    return ConsoleColor.Blue;
                default:
                    return ConsoleColor.Black;

            }
        }
    }
}
