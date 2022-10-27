using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("今日の天気を入力してください。");
            string inputWX = Console.ReadLine();

            Console.WriteLine("今日の天気は、\n" + inputWX+ "\nなんですね。");


            Console.ReadLine();

        }
    }
}
