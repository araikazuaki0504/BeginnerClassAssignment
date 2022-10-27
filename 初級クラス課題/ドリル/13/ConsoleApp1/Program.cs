using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Height = 0;

            Console.WriteLine("身長を入力してください。");
            Height = uint.Parse(Console.ReadLine());

            if(130 <= Height)
            {
                Console.WriteLine("ジェットコースターに乗れます。");
            }
            else if(130 > Height && 120 <= Height)
            {
                Console.WriteLine("保護者同伴でジェットコースターに乗れます。");
            }
            else if(120 > Height)
            {
                Console.WriteLine("ジェットコースターに乗れません。");
            }

            Console.ReadLine();

        }
    }
}
