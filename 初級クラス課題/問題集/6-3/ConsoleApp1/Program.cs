using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;

            for (int i = 0; i < 5; i++)
            {
                total += i + 1;
            }
            Console.WriteLine(total.ToString());

            Console.ReadLine();

        }
    }
}
