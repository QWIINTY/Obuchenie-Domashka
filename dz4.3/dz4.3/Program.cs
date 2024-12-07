using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            for (int i = 0; i < arrayNumbers.Length; i++)
            {
                Console.Write($"| {arrayNumbers[i]} |");
            }
            Console.WriteLine(" - Original");

            Shuffle(arrayNumbers);
        }

        static void Shuffle(int[] array)
        {
            Random random = new Random();
         
            int randomIndex;
            int shuffledElement;

            for (int i = array.Length-1; i >=0; i--)
            {
                randomIndex=random.Next(i);
                shuffledElement = array[randomIndex];
                array[randomIndex] = array[i];
                array[i] = shuffledElement;
                Console.Write($"| {shuffledElement} |");
            }
        Console.WriteLine(" - Shuffle");
        }
        }

}


