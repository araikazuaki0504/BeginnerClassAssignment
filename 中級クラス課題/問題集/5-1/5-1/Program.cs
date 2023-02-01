using System;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;
            Console.WriteLine("年齢を入力してください。");

            while (true)
            {
                string inputData = Console.ReadLine();

                if (int.TryParse(inputData, out age))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("数値を入力してください");
                }
            }

            if (13 <= age)
            {
                if (16 <= age)
                {
                    Console.WriteLine("原動機付自転車の免許を取得できます。");
                }
                else
                {
                    Console.WriteLine("原動機付自転車の免許を取得できません。");
                }

                Console.WriteLine("++++");
                if (18 <= age)
                {
                    Console.WriteLine("自転車の免許を取得できます。");
                }
                else
                {
                    Console.WriteLine("自転車の免許を取得できません。");
                }
            }
            Console.ReadLine();
        }
    }
}
