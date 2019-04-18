using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_26_methods2
{
    class Program
    {
        static void Main(string[] args)
        {
            //void method 
            //return int
            int ReturnNumber()
            {
                return 12;

                Console.WriteLine("12");
            }



            //return string
            string ReturnText()
            {
                return "some text";

                Console.WriteLine("some text");
            }

            ReturnNumber();
            ReturnText();

            //use output
            var output1 = ReturnNumber();
            var output2 = ReturnText();
            //print outputs
            Console.WriteLine($"Output 1 is { output1} and Output 2 is {output2}");
            Console.WriteLine($"ReturnNumber is {ReturnNumber()} & ReturnText is {ReturnText()}");

            //pass input INTO a method

            void PrintNumber(int myNumber) //pre-declared function (parameters) 
            {
                Console.WriteLine($"Your number is {myNumber}");
            }

            PrintNumber(10);
            PrintNumber(100);
            PrintNumber(1000);

            //send in data & get data back

            double Cube(int myNumber)
            {
                return Math.Pow(myNumber, 3);

            }

            Console.WriteLine($"10 Cubed =  { Cube(10)}");
            Console.WriteLine($"20 Cubed =  {Cube(20)}");
            Console.WriteLine($"30 Cubed =  {Cube(30)}");
            Console.WriteLine($"40 Cubed =  {Cube(40)}");
            Console.WriteLine($"50 Cubed = {Cube(50)}");
           

        }
    }
}
