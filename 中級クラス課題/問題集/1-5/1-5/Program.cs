using System;

namespace _1_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] numbers = { { 1,2,3,4,5},
                                 { 6,7,8,9,10},
                                 { 11,12,13,14,15},
                                 { 16,17,18,19,20} };

            for (int i = 0; i < 4; i++)
            {
                int total = 0;
                for (int j = 0; j < 5; j++)
                {
                    total += numbers[i, j];
                }

                Console.WriteLine(total.ToString());
            }
        }
    }
}
