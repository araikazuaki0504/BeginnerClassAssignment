using System;

namespace _1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;

            age = int.Parse(Console.ReadLine());
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
