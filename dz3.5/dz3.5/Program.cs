using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 9, 3, 5, 1, 2, 4, 7, 8, 6, 10 };
            int tempNumber;

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        tempNumber = array[j];
                        array[j] = array[i];
                        array[i] = tempNumber;

                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] + " | ");
            }
        }
    }
}
