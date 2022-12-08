using System;

namespace _5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = Input();

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

        static int Input()
        {
            int Num = 0;
            string inputData = Console.ReadLine();

            if (int.TryParse(inputData, out Num))
            {
                return Num;
            }
            else
            {
                Console.WriteLine("数値を入力してください");
                Num = Input();
                return Num;
            }

        }
    }
}
