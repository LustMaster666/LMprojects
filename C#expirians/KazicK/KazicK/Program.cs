using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KazicK
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
                Console.WriteLine("добро пожаловать в никиткин казик!!!");
                Console.WriteLine("минимальная ставка 100");
            double bal = 1000;
                Console.WriteLine($"ваш баланс: {bal}");
            decimal minValue = 0.001m;
            decimal maxValue = 3.0m; 

            while(bal >= 100)
            {
                Console.WriteLine("Ваши ставки господа");
            int bet = Convert.ToInt32(Console.ReadLine());
            bool minbet = bet >= 100;
            bet *= Convert.ToInt32(minbet);

            double range = (double)(maxValue - minValue);
            double randomDouble = rand.NextDouble() * range + (double)minValue;
            decimal K = (decimal)randomDouble;

            double price = Convert.ToDouble(bet * K);
            bal = Convert.ToDouble(bal - bet + price);
                Console.WriteLine($"баланс: {bal}");
                Console.WriteLine($"ставка: {bet}");
                Console.WriteLine($"выпал к: {K}");
                Console.WriteLine($"полученно: {price - bet}");
            }

                Console.WriteLine($"ВЫ БАНКРОТ!!!!! ВОТ ВАША ЖАЛКАЯ СУММА: {bal} ");
        }
    }
}
