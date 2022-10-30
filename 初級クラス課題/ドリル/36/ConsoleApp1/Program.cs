using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int[] points = { 65, 55, 78, 90, 85, 76, 80, 95, 50, 45 };
            int Sum = 0;

            for(int i = 0; i < points.Length; i++)
            {
                Sum += points[i];
            }

            Console.WriteLine("合計値は\n" + Sum.ToString() + "\nになります。");

            Console.ReadLine();

        }
    }
}
