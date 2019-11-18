using ConsoleInharitance.Models;
using System;

namespace ConsoleInharitance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen normalPen = new Pen(10);

            normalPen.CapOff = true;

            normalPen.WriteTextLine("Hello World!");

            WhiteboardPen whiteboardPen = new WhiteboardPen("Red", 30);

            whiteboardPen.CapOff = true;

            (whiteboardPen as Pen).WriteTextLine("Hello World!");
        }
    }
}
