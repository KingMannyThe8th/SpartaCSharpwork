using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace practice_hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch mytimer = new Stopwatch();

            int[] myarray = new int[10001];

            DateTime mydate = new DateTime(); 



            mytimer.Start(); 

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(i);
            }

            mytimer.Stop();

            Console.WriteLine($"Time Elapsed for FOR-LOOP is {mytimer.ElapsedMilliseconds}secs");


            char h = 'H';
            int c = h ;

            Console.WriteLine($"the ascii value of H is {c}");


            Console.WriteLine(DateTime.Now); //today's date 

            mydate.ToString("2019", "08", "07", "9");

        }
    }
}
