using System;
using System.IO;
using System.Collections.Generic;

namespace _4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Data = DataReader(args[0]);
            double ans = Ave(Data);

            Console.WriteLine("平均は" + ans.ToString() + "です。");
        }

        static List<int> DataReader(string FilePath)
        {
            List<int> Data = new List<int>();
            StreamReader Reader = new StreamReader(FilePath);

            while (-1 < Reader.Peek())
            {
                string[] SetData = Reader.ReadLine().Split(" ");
                for (int i = 0; i < SetData.Length; i++)
                {
                    Data.Add(int.Parse(SetData[i]));
                }
            }

            Reader.Close();

            return Data;
        }

        static double Ave(List<int> Data)
        {
            int Sum = 0;

            for (int i = 0; i < Data.Count; i++)
            {
                Sum += Data[i];
            }

            double ans = (double)Sum / Data.Count;
            return ans;
        }
    }
}
