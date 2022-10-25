using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 10; i < 20; i++)
            {
                total += i + 1;
            }
            Console.WriteLine(total.ToString());

            Console.ReadLine();

        }
    }
}
