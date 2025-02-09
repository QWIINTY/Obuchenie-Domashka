using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> clients = CreateQueue();

            int money = 0;
            int clientNumber = 1;


            while (clients.Count > 0)
            {
               int purchase=clients.Dequeue();
                money += purchase;

                Console.WriteLine($"{clientNumber}  клиент купил на {purchase} медных.");
                clientNumber++;
                Console.WriteLine($"В кошельке - {money}");
                Console.ReadKey();
                Console.Clear();
            }
        }

        private static Queue<int> CreateQueue()
        {
            Queue<int> clients = new Queue<int>();
            Random random = new Random();

            int maxValue = 100;
            int minValue = 1;
            string userInput;

            Console.Write("Введите количество покупателей в очереди: ");
            userInput = Console.ReadLine();
            Console.Clear();

            if (int.TryParse(userInput, out int number))
            {
                for (int i = 0; i < number; i++)
                {
                    clients.Enqueue(random.Next(minValue,maxValue));
                }
            }
            return clients;

        }
    }
}
