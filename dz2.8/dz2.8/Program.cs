using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = 10;
            int maxValue = 26;
            int number;
            int numberMultiple;
            int numbersCount = 0;
            int startPoint = 0;
            int lowLimit = 50;
            int highLimit = 150;

            Random random = new Random();
            number = random.Next(minValue, maxValue);

            Console.WriteLine(number);

            for (numberMultiple = startPoint; numberMultiple <= highLimit; numberMultiple += number)
            {
                if (numberMultiple >= lowLimit)
                {
                    numbersCount++;
                    Console.WriteLine(numberMultiple);
                }
            }

            Console.WriteLine(numbersCount);
            Console.ReadKey();
        }
    }
}
