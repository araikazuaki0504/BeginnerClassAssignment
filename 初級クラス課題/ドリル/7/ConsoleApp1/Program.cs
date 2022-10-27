using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 1;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("数値を入力してください。");
                times *= int.Parse(Console.ReadLine());
            }
            
 
            Console.WriteLine("合計は、\n" + times.ToString());

            Console.ReadLine();

        }
    }
}
