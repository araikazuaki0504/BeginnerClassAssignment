using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Number = { 1, 2, 3, 4, 5 };

            for (int i = 0; i < 5; i ++)
            {
                Console.WriteLine(Number[i].ToString());
            }

            Console.ReadLine();

        }
    }
}
