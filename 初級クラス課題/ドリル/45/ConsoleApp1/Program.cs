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

            int inputChannel = 0, index = 0;

            Console.WriteLine("チャンネルを入力してください。(1,3,4,6,8,10)");
            inputChannel = int.Parse(Console.ReadLine());


            for (int i = 0; i < tvProgram.Length/2; i++)
            {
                if(int.Parse(tvProgram[i,0]) == inputChannel)
                {
                    index = i;
                }
            }

            Console.WriteLine("指定されたチャンネルは・・・\n" + tvProgram[index, 0] +":" + tvProgram[index, 1]);

            Console.ReadLine();

        }
    }
}
