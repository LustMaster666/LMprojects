using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushenRulett
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("привет смертники");
            Console.WriteLine("ты сидишь в падвале за столом, против тебя играет такой же бедолага как ты, ты берешь ствол с 6 отсеками и делаешь выстрел в бедалагу, зная что ваши выстрелы идут по очереди.....");
            string fplayer = Console.ReadLine();
            int bulletplace = rand.Next(1, 7);
            while(bulletplace > 0)
            {
                if (bulletplace != 0)
                {
                    Console.WriteLine("SHOT");
                    Console.WriteLine("промох, ход следующему");
                    bulletplace--;
                    Console.ReadKey();
                }
                
            }
            if (bulletplace == 0)
            {
                Console.WriteLine("здох лошара");
            }
            Console.WriteLine("конец игры, победитель берет лопату");
        }
    }
}
