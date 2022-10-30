using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[,] tvProgram = {{ "1", "ニュース" }, { "3", "料理番組" }, { "4", "バラエティ" },
                                   { "6", "ドラマスペシャル" }, { "8", "ドラマ" },
                                   { "10", "ニュースバラエティ" }};

            for (int i = 0; i < tvProgram.Length/2; i++)
            {
                if(int.Parse(tvProgram[i,0]) % 2 == 0)
                {
                    Console.WriteLine(tvProgram[i, 0] + "：" + tvProgram[i, 1]);
                }
            }

            Console.ReadLine();

        }
    }
}
