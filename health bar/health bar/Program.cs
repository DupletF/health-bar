using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace health_bar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 5, maxhealth = 10;

            DrawBar(health, maxhealth, ConsoleColor.Red);
        }


        static void DrawBar(int Value, int MaxValue, ConsoleColor color)
        {
            ConsoleColor defaultcolor = Console.BackgroundColor;
            string bar = "";

            for(int i = 0; i < Value; i++)
            {
                bar += ' ';
            }
            Console.SetCursorPosition(0, 0);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultcolor;

            bar = " ";

            for (int i = Value; i < MaxValue; i++)
            {
                bar += ' ';
            }
            Console.Write(bar + "]");
        }
    }
}
