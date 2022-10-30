using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] points = { 50, 49, 62, 59, 35, 90, 48, 51, 60, 61 };

            for(int i = 0; i < points.Length; i++)
            {
                if(50 >  points[i])
                {
                    Console.WriteLine(points[i].ToString());
                }
            }

            Console.ReadLine();

        }
    }
}
