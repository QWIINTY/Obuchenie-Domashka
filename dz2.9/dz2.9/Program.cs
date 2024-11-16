using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberRaised = 2;
            int degree = 0;
            int result = 1;
            int minValue = 0;
            int maxValue = 101;

            Random random = new Random();
            int number = random.Next(minValue, maxValue);

            while (result <= number)
            {
                degree++;
                result *= numberRaised;
            }
            Console.WriteLine($"Случайное число: {number}.\nМинимальная степень: {degree}." +
                $"\nЧисло возводимое в степень: {numberRaised}.\n{number} в степени {degree}: {result}.");
        }
    }
}
