using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Бу! испугался? не бойся. я добрый.";

            char[] separators=new char[] { ' ', '.', '!', '?' };
            string[]wordsSplit=text.Split(separators,StringSplitOptions.RemoveEmptyEntries);

            foreach (string word in wordsSplit)
            {
                Console.WriteLine(word);
            }
        }
    }
}
