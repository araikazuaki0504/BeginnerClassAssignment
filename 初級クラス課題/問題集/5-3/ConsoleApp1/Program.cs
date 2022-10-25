using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("注文したいメニューを入力して、Enterキーを押してください");
            Console.WriteLine("メニューは以下の通りです");
            Console.WriteLine("ラーメン、チャーハン、餃子");

            string order = Console.ReadLine();

            if(order == "ラーメン")
            {
                Console.WriteLine("値段は600円になります。");
            }
            else if (order == "チャーハン")
            {
                Console.WriteLine("値段は650円になります。");
            }
            else if(order == "餃子")
            {
                Console.WriteLine("値段は190円になります。");
            }
            else
            {
                Console.WriteLine("ラーメンかチャーハンか餃子を入力してください。");
            }

            Console.ReadLine();

        }
    }
}
