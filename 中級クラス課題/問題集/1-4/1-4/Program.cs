using System;

namespace _1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand1 = new Random();

            for (int i = 0; i < 10; i++)
            {
                int number = rand1.Next(100);
                Console.WriteLine(number.ToString());
            }

            Console.WriteLine("----");

            for (int i = 0; i < 10; i++)
            {
                Random rand2 = new Random();
                int number = rand2.Next(100);
                Console.WriteLine(number.ToString());
            }

            Console.ReadLine();
        }
    }
}
