using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_09_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //increment operators
            int x = 100; // y= x then x++ i.e incrment x by 1
            int y = x++;// so y=x=100 then x increments to 101 
            //think answer is : 101, 102
            //actual answer is 101, 100

            Console.WriteLine($"x is {x} and y is {y}");

            int a = 100;
            int b = ++a;
            //BOTH 101 AS EXPECTED 
            //FIRSTLY INCREMENT a to 101 and then b = a = 101 after

            Console.WriteLine($"a is {a} and b is {b}");

            //GENERAL RULE = JUST ONLY USE ++; ON IT'S OWN SEPERATE LINE!!!

            //BEST WAY 

            //int r = 1000;

            //r++// up to 1001;
            //int s = r;
            //x-- //decrement operator 

             // NOT OPERATOR

            bool isExcellent = true;
            bool isRubbish = false;

            Console.WriteLine("isExcellent")##;  //TRUE
            Console.WriteLine("!isExcellent"); //FALSE
        }
    }
}
