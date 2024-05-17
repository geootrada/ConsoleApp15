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
            int lower = 0;
            int upper = 100;
            int multiple1 = 3;
            int multiple2 = 5;

            Random random = new Random();
            number = random.Next(lower, upper);
            Console.WriteLine($"Мы получили случайное число {number}.");

            for (int i = 0; i <= number; i++)
            {
                if (i % multiple1 == 0 || i % multiple2 == 0)
                sum += i;
            }
            Console.WriteLine($"Полученная сумма по заданию {sum}");
        }
    }
}