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

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("数値を入力してください。");
                Sum += int.Parse(Console.ReadLine());
                Sum *= -1;
            }
            
 
            Console.WriteLine("引き算すると、\n" + Sum.ToString());

            Console.ReadLine();

        }
    }
}
