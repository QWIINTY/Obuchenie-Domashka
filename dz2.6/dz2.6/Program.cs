using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName;
            string userSimbol;
            int stringLength;
            int stringHeigth = 1;

            Console.Write("Введите своё имя: ");
            userName = Console.ReadLine();
            Console.Write("Введите символ: ");
            userSimbol = Console.ReadLine();

            string someString = userName + userSimbol + userSimbol;
            stringLength = someString.Length;
            Console.WriteLine(stringLength);


            for (int i = 0; i < stringHeigth; i++)
            {

                for (int j = 0; j < stringLength; j++)
                {
                    Console.Write(userSimbol);
                }

                Console.WriteLine();
                Console.WriteLine($"{userSimbol}{userName}{userSimbol}");

                for (int j = 0; j < stringLength; j++)
                {
                    Console.Write(userSimbol);
                }
                Console.WriteLine();
            }
        }
    }
}
