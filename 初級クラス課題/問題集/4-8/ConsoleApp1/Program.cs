using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("名前を入力して、Enterキーを押してください");

            string Name = Console.ReadLine();

            Console.WriteLine("年齢を入力して、Enterキーを押してください");

            string age = Console.ReadLine();

            Console.WriteLine("あなたの名前は、" + Name + "ですね？");
            Console.WriteLine("年齢は、" + age + "ですね。");

            Console.ReadLine();

        }
    }
}
