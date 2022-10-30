using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] points = { 35, 100, 69, 84, 91, 49, 54, 74, 55, 72 };
            int Max = int.MinValue;

            for(int i = 0; i < points.Length; i++)
            {
                if(Max < points[i])
                {
                    Max = points[i];
                }
            }

            

            Console.WriteLine("最大値は\n" + Max.ToString() + "\nになります。");

            Console.ReadLine();

        }
    }
}
