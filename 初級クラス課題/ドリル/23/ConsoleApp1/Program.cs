using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int i = 1;

            while(i < 10)
            {
                Console.WriteLine((i * 3).ToString());
                i++;
            }

            Console.ReadLine();

        }
    }
}
