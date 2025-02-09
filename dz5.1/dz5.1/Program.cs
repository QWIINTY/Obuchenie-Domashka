using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> words = new Dictionary<string, string>();

            string userInput;
            bool isWork = true;

            words.Add("Данж", "Подземелье с возможностью выпадения лута.");
            words.Add("Лут", "Предметы выпавшие с мобов.");
            words.Add("Моб", "Игровой персонаж под управлением компьютерра.");
            words.Add("ММО", "Мультиплеерная рпг игра.");


            while (isWork)
            {
                Console.WriteLine($"1- Показать все слова.\n2- Ввести слово, значение которого нужно узнать.\n3- Выход.");
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        ShowAllWords(words);
                        break;
                    case "2":
                        ShowWordsMeaning(words);
                        break;
                    case "3":
                        isWork = false;
                        break;
                }

            }
        }

        private static void ShowAllWords(Dictionary<string, string> words)
        {
            int number = 0;
            Console.Clear();

            Console.WriteLine("Вы можете узнать значения этих слов:");

            foreach (var word in words)
            {
                number++;
                Console.WriteLine($"{number}) {word.Key}.");
            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void ShowWordsMeaning(Dictionary<string, string> words)
        {
            string userInput;

            Console.Clear();
            Console.Write($"Введите слово: ");
            userInput = Console.ReadLine();

            if(words.ContainsKey(userInput))
            {
                Console.WriteLine($"{userInput} - {words[userInput]}");
            }
            else
            {
                Console.WriteLine("Такого слова нет в словаре.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
