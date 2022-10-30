using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0, Sum = 0;

            for (i = 1; i < 11; i ++)
            {
                Sum = 0;
                for(int j = i; j < 11; j++)
                {
                    Sum += j;
                }

                Console.WriteLine(Sum.ToString());
            }

            Console.ReadLine();

        }
    }
}
