using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            string FilePath = @"C:\Users\Public\Documents\";

            Console.WriteLine("ファイル名を入力してください。");
            String inputFileName = Console.ReadLine();

            FilePath += inputFileName;

            Random Rand = new Random();
            StreamWriter SW = new StreamWriter(FilePath, false, Encoding.UTF8);

            for (int i = 0; i < 10; i++)
            {
                SW.WriteLine(Rand.Next(0, 99));
            }

            SW.Close();

            Console.WriteLine("ファイルを出力しました。");

            Console.ReadLine();

        }
    }
}
