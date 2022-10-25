using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int total = 0;

            int x = 0;
            while (x < 10)
            {
                total += numbers[x];
                x++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();

        }
    }
}
