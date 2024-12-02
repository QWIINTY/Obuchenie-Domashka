using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age;
            int birthday;
            string name;
            string zodiacSign;
            string placeOfWork;

            Console.Write($"Привет, введи своё имя: ");
            name = Console.ReadLine();
            Console.Write($"Введи число своего рождения: ");
            birthday = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введи свой возраст: ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Введи свой знак зодиака: ");
            zodiacSign = Console.ReadLine();
            Console.Write($"Введи своё место работы: ");
            placeOfWork = Console.ReadLine();

            Console.WriteLine($"Немного о тебе. Тебя зовут: {name}. Число когда ты родился: {birthday}." +
                $" Твой возраст: {age}. Твой знак зодиака: {zodiacSign}. Твоё место работы: {placeOfWork}");
            Console.ReadKey();
        }
    }
}
