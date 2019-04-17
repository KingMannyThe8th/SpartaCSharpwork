using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_03_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //4 types of loops
            // for, do, do while & foreach

            //FOR LOOP EXAMPLE

            //for (int i = 0; i <10, i++) { }

            //while(condition is true){RUN SOME CODE}


            //while (counter < 20)
            //{
            //Console.WriteLine(counter);
            //counter++;//
            //}//     

            //Console.WriteLine("\n\do....while loop\n\n);
            //int counter = 10;

            //do {
            //console
            //}
            //while (condition = 20)

            //FOREACH LOOP PRACTICE

            //Console.WriteLine("Print the following Numbers:");



            //CREATE ARRAY

            //int[] numbers_array = new int[] { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };// Array of integers declared


            // foreach(int number in numbers_array)//FOR EACH "NUMBER" IN THE NUMBERS_ARRAY.....
            //{

            //Console.WriteLine(number); //WRITE THE NUMBER DOWN 

            //}

            //FOREACH EXAMPLE 2


            Console.WriteLine("Print the following New Numbers");//

            int[] new_array = new int[] { 0, 2, 4, 6, 8, 10 }; //declared the new array 

            foreach (int newnumber in new_array) {  //FOR EACH "NEW NUMBER in NEW_ARRAY....

                Console.WriteLine(newnumber); //WRITE DOWN THE NEW NUMBER 

            }
    
                 
           
        }
    }
}
