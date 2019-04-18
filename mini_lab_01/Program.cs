using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_lab_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mini Lab 1 *Create a loop that outputs the numbers 1..1 mln(or any number you want) to the screen.//

            Console.WriteLine("Loop from 1 to 1 thousand:");

            for (int i = 1; i < 1001; i++)//for 1st digit to be '1', 'i' initialized at 1, 
                                             //if less than 1000001, incrememnt by 1
            {


                // Mini Lab 2 - For every 100th number, have the program output a greeting
                if (i % 100 == 0)
                {
                    Console.WriteLine($"GOOD MORNING");//PRINT GOOD MORNING FOR EVERY 100th term 
                }                              //if modulus of 100 is 0, then number is divisible by 100
                else { Console.WriteLine(i); } //print value of i 
                    
                //Same as the one above, but for every 5th, 105th, 205th, etc number.
                //if ()

            }




        }
    }
}
