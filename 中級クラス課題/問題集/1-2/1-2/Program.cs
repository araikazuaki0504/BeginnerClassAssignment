using System;

namespace _1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p;
            string m;
            int a;

            a = int.Parse(Console.ReadLine());

            if (a <= 15)
            {
                p = 1800;
            }
            else
            {
                p = 2300;
            }

            m = "入場料は" + p.ToString() + "円です";

            Console.ReadLine();
        }
    }
}
