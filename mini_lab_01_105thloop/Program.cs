using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_lab_01_105thloop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loop from 1 to 1 thousand:");

            for (int i = 1; i < 1001; i++)//for 1st digit to be '1', 'i' initialized at 1, 
                                          //if less than 1000001, incrememnt by 1
            {


                // Mini Lab 2 - For every 105th number, have the program output a greeting
                if (i % 105 == 0)
                {
                    Console.WriteLine($"GOOD MORNING");//PRINT GOOD MORNING FOR EVERY 100th term 
                }                              //if modulus of 105 is 0, then number is divisible by 100
                else { Console.WriteLine(i); } //print value of i 

                //Same as the one above, but for every 5th, 105th, 205th, etc number.
                //if ()

            }
        }
    }
}
