using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力して、Enterキーを押してください");

            string inputNumber_1 = Console.ReadLine();

            Console.WriteLine("整数を入力して、Enterキーを押してください");

            string inputNumber_2 = Console.ReadLine();

            int number_1 = int.Parse(inputNumber_1);
            int number_2 = int.Parse(inputNumber_2);

            int result = number_1 + number_2;

            Console.WriteLine("計算結果は、");
            Console.WriteLine(result.ToString());

            Console.ReadLine();

        }
    }
}
