using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] points = { 59, 38, 95, 48, 55, 70, 61, 50, 49, 69 };

            for(int i = 0; i < points.Length; i++)
            {
                if(50 <=  points[i] && 70 > points[i])
                {
                    Console.WriteLine(points[i].ToString());
                }
            }

            Console.ReadLine();

        }
    }
}
