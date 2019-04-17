using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace lab_17_datetime
{
    class Program
    {
        static void Main(string[] args)
        {
            //declare date
            //not very helpful: default date is 1 Jan 
            var d = new DateTime();

            Console.WriteLine(d);

            var e = DateTime.Today; //midnight
            var f = DateTime.Now;//right now

            Console.WriteLine(e);
            Console.WriteLine(f);

            //add calendar day/week/month
            e = e.AddDays(1);
            e = e.AddMonths(1);
            e = e.AddHours(1);

            Console.WriteLine(e);

            //CRUDE SUBTRACTING TIME 
            var start = DateTime.Now;

            int total = 0;

            for(int i = 0; i < 1000000; i++)
            {
                total += i;
            }

            var stop = DateTime.Now;

            Console.WriteLine($"Counting took {0}", (stop - start));
            Console.WriteLine($"Counting took {(stop - start).Milliseconds}");

            //STOPWATCH

            var s = new Stopwatch();

            s.Start();

            total = 0;

            for(int i = 0; i < 10000000; i++)
            {

                total += i;

            }

            s.Stop();

            Console.WriteLine(s.ElapsedTicks);
            Console.WriteLine(s.Elapsed);

        }   


    }
}
