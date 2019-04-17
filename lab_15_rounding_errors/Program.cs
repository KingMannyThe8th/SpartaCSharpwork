using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_15_rounding_errors
{
    class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            for (int = 1; int <= 8192; int++)
            {

                total += 0.7;
            }

            Console.WriteLine(total);

            //after 8000 loops, 9 decimal places is enough for us to lose accuracy


            decimal total2 0;
            for (int i =1; i <= 8192; i++)
            {
                total2 += 07.M;//m for decimal
            }
            Console.WriteLine(total2);

        }
    }
}
