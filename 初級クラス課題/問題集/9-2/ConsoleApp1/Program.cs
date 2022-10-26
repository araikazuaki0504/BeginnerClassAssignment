using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            bool Flag = true;
            string filePath = "recept.txt";
            StreamReader sr = new StreamReader(filePath, Encoding.UTF8);

            while (sr.Peek() > -1)
            {
                    int price =int.Parse(sr.ReadLine());
                    Console.WriteLine(price.ToString() + "円");
                    sum += price;
          
             }

            Console.WriteLine("合計" + sum + "円");

            sr.Close();

            Console.ReadLine();

        }
    }
}
