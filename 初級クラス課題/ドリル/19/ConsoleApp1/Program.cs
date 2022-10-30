using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint Sum = 0, march_Num;

            Console.WriteLine("アイスクリームの数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            Sum += 150 * march_Num;
            
            Console.WriteLine("かき氷の数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            Sum += 300 * march_Num;

            Console.WriteLine("ジュースの数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            if(march_Num%12 == 0)
            {
                Sum += 90 * march_Num;
            }
            else
            {
                Sum += 100 * march_Num;
            }

            Console.WriteLine("料金は\n" + Sum.ToString() + "\nなります。");

            Console.ReadLine();

        }
    }
}
