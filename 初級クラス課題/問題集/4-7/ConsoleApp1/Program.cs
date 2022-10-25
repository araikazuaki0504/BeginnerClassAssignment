using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("苗字を入力して、Enterキーを押してください");

            string lastName = Console.ReadLine();

            Console.WriteLine("名前を入力して、Enterキーを押してください");

            string firstName = Console.ReadLine();

            string fullName = lastName + firstName;

            Console.WriteLine("あなたの名前は、" + fullName + "ですね？");

            Console.ReadLine();

        }
    }
}
