using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int helth = 6;
            int bothelth = 6;
            bool brake;
            bool botbrake;

            while(helth > 0 && bothelth > 0 && helth != 0 && bothelth != 0)
            {
                Console.WriteLine("кидайте кости");
                Console.ReadKey();
            int damage = rand.Next(1, 7);
            int botarmor = rand.Next(1, 7);
                botbrake = damage > botarmor;
                bothelth = bothelth + (botarmor - damage)*Convert.ToInt32(botbrake);
                Console.WriteLine($"ваш урон: {damage} защита противника: {botarmor}");
                if (damage > botarmor)
                {
                    Console.WriteLine("вы пробили броню");
                }
                else
                {
                    Console.WriteLine("вы не смогли пробить броню");
                }
                Console.WriteLine($"ваше здоровье: {helth} здоровье противника: {bothelth}");
                Console.ReadKey();


                Console.WriteLine("черед противника, молись");
                Console.ReadKey();
            int botdamage = rand.Next(1, 7);
            int armor = rand.Next(1, 7);
                brake = botdamage > armor;
                helth = helth + (armor - botdamage)*Convert.ToInt32(brake);
                Console.WriteLine($"ваша защита: {armor} урон противника: {botdamage}");
                if (botdamage > armor)
                {
                    Console.WriteLine("противник пробил вашу броню");
                }
                else
                {
                    Console.WriteLine("хорошо помолились, ваша броня выстаила");
                }
                Console.WriteLine($"ваше здоровье: {helth} здоровье противника: {bothelth}");
            }
            if (helth > bothelth)
            {
                Console.WriteLine("мои поздравления, вы одолели противника");
            }
            else
            {
                Console.WriteLine("мои соболезнования, вы были повержены");
            }
            Console.WriteLine("игра окончена");
        }
    }
}
