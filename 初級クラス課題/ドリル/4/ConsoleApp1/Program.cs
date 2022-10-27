using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("あなたの年齢を入力してください。");
            string inputAge = Console.ReadLine();

            Console.WriteLine("あなたは、\n" + inputAge + "\n歳ですね。");


            Console.ReadLine();

        }
    }
}
