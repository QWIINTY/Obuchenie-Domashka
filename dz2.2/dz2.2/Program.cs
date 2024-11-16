using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exit = "exit";
            string userInput;

            Console.Write($"Введите команду выхода:");
            userInput = Console.ReadLine();

            while (userInput != exit)
            {
                Console.WriteLine("Не верная команда");
                Console.Write("Повторите попытку: ");
                userInput = Console.ReadLine();
            }
        }
    }
}
