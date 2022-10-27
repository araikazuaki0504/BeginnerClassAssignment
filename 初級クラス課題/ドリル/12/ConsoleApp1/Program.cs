using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Age = 0;

            Console.WriteLine("年齢を入力してください。");
            Age = uint.Parse(Console.ReadLine());

            if(25 <= Age)
            {
                Console.WriteLine("衆議院議員の被選挙権があります。");
            }
            else if(25 > Age)
            {
                Console.WriteLine("衆議院議員の被選挙権がありません。");
            }

            Console.ReadLine();

        }
    }
}
