using System;

namespace _3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("5の階乗 = " + Fact(5).ToString());
            Console.WriteLine("10の階乗 = " + Fact(10).ToString());
            Console.WriteLine("20の階乗 = " + Fact(20).ToString());
        }

        static long Fact(long PreviousNum)
        {
            if (PreviousNum == 0)
            {
                return 1;
            }
            else
            {
                return Fact(PreviousNum - 1) * PreviousNum;
            }
        }
    }
}
