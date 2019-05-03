using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_08_loops_recap
{
    class Program
    {
        static void Main(string[] args)
        {
            //FOR

            /////for(int i = 0; i < 10; i++)
            // {
            // Console.WriteLine($"Your number is {i}");
            // Console.WriteLine($"Number squared is {i*i}"); 
            //

            //}//



            //WHILE

            int counter = 0;

            while (counter < 10)
            {
                Console.WriteLine($"While loop: number is {counter}"); //Place dollar sign so variable can show in print
                counter++;


            }


            //DO....WHILE
            counter = 0; //reset counter 
            do
            {
                Console.WriteLine($"Do...while: number is {counter} ");
                counter++;


            }
            while (counter < 10);


            //FOREACH


            //ARRAYS 
            // FIRST ITEM HAS INDEX 0


            int[] myIntegerArray = new int[10];

            myIntegerArray[0] = 100;
            myIntegerArray[1] = 101;
            myIntegerArray[2] = 102;

            // last item: index = size-1 IE 10-1 = [9]
            myIntegerArray[9] = 999;

            //foreach: count over item in array

            foreach (int item in myIntegerArray)
            {

                Console.WriteLine($"Item in Array is {item}");
            }


            string[] myArray = new string[3];

           string[] myArray2 = new string[]{"One", "Two", "Three"}; //FILL IN ARRAY AT THE SAME TIME -
                                                                    //THIS IS A STRING LITERAL (NOT A GOOD PRACTICE)

            //FILL ARRAY

            myArray[0] = "One";
            myArray[1] = "Two";
            myArray[2] = "Three";

            foreach(string item in myArray)
            {
                Console.WriteLine(item);
            }
            foreach(string item in myArray2)
            {
                Console.WriteLine(item);
            }
           //NOTE CAN USE FOR 0- START AT 0 AND COUNT TO THE ARRAY LENGTH - 1

            for(int i=0; i < myArray2.Length; i++)
            {

                Console.WriteLine($"Using for loop over array - {myArray2[i]}");
            }

            //10 MINUTE LAB: BUILD FOR, WHILE LOOPS TO COUNT TO 1000
            //BONUS: FILL ARRAY WITH 1000 NUMBERS AND PRINT THEM


            for(int j=0; j <1000 ; j++)
            {
                Console.WriteLine($" for loop to 1000 - {j}");


            }



            ///WHILE LOOP COUNTING TO 1000
            counter = 0;// INITIALIZE COUNTER AT 0

          while(counter < 1000)//WHILE THE COUNTER IS LESS THAN 1000
                {
                    Console.WriteLine($"while loop to 1000 {counter}"); //PRINT THE NUMBER 
                    counter++;  //THEN INCREMENT BY 1
                //LOOP STOPS WHEN COUNTER GETS INCREMENTED TO 1000, AS THE CONDITION FOR THE WHILE LOOP WON'T BE TRUE ANYMORE
                }
          //BONUS - FILL ARRAY WITH 1000 NUMBERS

            //"VAR" JUST MEANS "ANY VARIABLE TYPE" - LET THE COMPUTWER DECIDE
            // (ALREADY SSTATED TYPE ON RHS OF EQUATION, E.G. "new int")

            var myLargeArray = new int[1000];

            for (int i = 0; i < myLargeArray.Length; i++)
            {



            }
          
        }


    }
}
