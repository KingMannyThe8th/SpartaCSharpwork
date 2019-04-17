using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_101_basic_coding
{
    class Program
    {
        static void Main(string[] args)
        {
            
              //# Operator Labs

//### 1. BODMAS



     //Write a method which takes a double as an input, squares it, adds 101, divides by 10 then subtracts 4.  
       // Return a double rounded to 3 decimal places.
             
             double input; // sets input as double

            
             
            Console.WriteLine("type in double...."); //prompts user to type in double
                var userInput = Console.ReadLine(); //the value is stored
            Console.WriteLine("You entered" , userInput);//shows stored value
            input = double.Parse(userInput);
            var answer = ((input * input) + 101)/10 - 4 ;
            //math.pow(input,2) - 
            
           double x = Math.Round(answer, 3);      // round to 3 decimal places

            Console.WriteLine("Your answer is  " + x );


            //return 

        }
    }
}

