using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace hw_bh_stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();

            stopwatch.Start();

            for (int i = 0; i < 1000001; i++)
            {
                Console.WriteLine(i);
            }

            stopwatch.Stop();

            Console.WriteLine($"Time elapsed is : {stopwatch.ElapsedMilliseconds} ms");
            



        }
    }
}
