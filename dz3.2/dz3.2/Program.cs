using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxElement = 0;

            int minvalue = 1;
            int maxValue = 100;

            Random random = new Random();
            int[,] array = new int[10, 10];
            int lines;
            int columns;

            for (lines = 0; lines < array.GetLength(0); lines++)
            {
                for (columns = 0; columns < array.GetLength(1); columns++)
                {
                    array[lines, columns] = random.Next(minvalue, maxValue);
                    Console.Write(array[lines, columns] + " | ");

                    if (maxElement < array[lines, columns])
                    {
                        maxElement = array[lines, columns];
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(maxElement);

            for (lines = 0; lines < array.GetLength(0); lines++)
            {
                for (columns = 0; columns < array.GetLength(1); columns++)
                {
                    if (array[lines, columns] == maxElement)
                    {
                        array[lines, columns] = 0;
                    }
                    Console.Write(array[lines, columns] + " | ");
                }
                Console.WriteLine();
            }
        }
    }
}
