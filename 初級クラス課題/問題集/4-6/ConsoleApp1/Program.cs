using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("整数を入力して、Enterキーを押してください");

            string inputNumber_1 = Console.ReadLine();


            int number_1 = int.Parse(inputNumber_1);

            number_1 += 10 ;

            Console.WriteLine(number_1.ToString());

            Console.ReadLine();

        }
    }
}
