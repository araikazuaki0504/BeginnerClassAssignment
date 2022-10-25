using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           string[] color = { "赤", "青", "黄", "緑", "白"};


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(color[i].ToString());
            }

            Console.ReadLine();

        }
    }
}
