using ConsoleInharitance.Models;
using System;
using System.Collections.Generic;

namespace ConsoleInharitance
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen normalPen = new Pen(10);

            normalPen.CapOff = true;

            //normalPen.WriteTextLine("Hello World!");

            WhiteboardPen whiteboardPen = new WhiteboardPen("Red", 60);

            whiteboardPen.CapOff = true;
            
            //whiteboardPen.WriteTextLine("Hello World!");
            //(whiteboardPen as Pen).WriteTextLine("Hello World!");//Polymorth

            List<Pen> penCase = new List<Pen> { whiteboardPen, normalPen };

            foreach (Pen item in penCase)
            {
                if (item is WhiteboardPen)
                {
                    Console.Write("Whiteboard Pen: ");
                }
                item.WriteTextLine("good by world");
            }


        }
    }
}
