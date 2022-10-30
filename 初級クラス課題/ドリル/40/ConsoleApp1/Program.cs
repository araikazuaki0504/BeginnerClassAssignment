using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] points = { 51, 60, 61, 88, 39, 95, 59, 79, 90, 45 };

            for(int i = 0; i < points.Length; i++)
            {
                if(60 <=  points[i])
                {
                    Console.WriteLine(points[i].ToString());
                }
            }

            Console.ReadLine();

        }
    }
}
