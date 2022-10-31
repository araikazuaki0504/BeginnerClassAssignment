using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {   
        static void Main(string[] args)
        {
            List<int> List_num = new List<int>();

            string FilePath = @"C:\Users\Public\Documents\numbers.txt";
            string odd_FilePath = @"C:\Users\Public\Documents\numbers_odd.txt";

            StreamReader SR = new StreamReader(FilePath);

            while(-1 < SR.Peek())
            {
                List_num.Add(int.Parse(SR.ReadLine()));
            }

            SR.Close();

            StreamWriter SW = new StreamWriter(odd_FilePath, false, Encoding.UTF8);

            for(int j = 0; j < List_num.Count; j++)
            {
                if(List_num[j] % 2 == 1)
                {
                    SW.WriteLine(List_num[j].ToString());
                }
            }

            SW.Close();

            Console.ReadLine();

        }
    }
}
