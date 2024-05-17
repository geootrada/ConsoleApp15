using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum = 0;

            Random rand = new Random();
            number = rand.Next(0, 100);
            Console.WriteLine($"Мы получили случайное число {number}.");

            for (int i = 0; i <= number; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                sum += i;
            }
            Console.WriteLine($"Полученная сумма по заданию {sum}");
        }
    }
}