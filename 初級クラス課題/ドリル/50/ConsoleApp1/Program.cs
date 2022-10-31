using System;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            int SR_number = 0;

            string FilePath = @"C:\Users\Public\Documents\numbers.txt";
            string odd_FilePath = @"C:\Users\Public\Documents\numbers_odd.txt";

            StreamReader SR = new StreamReader(FilePath);
            StreamWriter SW = new StreamWriter(odd_FilePath, false, Encoding.UTF8);


            while(-1 < SR.Peek())
            {
                SR_number = int.Parse(SR.ReadLine());

                if (SR_number % 2 == 1)
                {
                    SW.WriteLine(SR_number);
                }
            }

            SW.Close();
            SR.Close();

            Console.ReadLine();

        }
    }
}
