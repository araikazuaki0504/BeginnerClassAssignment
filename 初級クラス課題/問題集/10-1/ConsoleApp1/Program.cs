using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Write_Name.txt";
            StreamWriter sw = new StreamWriter(filePath, false,  Encoding.UTF8);

            sw.WriteLine("新井和明");

            sw.Close();

            Console.WriteLine("ファイルを出力しました。");
            Console.ReadLine();

        }
    }
}
