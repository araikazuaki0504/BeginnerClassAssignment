using System;
using System.IO;
using System.Collections.Generic;

namespace _3_8
{
    class Program
    {
        static List<string> DogData = new List<string>();
        static void Main(string[] args)
        {
            string FilePath = @"C:\data\inu.txt";
            DataReader(FilePath);

            int Shiba = ShibaCounter();

            Console.WriteLine("柴犬は" + Shiba.ToString() + "匹です。");
        }

        static void DataReader(string FilePath)
        {
            StreamReader Reader = new StreamReader(FilePath);

            while (-1 < Reader.Peek())
            {
                string[] Data = Reader.ReadLine().Split(" ");
                for (int i = 0; i < Data.Length; i++)
                {
                    DogData.Add(Data[i]);
                }
            }
        }

        static int ShibaCounter()
        {
            int Shiba = 0;

            for (int i = 0; i < DogData.Count; i++)
            {
                if (DogData[i] == "柴犬")
                {
                    Shiba += 1;
                }
            }

            return Shiba;
        }
    }
}
