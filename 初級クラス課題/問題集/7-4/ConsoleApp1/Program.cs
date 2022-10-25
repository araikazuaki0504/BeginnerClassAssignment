using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] color = { "赤", "青", "黄", "緑", "白"};

            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(color[i].ToString());
                i++;
            }
            Console.ReadLine();

        }
    }
}
