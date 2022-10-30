using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        private static uint sum_Age = 0;

        static uint Price(uint Age, uint Sum)
        {
            sum_Age += Age;

            if(80 <= sum_Age)
            {
                return 2000;
            }

            if (60 <= Age)
            {
                return 1200 + Sum;
            }
            else if (19 <= Age && 60 > Age)
            {
                return 1800 + Sum;
            }
            else if(13 <= Age && 18 >= Age)
            {
                return 1000 + Sum;
            }
            else if(12 >= Age)
            {
                return 700 + Sum;
            }

            return 0;
        }
        static void Main(string[] args)
        {
            uint Sum = 0;

            Console.WriteLine("一人目の年齢を入力してください。");
            Sum = Price(uint.Parse(Console.ReadLine()), Sum);

            Console.WriteLine("二人目の年齢を入力してください。");
            Sum = Price(uint.Parse(Console.ReadLine()), Sum);

            Console.WriteLine("二人分の料金は\n" + Sum.ToString() + "\nです。");

            Console.ReadLine();

        }
    }
}
