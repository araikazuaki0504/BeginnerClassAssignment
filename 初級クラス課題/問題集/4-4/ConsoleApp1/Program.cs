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

            double number_1 = double.Parse(inputNumber_1);
            double number_2 = double.Parse(inputNumber_2);

            double resultDouble = number_1 * number_2;

            Console.WriteLine("実数での計算結果は、");
            Console.WriteLine(resultDouble.ToString());

            int resultInt  = (int)(number_1 * number_2);

            Console.WriteLine("整数での計算結果は、");
            Console.WriteLine(resultInt.ToString());

            Console.ReadLine();

        }
    }
}
