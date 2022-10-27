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

            if(19 <= Age)
            {
                Console.WriteLine("料金は\n\\1000\nです。");
            }
            else if(19 > Age && 13 <= Age)
            {
                Console.WriteLine("料金は\n\\500\nです。");
            }
            else if(13 > Age)
            {
                Console.WriteLine("料金は\n\\250\nです。");
            }

            Console.ReadLine();

        }
    }
}
