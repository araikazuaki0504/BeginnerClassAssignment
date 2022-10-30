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

            for(int i = 0; i < 34; i++)
            {
                Sum += 3 * i;
            }

            Console.WriteLine("0～100までの3の倍数の合計は\n" + Sum.ToString() + "です。");

            Console.ReadLine();

        }
    }
}
