using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] Number = { 1, 2, 3, 4, 5 };

           int i = 0;
           while ( i < 5)
            {
                Console.WriteLine(Number[i].ToString());
                i++;
            }

            Console.ReadLine();

        }
    }
}
