using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 10;

            while (counter < 20)
            {
                total += counter + 1;

                counter++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();

        }
    }
}
