using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int[] points = { 83, 93, 42, 54, 64, 65, 82, 31, 98, 69 };
            int Min = int.MaxValue;

            for(int i = 0; i < points.Length; i++)
            {
                if(Min > points[i])
                {
                    Min = points[i];
                }
            }

            

            Console.WriteLine("最大値は\n" + Min.ToString() + "\nになります。");

            Console.ReadLine();

        }
    }
}
