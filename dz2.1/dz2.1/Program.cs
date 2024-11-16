using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userMessage;
            int messageRepeat;

            Console.WriteLine($"Какое сообщение мне написать?");
            userMessage = Console.ReadLine();
            Console.WriteLine($"Сколько раз его повторить?");
            messageRepeat = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < messageRepeat; i++)
            {
                Console.WriteLine(userMessage);
            }
        }
    }
}
