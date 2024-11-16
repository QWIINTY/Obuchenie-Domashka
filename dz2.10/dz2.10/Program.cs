using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dz2._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string commandPlayerAttack = "1";
            const string commandFireBall = "2";
            const string commandExplosion = "3";
            const string commandHeal = "4";

            string playerInput;
            int playerHealth = 100;
            int playerManna = 50;

            int minPlayerAttackDamage = 10;
            int maxPlayerAttackDamage = 35;
            int playerDamage;
            Random playerRandom = new Random();

            int fireBallDamage = 50;
            int fireMannaCost = 7;
            int explosionDamage = 65;
            int explosionMannaCost = 12;
            bool canExplosion = false;
            int healthRestoration = 20;
            int mannaRestoration = 35;
            int trysHeal = 3;

            int bossHealth = 500;
            int bossDamage;

            int minBossDamage = 5;
            int maxBossDamage = 25;
            Random bossRandom = new Random();   

            Console.WriteLine($"Перед тобой стоит босс подземелья.\nУ тебя есть несколько вариантов атаки." +
                $"\nТы и босс атакуете по очереди.\nСейчас твой ход.\nВыбери, что будешь делать." +
                $"\nЕсли ошибёшься с вводом, ход перейдет к боссу!");
            Console.WriteLine($"Твоё здоровье: {playerHealth}.\nТвоя манна: {playerManna}.");
            Console.WriteLine($"Здоровье босса: {bossHealth}.");
            Console.WriteLine($"Ты можешь:\n{commandPlayerAttack}. Обычная атака." +
                $"\n{commandFireBall}. Огненный шар. Он стоит {fireMannaCost} манны." +
                $"\n{commandExplosion}. Взрыв. Можно использовать только после огненного шара. Он стоит {explosionMannaCost} манны." +
                $"\n{commandHeal}. Лечение." +
                $" Восстанавливает здоровье и манну. Можно использовать только 3 раза.");

            while (playerHealth > 0 || bossHealth > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.BackgroundColor = ConsoleColor.DarkGray;

                Console.Write($"Введи свой выбор: ");
                playerInput = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;

                playerDamage = playerRandom.Next(minPlayerAttackDamage, maxPlayerAttackDamage);
                bossDamage = bossRandom.Next(minBossDamage, maxBossDamage);

                switch (playerInput)
                {
                    case commandPlayerAttack:
                        bossHealth -= playerDamage;
                        Console.WriteLine($"Ты нанес {playerDamage} урона.");
                        Console.WriteLine($"Здоровье босса: {bossHealth}.");
                        break;
                    case commandFireBall:
                        if (playerManna >= fireMannaCost)
                        {
                            playerManna -= fireMannaCost;
                            bossHealth -= fireBallDamage;
                            canExplosion = true;
                            Console.WriteLine($"Ты нанес {fireBallDamage} урона.");
                            Console.WriteLine($"Здоровье босса: {bossHealth}.");
                            Console.WriteLine($"Твоя манна: {playerManna}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не получилось использовать!");
                            break;
                        }
                    case commandExplosion:
                        if (canExplosion == true && playerManna >= 12)
                        {
                            bossHealth -= explosionDamage;
                            playerManna -= explosionMannaCost;
                            canExplosion = false;
                            Console.WriteLine($"Ты нанес {explosionDamage} урона.");
                            Console.WriteLine($"Здоровье босса: {bossHealth}.");
                            Console.WriteLine($"Твоя манна: {playerManna}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Не получилось использовать!");
                            break;
                        }
                    case commandHeal:
                        if (trysHeal > 0)
                        {
                            playerHealth += healthRestoration;
                            playerManna += mannaRestoration;
                            trysHeal--;
                            Console.WriteLine($"Ты восствноыил {healthRestoration} здоровья и " +
                                $"{mannaRestoration} манны.");
                            Console.WriteLine($"Осталось использований: {trysHeal}");
                            Console.WriteLine($"Твоё здоровье: {playerHealth}.\nТвоя манна: {playerManna}.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Больше нет попыток для использования.");
                            break;
                        }
                    default:
                        Console.WriteLine("Вы ошиблись. Ход переходит к боссу.");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.BackgroundColor = ConsoleColor.DarkGray;

                Console.WriteLine("Ход босса.");

                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;

                playerHealth -= bossDamage;
                Console.WriteLine($"Ты получил {bossDamage} урона.\nТвоё здоровье: {playerHealth}.");


                if (playerHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы проиграли.");
                    break;
                }
                else if (bossHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Вы победили.");
                    break;
                }
                else if (playerHealth <= 0 && bossHealth <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Ничья.");
                    break;
                }
            }
        }
    }
}
