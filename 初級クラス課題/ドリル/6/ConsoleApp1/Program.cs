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
            }
            
 
            Console.WriteLine("掛け算すると、\n" + Sum.ToString());


            Console.ReadLine();

        }
    }
}
