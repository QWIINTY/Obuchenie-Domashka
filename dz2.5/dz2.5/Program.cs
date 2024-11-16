using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace dz2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string CommandGreeting = "1";
            const string CommandShowText = "2";
            const string CommandShowOtherText = "3";
            const string CommandJoke = "4";
            const string CommandFact = "5";
            const string CommandRandomNumber = "6";
            const string CommandConsoleClear = "7";
            const string CommandExit = "8";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            bool isWork = true;
            string userInput;

            int minValue = 0;
            int maxValue = 1001;

            Random random = new Random();
            int randomNumber;


            while (isWork)
            {
                Console.WriteLine($"Я твой терминал. Вот, что я могу: ");
                Console.WriteLine($"{CommandGreeting}. Приветствие.");
                Console.WriteLine($"{CommandShowText}. Показать фразу.");
                Console.WriteLine($"{CommandShowOtherText}. Показать другую фразу.");
                Console.WriteLine($"{CommandJoke}. Шутка.");
                Console.WriteLine($"{CommandFact}. Факт.");
                Console.WriteLine($"{CommandRandomNumber}. Рандомное число.");
                Console.WriteLine($"{CommandConsoleClear}. Очистить консоль");
                Console.WriteLine($"{CommandExit}. Выход.");
                Console.Write($"Введи номер команды: ");

                userInput = Console.ReadLine();

                switch (userInput)
                {

                    case CommandGreeting:
                        Console.WriteLine("Привет!");
                        break;
                    case CommandShowText:
                        Console.WriteLine("Продам гараж!");
                        break;
                    case CommandShowOtherText:
                        Console.WriteLine("Дверь мне запили!");
                        break;
                    case CommandJoke:
                        Console.WriteLine("Колобок повесился.");
                        break;
                    case CommandFact:
                        Console.WriteLine("Я не человек.");
                        break;
                    case CommandRandomNumber:
                        randomNumber = random.Next(minValue, maxValue);
                        Console.WriteLine(randomNumber);
                        break;
                    case CommandConsoleClear:
                        Console.Clear();
                        break;
                    case CommandExit:
                        isWork = false;
                        Console.WriteLine("Я выключилась");
                        break;
                    default:
                        Console.WriteLine("Такого я не умею.");
                        break;
                }
            }

            Console.ReadKey();

        }
    }
}
