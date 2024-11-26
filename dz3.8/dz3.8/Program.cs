using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace dz3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] brackets = new string[8] { "(", "(", ")", "(", "(", ")", ")", ")" };
            int depth = 0;
            int counter = 0;

            for (int i = 0; i < brackets.Length; i++)
            {
                if (brackets[i] == "(")
                {
                    counter++;
                }
                else if (brackets[i] == ")")
                {
                    if (depth < counter)
                    {
                        depth = counter;
                    }
                    counter--;
                }
                if (counter < 0)
                {
                    Console.WriteLine("Нехорошее выражение!");
                    break;
                }
            }
            if (counter == 0)
            {
                Console.WriteLine($"Намана! Глубина - {depth}");
            }
            else if (counter > 0)
            {
                Console.WriteLine("Нехорошее выражение!");
            }
        }
    }
}
