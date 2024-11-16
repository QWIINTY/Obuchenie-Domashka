using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandSum = "sum";
            const string commandExit = "exit";

            int[] numbers = new int[1];

            int sum = 0;

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
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            sum += numbers[i];
                        }
                        Console.WriteLine(sum);
                        numbers = new int[1];
                        break;
                    case commandExit:
                        isWork = false;
                        break;
                    default:
                        numbers[numbers.Length - 1] = Convert.ToInt32(userInput);
                        int[] userNumbers = new int[numbers.Length + 1];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            userNumbers[i] = numbers[i];
                            Console.Write(numbers[i] + " ");
                        }
                        Console.WriteLine();
                        numbers = userNumbers;
                        break;
                }
                
            }
        }
    }
}
