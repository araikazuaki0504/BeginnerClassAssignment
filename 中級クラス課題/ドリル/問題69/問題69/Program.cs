using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace ドリル初級編_問題69
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = string.Empty;

            int number = 10;
            if (number < 8)
            {
                message = "8よりちいさいです。";
            }
            else
            {
                message = "8以上です。";
            }

            Console.WriteLine(message);
        }
    }
}
