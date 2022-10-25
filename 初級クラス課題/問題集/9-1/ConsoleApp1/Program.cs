using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "name.txt";
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            string name = sr.ReadLine();

            sr.Close();

            Console.WriteLine("私は、" + name + "です。");

            Console.ReadLine();

        }
    }
}
