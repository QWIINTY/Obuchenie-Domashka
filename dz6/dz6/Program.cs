using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace dz6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userMoney;
            int crystalPrice = 10;
            int crystals;
            int crystalsCost;

            Console.Write($"Сколько у тебя деняг: ");
            userMoney = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Сколько кристалов хочешь купить: ");
            crystals = Convert.ToInt32(Console.ReadLine());

            crystalsCost = crystals * crystalPrice;
            userMoney -= crystalsCost;

            Console.WriteLine($"У тебя в карманах лежит: {userMoney} деняг и {crystals} кристалов.");
            Console.ReadKey();
        }
    }
}
