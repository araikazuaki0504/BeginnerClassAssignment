using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            uint price_Sum = 0, march_Num, march_Sum = 0;

            Console.WriteLine("アイスクリームの数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            march_Sum += march_Num;
            price_Sum += 150 * march_Num;
            
            Console.WriteLine("かき氷の数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            march_Sum += march_Num;
            price_Sum += 300 * march_Num;

            Console.WriteLine("ジュースの数を入力してください。");
            march_Num = uint.Parse(Console.ReadLine());
            march_Sum += march_Num;
            price_Sum += 100 * march_Num;

            if(march_Sum%10 == 0)
            {
                price_Sum = (uint)(price_Sum * 0.8);
            }

            Console.WriteLine("料金は\n" + price_Sum.ToString() + "\nなります。");

            Console.ReadLine();

        }
    }
}
