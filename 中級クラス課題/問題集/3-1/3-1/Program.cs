using System;

namespace _3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Person = { "A", "B" };
            string[] Greeting = { "こんにちは", "こんばんは" };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    OutPutStrings(Person[j], Greeting[i]);
                }
            }

        }

        static void OutPutStrings(string person, string greeting)
        {
            Console.WriteLine(person + "さん");
            Console.WriteLine(greeting);
        }
    }
}
