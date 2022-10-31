using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int Sum = 0, person_Num = 0, discount_Num = 0;

            Console.WriteLine("大人の人数は何人ですか？");
            person_Num = int.Parse(Console.ReadLine());
            discount_Num = person_Num / 2;
            Sum += 1500 * person_Num;

            Console.WriteLine("子供の人数は何人ですか？");
            person_Num = int.Parse(Console.ReadLine());

            person_Num -= discount_Num;

            if(person_Num > 0)
            {
                Sum += 750 * person_Num;
            }


            Console.WriteLine("料金は\n" + Sum.ToString() + "\nなります。");

            Console.ReadLine();

        }
    }
}
