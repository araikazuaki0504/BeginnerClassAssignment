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

            if(18 <= Age)
            {
                Console.WriteLine("乗用車の免許が取得できます。");
            }
            else if(18 > Age)
            {
                Console.WriteLine("乗用車の免許が取得できません。");
            }

            Console.ReadLine();

        }
    }
}
