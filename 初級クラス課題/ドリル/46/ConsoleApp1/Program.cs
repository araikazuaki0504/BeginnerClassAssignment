using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            StreamWriter SW = new StreamWriter(@"C:\Users\Public\Documents\numbers.txt.txt", true, Encoding.UTF8);

            for(int i = 1; i <= 10; i++)
            {
                SW.WriteLine(i);
            }

            SW.Close();

            Console.ReadLine();

        }
    }
}
