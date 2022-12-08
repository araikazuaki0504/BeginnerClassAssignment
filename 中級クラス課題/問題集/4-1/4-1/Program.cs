using System;
using System.IO;
using System.Collections.Generic;

namespace _4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> DogData = ReaderData(args[0]);

            foreach (string OutPutString in DogData)
            {
                Console.WriteLine(OutPutString);
            }
        }

        static List<string> ReaderData(string FilePath)
        {
            List<string> setData = new List<string>();

            StreamReader Reader = new StreamReader(FilePath);

            while (-1 < Reader.Peek())
            {
                setData.Add(Reader.ReadLine());
            }

            Reader.Close();

            return setData;
        }
    }
}
