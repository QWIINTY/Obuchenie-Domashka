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
            float userRub;
            float userUsd;
            float userEur;

            int rubToUsd = 98, usdToRub = 100;
            int rubToEur = 106, eurToRub = 110;
            int usdToEur = 2, eurToUsb = 4;

            float exchangeCurrencyCount;

            string desiredOperation;

            Console.WriteLine($"Я конвертер валют.");

            Console.Write($"Введи баланс рублей: ");
            userRub = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введи баланс долларов: ");
            userUsd = Convert.ToSingle(Console.ReadLine());
            Console.Write($"Введи баланс евро: ");
            userEur = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Выбери операцию.");
            Console.WriteLine("1- Обменять рубли на доллары.");
            Console.WriteLine("2 - Обменять рубли на евро.");
            Console.WriteLine("3 - Обменять доллары на рубли.");
            Console.WriteLine("4 - Обменять доллары на евро.");
            Console.WriteLine("5 - Обменять евро на рубли.");
            Console.WriteLine("6 - Обменять евро на доллары.");
            Console.Write("Ваш выбор: ");
            desiredOperation = Console.ReadLine();

            switch (desiredOperation)
            {
                case "1":
                    Console.WriteLine("Обмне рублей на доллары.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userRub>=exchangeCurrencyCount)
                    {
                        userRub -= exchangeCurrencyCount;
                        userUsd += exchangeCurrencyCount / rubToUsd;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно деняг.");
                    }
                    break;
                case "2":
                    Console.WriteLine("Обмне рублей на евро.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userRub>=exchangeCurrencyCount)
                    {
                        userRub-=exchangeCurrencyCount;
                        userEur += exchangeCurrencyCount / rubToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно деняг.");
                    }
                    break;
                case "3":
                    Console.WriteLine("Обмне долларов на рубли.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userUsd>=exchangeCurrencyCount)
                    {
                        userUsd -= exchangeCurrencyCount;
                        userRub += exchangeCurrencyCount * usdToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно деняг.");
                    }
                    break;
                case "4":
                    Console.WriteLine("Обмне долларов на евро");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userUsd>=exchangeCurrencyCount)
                    {
                        userUsd-=exchangeCurrencyCount;
                        userEur += exchangeCurrencyCount / usdToEur;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно деняг.");
                    }
                    break;
                case "5":
                    Console.WriteLine("Обмне евро на рубли.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userEur>=exchangeCurrencyCount)
                    {
                        userRub -= exchangeCurrencyCount;
                        userRub += exchangeCurrencyCount * eurToRub;
                    }
                    else
                    {
                        Console.WriteLine("Недостаточно деняг.");
                    }
                    break;
                case "6":
                    Console.WriteLine("Обмне евро на доллары.");
                    Console.Write("Сколько вы хотите обменять: ");
                    exchangeCurrencyCount = Convert.ToSingle(Console.ReadLine());
                    if (userEur>=exchangeCurrencyCount)
                    {
                        userEur -= exchangeCurrencyCount;
                        userUsd += exchangeCurrencyCount * eurToUsb;
                    }
                    break;
                default:
                    Console.WriteLine("Выбрана неверная операция.");
                    break;
            }
            Console.WriteLine($"У вас {userRub} рублей. {userUsd} долларов. {userEur} евро.");
        }
    }
}
