using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_bidmas
{
    class Program
    {
        static void Main(string[] args)
        {
           

            var FiveSquared = Math.Pow(5, 2);
            var ThirteenCubed = Math.Pow(13, 3);

            Console.WriteLine(FiveSquared * ThirteenCubed - (7 / 4.0));


            Console.WriteLine(Math.Sqrt(100));

            //modulus
            Console.WriteLine(100 /8); //12 - WRONG - INTEGERS DIVIDED BY INTEGERS GIVE INTEGERS
            Console.WriteLine(100 / 8.0);//12.5 - CORRECT - INTEGERS DIVIDED BY FLOATS GIVE FLOATS
            Console.WriteLine(100 % 8);// REMAINDER 4 - MODULUS - REMAINDEDR

        }
    }
}
