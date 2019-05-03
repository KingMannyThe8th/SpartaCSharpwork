using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_02_fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // count to 100
            // start from 1, up to 100 and increment by 1
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i); //Prints integer, i
                if (i % 3 == 0) { Console.WriteLine("fizz"); } //Prints fizz if divisble  by 3
                if (i % 5 == 0) { Console.WriteLine("buzz"); } //prints buzz if divisble by 5 
                                                               // if (i % 15 == 0) { Console.WriteLine("fizzbuzz"); } //print fizzbuzz if divisible

                else
                { }
        
               
            }

        }
    }
}
