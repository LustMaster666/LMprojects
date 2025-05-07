using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace randchoice
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int bchois;
            int choise;
            int trys = 10;
            bchois = rand.Next(1, 101);
            while (trys >= 0)
            {
            Console.WriteLine($"у вас осталось {trys} попыток");
            Console.WriteLine("введите число от 1 до 100");
            choise = Convert.ToInt32(Console.ReadLine());
                if (choise == bchois)
                {
                    Console.WriteLine($"вы смогли за {10-trys} количество попыток");
                    break;
                }
                else Console.WriteLine("не угадал лошара ебаная");
                {
                    trys--;
                if (bchois > choise)
                {
                    Console.WriteLine("больше");
                }
                if (bchois < choise)
                {
                    Console.WriteLine("меньше");
                }
                }

            }

        }
    }
}
