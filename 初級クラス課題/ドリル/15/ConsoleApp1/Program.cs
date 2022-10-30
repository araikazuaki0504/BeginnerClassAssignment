using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            uint Sum = 0;

            Console.WriteLine("大人の人数は何人ですか？");
            Sum += uint.Parse(Console.ReadLine()) * 1800;

            Console.WriteLine("子供の人数は何人ですか？");

            Sum += uint.Parse(Console.ReadLine()) * 900;

            Console.WriteLine("料金は\n" + Sum.ToString() + "\nになります");
            

            Console.ReadLine();

        }
    }
}
