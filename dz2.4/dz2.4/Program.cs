using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int maxValue = 100;
            int minValue = 0;
            int number = random.Next(minValue, maxValue);
            int firstDevider = 3;
            int secondDevider = 5;
            int result = 0;

            Console.WriteLine(number);

            for (int i = 0; i <= number; i++)
            {
                if (i % firstDevider == 0 || i % secondDevider == 0)
                    //Console.WriteLine(i);
                    result += i;
            }

            Console.WriteLine(result);
        }
    }
}
