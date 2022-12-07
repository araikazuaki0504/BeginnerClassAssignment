using System;
using System.IO;
using System.Collections.Generic;

namespace _3_5
{
    class Program
    {
        static private List<int> Data = new List<int>();
        
        static void Main(string[] args)
        {
            string FileName = @"C:\data\figureRow.txt";
            ReadData(FileName);
            int ans = SumList();

            Console.WriteLine("合計は、" + ans.ToString() + "です"); 

        }

        static void ReadData(string FilePath)
        {
            StreamReader Reader = new StreamReader(FilePath);
            
            while (-1 < Reader.Peek())
            {
                string[] buff = Reader.ReadLine().Split(" ");
                foreach (string data in buff)
                {
                    Data.Add(int.Parse(data));
                }
            }

            Reader.Close();
        }

        static int SumList()
        {
            int ans = 0;
            foreach (int num in Data)
            {
                ans += num;
            }

            return ans;
        }
    }
}
