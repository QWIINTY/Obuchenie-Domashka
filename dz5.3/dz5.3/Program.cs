using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandSum = "sum";
            const string commandExit = "exit";

            string userInput;

            bool isWork = true;

            while (isWork)
            {
                Console.WriteLine($"1-Сумма введенных чисел. Введите команду {commandSum}");
                Console.WriteLine($"2-Выход из программы. Введите команду {commandExit}");
                Console.Write($"Введите числа, которые хотите сложить или команду: ");
                userInput = Console.ReadLine();
                Console.Clear();

                switch (userInput)
                {
                    case commandSum:
                        
                        break;
                    case commandExit:
                        isWork = false;
                        break;
                    default:
                        
                        break;
                }

            }
        }
    }
}
