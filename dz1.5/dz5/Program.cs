using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userName = "Иван";
            string userSurname = "Иванов";
            string change = userName;

            Console.WriteLine($"{userName} {userSurname}");
            userName = userSurname;
            userSurname = change;
            Console.WriteLine($"{userName} {userSurname}");
            Console.ReadKey();
        }
    }
}
