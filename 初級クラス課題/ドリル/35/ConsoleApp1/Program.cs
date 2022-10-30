using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 0;

            for(i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j ++)
                {
                    Console.Write('*');
                }

                Console.Write("\n");
            }

            Console.ReadLine();

        }
    }
}
