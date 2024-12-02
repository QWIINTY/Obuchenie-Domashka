using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int grannys;
            int receptionTimeInMinutes = 10;
            int minutesInHour = 60;
            int waitingTime;
            int waitingMinutes;
            int waitingHours;

            Console.WriteLine($"Сколько бабок перед вами в очереди?");
            grannys = Convert.ToInt32(Console.ReadLine());

            waitingTime = grannys * receptionTimeInMinutes;
            waitingHours = waitingTime / minutesInHour;
            waitingMinutes = waitingTime % minutesInHour;

            Console.WriteLine($"Вам ждать {waitingHours} часов и {waitingMinutes} минут.");
        }
    }
}
