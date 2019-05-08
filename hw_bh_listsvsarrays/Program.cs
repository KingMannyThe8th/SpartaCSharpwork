using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace hw_bh_listsvsarrays
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] myarray = new int[1000001];
            Stopwatch mytimer = new Stopwatch();
            List<int> mylist = new List<int>(1000001); 
            mytimer.Start();

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(i);
            }

            mytimer.Stop();

            Console.WriteLine($"The time elasped for the FOR-LOOP is: {mytimer.ElapsedMilliseconds} secs");

            mytimer.Start();
            for (int i = 0; i < mylist.Length; i++)
            {

            }

            mytimer.Stop();

            Console.WriteLine($"Time Elapsed for FOR-EACH LOOP is {mytimer.ElapsedMilliseconds} secs");

        }
    }
}
