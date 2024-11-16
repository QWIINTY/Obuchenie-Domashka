using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pasword = "123";
            string secret = "jopa";
            int trysCount = 3;
            string userInput;
            bool isWork = true;

            while (isWork)
            {
                Console.Write($"Введите пароль: ");
                userInput = Console.ReadLine();
                if (userInput == pasword)
                {
                    Console.WriteLine(secret);
                    isWork = false;
                }
                else
                {
                    trysCount--;
                    Console.WriteLine($"Не верный пароль!\nПопыток осталось: {trysCount}");
                }
                if (trysCount == 0)
                {
                    Console.WriteLine("У вас закончились попытки!");
                    isWork = false;
                }

            }
        }
    }
}
