using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace triple_fruts
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int a, b, c, d, e, f, g;

            Console.WriteLine("тяните билет");
            Console.WriteLine("есть поверье, что билет у которго сумма трех соседних чисел равна, считается счастливым, давайте попытаем вашу удачу!!!");
            Console.WriteLine((100/55+100/60)/2);
            while (true)
            {
                Console.ReadKey();
                a = rand.Next(1, 9);
                b = rand.Next(1, 9);
                c = rand.Next(1, 9);
                d = rand.Next(1, 9);
                e = rand.Next(1, 9);
                f = rand.Next(1, 9);
                g = rand.Next(1, 9);
                Console.WriteLine($"ваш билет: {a}:{b}:{c}:{d}:{e}:{f}:{g}");

                if (a+b+c == d+e+f || b+c+d == e+f+g)
                {
                    Console.WriteLine("счастливый билет");
                }
            }

        }
    }
}
