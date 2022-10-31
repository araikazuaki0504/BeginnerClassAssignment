using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] points = { 55, 72, 89, 81, 76, 64, 97, 49, 45, 74 };
            int Sum = 0;

            for(int i = 0; i < points.Length; i++)
            {
                Sum += points[i];
            }

            double Ave = (double)(Sum) / points.Length;

            Console.WriteLine("平均値は\n" + Ave.ToString() + "\nになります。");

            Console.ReadLine();

        }
    }
}
