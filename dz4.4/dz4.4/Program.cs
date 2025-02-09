using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[0];
            string[] jobTitles = new string[0];

            string userInput;

            bool isWork = true;

            Console.WriteLine("Кадровый учёт.");

            while (isWork)
            {
                Console.WriteLine("1-Добавить досье.\n2-Вывести все досье.\n3-Удалить досье.\n4-Поиск по фамилии.\n5-Выход.");
                Console.Write("Введите номер команды: ");
                userInput = Console.ReadLine();

                Console.Clear();

                switch (userInput)
                {
                    case "1":
                        EditArray(ref names, ref jobTitles);
                        break;
                    case "2":
                        OutputArray(names, jobTitles);
                        break;
                    case "3":
                        DeleteDossier(ref names, ref jobTitles);
                        break;
                    case "4":
                        SerchLastName(names, jobTitles);
                        break;
                    case "5":
                        isWork = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("Такой команды не существует.\nНажмите любую кнопку для повтора...");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
        }

        private static void EditArray(ref string[] array1, ref string[] array2)
        {
            string name;
            string jobTitle;

            Console.WriteLine("Добавить досье.");
            Console.Write("Введите ФИО сотрудника: ");
            name = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Добавить досье.");
            Console.Write("Введите должность сотрудника: ");
            jobTitle = Console.ReadLine();
            Console.Clear();

            array1 = IncreaseArray(array1, name);
            array2 = IncreaseArray(array2, jobTitle);

        }

        private static string[] IncreaseArray(string[] array, string input)
        {
            string[] tempArray = new string[array.Length + 1];

            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }

            tempArray[tempArray.Length - 1] = input;
            array = tempArray;
            return array;
        }

        private static void OutputArray(string[] array1, string[] array2)
        {
            Console.WriteLine("Все досье.");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write(i + 1 + ") ");
                Console.WriteLine($"{array1[i]}- {array2[i]}.");

            }

            Console.ReadKey();
            Console.Clear();
        }

        private static void DeleteDossier(ref string[] array1, ref string[] array2)
        {
            int number;
            int index;

            Console.WriteLine("Удалить досье.");
            Console.Write("Введите номер сотрудника: ");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0 && number <= array1.Length)
            {
                index = number - 1;
                array1 = DecreaseArray(array1, index);
                array2 = DecreaseArray(array2, index);
                Console.Clear();
                Console.WriteLine($"Досье сотрудника под номером {number} удалено.");
            }
            else
            {
                Console.WriteLine("Сотрудника с таким номером не существует.");
            }
            Console.ReadKey();
            Console.Clear();
        }

        private static string[] DecreaseArray(string[] array, int index)
        {
            string[] tempArray = new string[array.Length - 1];

            for (int i = 0; i < index; i++)
            {
                tempArray[i] = array[i];
            }
            for (int i = index; i < array.Length - 1; i++)
            {
                tempArray[i] = array[i + 1];
            }
            array = tempArray;
            return array;
        }

        private static void SerchLastName(string[] arrray1, string[] array2)
        {
            string lastName;
            bool lastNameIsFound = false;

            Console.WriteLine("Поиск по фамилии.");
            Console.Write("Введите фамилию сотрудника: ");
            lastName = Console.ReadLine();

            for (int i = 0; i < arrray1.Length; i++)
            {
                string[] split = arrray1[i].Split(' ');

                if (lastName.ToLower() == split[0].ToLower())
                {
                    Console.WriteLine($"{i + 1}) {arrray1[i]}- {array2[i]}.");
                    lastNameIsFound = true;
                }

            }
            if (lastNameIsFound == false)
            {
                Console.Clear();
                Console.WriteLine("Такого сотрудника нет.");
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
