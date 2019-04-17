using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_19_casting
{
    class Program
    {
        static void Main(string[] args)
        {

            //safe casting

            int i = 10;
            double d = i;

            //explicit casting
            double dd = 10.79;
            int ii = (int)dd; //the "(int) means you are sure you want to lose that data (decimal) here (truncation)
            Console.WriteLine(ii);

            Console.WriteLine(Math.Round(dd)); //rounds the values up or down depending on which integer is closer
            Console.WriteLine(Math.Floor(dd));// rounds down no matter what
            Console.WriteLine(Math.Ceiling(dd));//rounds up no matter what

            // boxing 

            int iii = 100;
            object ooo = iii;

            //unbox

            int jjj = (int)ooo; 

        }
    }
}
