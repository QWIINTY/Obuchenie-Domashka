using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace dz4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int healthPercent = 60;
            int maxHealth = 10;

            int mannaPercent = 40;
            int maxMana = 20;

            DisplayBar(healthPercent, maxHealth, ConsoleColor.Red,0);
            DisplayBar(mannaPercent, maxMana, ConsoleColor.Blue, 1);
            Console.ReadKey();
        }

        static void DisplayBar(int value, int maxValue, ConsoleColor color, int position)
        {
            ConsoleColor defaultColor = Console.BackgroundColor;
            
            int percentConverter = 100;
            int percent = maxValue * value / percentConverter;

            string bar = "";

            for (int i = 0; i < percent; i++)
            {
                bar += " ";
            }

            Console.SetCursorPosition(0, position);
            Console.Write("[");
            Console.BackgroundColor = color;
            Console.Write(bar);
            Console.BackgroundColor = defaultColor;

            bar = "";

            for (int i = percent; i < maxValue; i++)
            {
                bar += "_";
            }

            Console.Write(bar + "]");
            Console.Write($" | {percent} / {maxValue} |");
            Console.WriteLine();
        }
    }
}
