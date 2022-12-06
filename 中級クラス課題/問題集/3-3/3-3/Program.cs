using System;

namespace _3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 3, 5, 2, 7, 8, 3, 9, 6 };
            int[] array2 = { 12, 24, 63, 11, 29 };
            int[] array3 = { 1251, 3567, 9399, 6241 };

            Console.WriteLine("array1の合計は" + Sum(array1).ToString() + "です。");
            Console.WriteLine("array2の合計は" + Sum(array2).ToString() + "です。");
            Console.WriteLine("array3の合計は" + Sum(array3).ToString() + "です。");
        }

        static int Sum(int[] Num)
        {
            int ans = 0;

            foreach (int num in Num)
            {
                ans += num;
            }

            return ans;
        }
    }
}
