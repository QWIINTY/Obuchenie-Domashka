using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[4] { 1, 2, 3, 4 };
            int tempNumber = 0;
            int shift;
            int userInput;

            Console.Write("Введите на сколько сдвинуть: ");
            userInput = Convert.ToInt32(Console.ReadLine());

            shift = userInput % array.Length;

            for (int i = 0; i < shift; i++)
            {
                tempNumber = array[0];

                for (int j = 0; j <array.Length-1; j++)
                {
                    array[j]= array[j+1];
                }

                array[array.Length-1] = tempNumber;
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}
