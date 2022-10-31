using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int Number = 0;

            StreamReader SR = new StreamReader(@"C:\Users\Public\Documents\number.txt");

            while(-1 < SR.Peek())
            {
                Number = int.Parse(SR.ReadLine());

                if (Number >= 15)
                {
                    Console.WriteLine(Number.ToString());
                }
            }

            SR.Close();

            Console.ReadLine();

        }
    }
}
