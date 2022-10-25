using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int counter = 0;

            while (counter < 5)
            {
                total += counter + 1;

                counter++;
            }

            Console.WriteLine(total.ToString());

            Console.ReadLine();

        }
    }
}
