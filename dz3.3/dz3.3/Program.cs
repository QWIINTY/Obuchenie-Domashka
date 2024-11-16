using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minValue = 0;
            int maxValue = 100;
            Random random = new Random();

            int[] array = new int[30];
            int elements;

            int firstElement;
            int lastElement;

            for (elements = 0; elements < array.Length; elements++)
            {
                array[elements] = random.Next(minValue, maxValue);
                Console.Write($"|{array[elements]}|");

            }

            Console.WriteLine("\n");

            for (elements = 1; elements < array.Length - 1; elements++)
            {
                if (array[elements] > array[elements - 1] && array[elements] > array[elements + 1])
                {
                    Console.WriteLine($"Локальный максимум - ({array[elements]})");
                }
            }
            if (array[0] > array[1])
            {
                firstElement = array[0];
                Console.WriteLine($"Первый элемент является лоальным максимумом - {firstElement}");
            }
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                lastElement = array[array.Length - 1];
                Console.WriteLine($"Последний элемент является локальным максимумом - {lastElement}");
            }
        }
    }
}
