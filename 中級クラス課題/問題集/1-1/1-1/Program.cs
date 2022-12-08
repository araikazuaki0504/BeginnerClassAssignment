using System;

namespace _1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string greetingHello;
            string greetingForAlongTime;
            string name;

            greetingHello = "こんにちは";
            greetingForAlongTime = "お久しぶりですね";
            name = "IF 太郎";

            Console.WriteLine(name + "さん" + greetingHello);
            Console.WriteLine(greetingForAlongTime);

            string greetingGoodEvenig;
            string greetingHowAreYou;

            greetingGoodEvenig = "こんばんは。";
            greetingHowAreYou = "お元気ですか。";

            Console.WriteLine(name + "さん" + greetingGoodEvenig);
            Console.WriteLine(greetingHowAreYou);

            Console.ReadLine();
        }
    }
}
