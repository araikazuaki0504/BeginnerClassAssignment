using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 100, 200, 300, 400, 500 };

            string filePath = "Write_Number.txt";
            StreamWriter sw = new StreamWriter(filePath, false,  Encoding.UTF8);

            foreach(int num in numbers)
            {
                sw.WriteLine(num.ToString());
            }

            sw.Close();

            Console.WriteLine("ファイルを出力しました。");
            Console.ReadLine();

        }
    }
}
