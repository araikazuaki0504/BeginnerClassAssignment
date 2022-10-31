using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Public\Documents\numbers2.txt";

            Random Rand = new Random();
            StreamWriter SW = new StreamWriter(FilePath, false, Encoding.UTF8);

            for (int i = 0; i < 10; i++)
            {
                SW.WriteLine(Rand.Next(0, 99).ToString());
            }

            SW.Close();

            Console.ReadLine();

        }
    }
}
