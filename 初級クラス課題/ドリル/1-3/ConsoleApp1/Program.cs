using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int Sum = 0;
            StreamReader SR = new StreamReader(@"C:\Users\Public\Documents\numbers.txt.txt");

            while(-1 < SR.Peek())
            {
                Sum += int.Parse(SR.ReadLine());
            }

            SR.Close();

            Console.WriteLine("合計は、\n" + Sum.ToString() + "\nです。");

            Console.ReadLine();

        }
    }
}
