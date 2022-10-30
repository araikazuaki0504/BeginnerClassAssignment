using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            char alphabet = 'A';

            for(int i = 0; i < 26; i++)
            {
                Console.Write(alphabet);
                alphabet++;
            }

            Console.ReadLine();

        }
    }
}
