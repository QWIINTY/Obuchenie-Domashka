using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] array =
            {
                {1,2,3},
                {10,10,10},
                {11,11,11}
            };

            int lines;
            int columns;
            int sum = 0;
            int product = 1;

            for (lines = 0; lines < array.GetLength(0); lines++)
            {
                for (columns = 0; columns < array.GetLength(1); columns++)
                {
                    if (lines == 1)
                    {
                        sum += array[lines, columns];
                    }
                    if (columns == 0)
                    {
                        product *= array[lines, columns];
                    }
                    Console.Write(array[lines, columns] + " | ");
                }
                Console.WriteLine();
            }
                Console.WriteLine(sum+" - сумма.");
                Console.WriteLine(product+" - произведение.");
        }
    }
}
