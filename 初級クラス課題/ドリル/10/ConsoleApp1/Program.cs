using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Name = string.Empty;

            Console.WriteLine("あなたの名字を入力してください。");
            Name = Console.ReadLine();

            Console.WriteLine("あなたの名前を入力してください。");
            Name += Console.ReadLine();

            Console.WriteLine("あなたの名前は、\n" + Name + "\nですね。");

            Console.ReadLine();

        }
    }
}
