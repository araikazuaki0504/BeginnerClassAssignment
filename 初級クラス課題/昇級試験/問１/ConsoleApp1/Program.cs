using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("消費税込みの金額を計算します。\n金額を入力して、Enterキーを押してください。");

            double Price = double.Parse(Console.ReadLine()) * 1.08;

            Console.WriteLine("税込み" + ((int)(Price)).ToString() + "円になります。");

            Console.ReadLine();

        }
    }
}
