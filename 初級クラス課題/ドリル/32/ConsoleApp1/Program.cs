using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 9, j = 1;

            while(i > 0)
            {
                j = 1;

                while(j < 10)
                {
                    Console.WriteLine((i * j).ToString());
                    j++;
                }
                i--;
            }

            Console.ReadLine();

        }
    }
}
