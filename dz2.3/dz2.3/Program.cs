using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int step = 7;
            int lowLimit = 5;
            int highLimit = 103;

            for (int i =lowLimit; i <= highLimit; i += step)
            {
                Console.WriteLine(i);
            }
        }
    }
}
