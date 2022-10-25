using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("点数を入力して、Enterキーを押してください");

            string inputPoint = Console.ReadLine();

            double point = double.Parse(inputPoint);

            string pass = string.Empty;
            if (point < 60 & point >= 0 )
            {
                pass = "不合格です";
            }
            else if(point >= 60 && point <= 100)
            {
                pass = "合格です";
            }

            Console.WriteLine(pass);

            Console.ReadLine();

        }
    }
}
