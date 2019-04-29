using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_21_review
{
    class Program
    {
        //main METHOD
        static void Main(string[] args)
        {
            //REVIEW OF DAY 2
            //TRUTH TABLE 
            //AND, OR, XOR
            //AND
            Console.WriteLine(1&1); //true or 1 - 1 & is slower than && as both sides are checked in & 

            //OR
            Console.WriteLine(false | true); //true

            //xor
            Console.WriteLine(true^true); //false#cw        
            Console.WriteLine(true^false); //true


            //CAST 
            int i = 7;
            double d = i; //implicit cast from 7 (int) to double ==> safe cast !! No extra code

            double dd = 1.99;

            int j = (int)dd; // explicit - lose 0.99

            Console.WriteLine(Math.Round(dd)); //round up
            Console.WriteLine(Math.Floor(dd)); //round down
            Console.WriteLine(Math.Ceiling(dd));// round all the way up

            Console.WriteLine((int)'j'); //casting a char to an int

            //Box

            object o = i; //boxing integer inside object

            //unbox 
            int jjj = (int)o;

            string x = null;
            int? num1 = null;
            int num2 = 0;

            byte = 255; //highest
            byte bb = 0;//lowest
            byte bbb = 0b10101010;

            char c = 'a';
            // string is array of chars
            string s = "hello";  //NOTE: SINGLE QUOTES ARE ONLY FOR CHAR, NOT STRING

         //STRINGS AS AN ARRAY 

            string myString = "Some data";
            Console.WriteLine(myString.Length);
            //first char 
            Console.WriteLine(myString[0]);
            //2nd char
            Console.WriteLine(myString[1]);
            //..last char 
            Console.WriteLine(myString[myString.Length-1]);// number of characters is 9, 
                                                           //so 9 -1 = 8
                                                           //equation = 9 - no.

            //wpf form
            var d01 = new DateTime();
            var d01 = new DateTime.now();
            var d01 = new DateTime.Today();

            var s01 = new System.Diagnostics.Stopwatch();
            s01.Start;
            s01.Stop;





            Method01(); //NO INPUT, NO OUTPUT 
            Method02(1);//PASS AN INTEGER IN TO KEEP IT CORRECT
            Method03(5);

            var outp






        }

        //OTHER METHODS
        static void Method01() { }

        static void Method02(int x) { }
        
        static int Method03(int x) { return x * x; }


    }
}
