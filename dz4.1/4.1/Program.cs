﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = GetNumber();

            Console.Clear();
            Console.WriteLine($"Ваше число: {number}.");
            Console.ReadKey();
        }
        static int GetNumber()
        {
            int number = 0;
            bool isWork = true;
            string userInput;

            while (isWork)
            {
                Console.Write("Введите число: ");
                userInput = Console.ReadLine();

                if(int.TryParse(userInput, out number))
                {
                    isWork = false;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Введено неверное число.");
                }
            }
            return number;
        }
    }
}