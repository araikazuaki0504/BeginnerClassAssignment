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
            char alphabet = 'z';

            while(i < 26)
            {
                Console.Write(alphabet);
                alphabet--;
                i++;
            }

            Console.ReadLine();

        }
    }
}
