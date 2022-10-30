using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Sum = 0, i = 0;

            while(i < 26)
            {
                Sum += 4 * i;
                i++;
            }

            Console.WriteLine("0～100までの3の倍数の合計は\n" + Sum.ToString() + "です。");

            Console.ReadLine();

        }
    }
}
