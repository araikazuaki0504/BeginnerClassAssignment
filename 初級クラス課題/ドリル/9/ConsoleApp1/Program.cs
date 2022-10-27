using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            float Num = 0, Ans = 0;

            Console.WriteLine("数値を入力してください。");
            Num = float.Parse(Console.ReadLine());

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("数値を入力してください。");
                Ans += float.Parse(Console.ReadLine()) * Num;
            }
            
 
            Console.WriteLine("計算結果は、\n" + Ans.ToString() + "\nです。");

            Console.ReadLine();

        }
    }
}
