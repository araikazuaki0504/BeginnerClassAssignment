using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[,] tvProgram = {{ "NHK", "ニュース" }, { "NHK教育", "料理番組" },
                                   { "日本テレビ", "バラエティ" }, { "TBS", "ドラマスペシャル" },
                                   { "フジテレビ", "ドラマ" }, { "テレビ朝日", "ニュースバラエティ" }};

            for (int i = 0; i < tvProgram.GetLength(0); i++)
            {
                Console.WriteLine(tvProgram[i, 0] + "：" + tvProgram[i, 1]);
            }

            Console.ReadLine();

        }
    }
}
