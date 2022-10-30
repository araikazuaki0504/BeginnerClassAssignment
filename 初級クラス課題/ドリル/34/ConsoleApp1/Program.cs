using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 10, j = 0, Sum = 0;

            while(i > 0)
            {
                j = i;
                Sum = 0;
                while(j < 11)
                {
                    Sum += j;
                    j++;
                }
                Console.WriteLine(Sum.ToString());
                i--;
            }

            Console.ReadLine();

        }
    }
}
