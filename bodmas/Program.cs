using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bodmas
{
    class Program
    {
        private static int x;

        static void Main(string[] args)
        {// 
         //BODMAS/BIDMAS
         //*Take a number and add 15 to that number, multiply the total by 3 and divide by 4, 
         //then multiply the result by the square of that number. 
         //Round till 4 decimals, don't lose any fractions. 
         //Divide the year you born with by the month you born in, then multiply by the cube of the day you're born on.
         //Note: when you upload this to GitHub, you might, for privacy reasons, want to change the date to a random date.
         //If you drive somewhere with a certain speed and it takes you 1,5 hour to reach your destination, 
         //how long will it take if you increase your speed by 15 %? 75 %?

            //var x; //  

            Console.WriteLine("Insert number:", x);
            Console.ReadLine();

            double first_answer = ((x + 15) * 3)/ 4 ;

            double second_answer = Math.Sqrt(first_answer);

            double final_answer = first_answer * second_answer;

            Console.WriteLine("The answer is ", Math.Round(final_answer,4)); 
             
        } 
    }
}
