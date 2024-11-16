using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pictures = 52;
            int picturesInRow = 3;

            int rows = pictures / picturesInRow;
            int extraPictures = pictures % picturesInRow;

            Console.WriteLine($"Заполненных рядов {rows}.");
            Console.WriteLine($"Лишних картинок {extraPictures}.");

        }
    }
}
