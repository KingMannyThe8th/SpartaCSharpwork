using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_char_01
{
    class Program
    {
        static void Main(string[] args)
        {

            //Char - Output character 'h' and its corresponding ASCII number(convert the character to an integer)

            char h = 'h';
            int ascii = h;
            string s1 = "SpartaGlobal";



            Console.WriteLine("The Ascii value of  " + h + " is " + ascii);

            // String   Get the user to type in a message as an input string.Print out each letter of this string in turn using foreach (char c in myString) ...


            foreach (char letter in s1)
            {
                Console.WriteLine(letter); 
            }


            // DateTime  - Create today's date then go back 100 years, and then also add 10 seconds and print out the date

            DateTime dateTime = new DateTime(2019, 5, 5, 16, 14, 10);

            DateTime datetime = DateTime.Now;

            

//          Console.WriteLine(dateTime);
//          Console.WriteLine(AddDays(dateTime - 100));
            Console.ReadKey();

            //dDays(){

             // dateTime - 100; 

           //

            //ADD 100 YEARS


            dateTime.ToString("dd MMMM, yyyy");


            Stopwatch timer = new Stopwatch();

            timer.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i); 
            }
            
            timer.Stop();


            Console.WriteLine($"Time elapsed: { timer.ElapsedMilliseconds} ms");



        /// int[] number = new int[] { 1, 2, 3 };

       //   for (int i = 0; i < number.Length; i++)
       //   {
       //       Console.WriteLine(i); 
       //   }


     //     foreach (var newnumber in number)
      //    {
      //        Console.WriteLine(newnumber);
       //   }

       //   int i;

      //    while (i = 0)
      //    {
        //      Console.WriteLine(number + 10);
       //   }


            for (int j= 1; j < 1000001; j++)
            {
                Console.WriteLine(j);
            }


            //  Put 5 numbers into an array, then into a queue, list, stack, arraylist, dictionary and hashset. 
            // Check out the code for arraylist and hashset online. //

            //each time you move a number add one.  Return the final total of the numbers in the hashset.  

    //      int[] array = new int[5];
   //       Queue[] queue01 = new Queue[5];

   //       foreach (var item in array)
   //       {
    //          queue01.Enqueue(item);
   //       }
            

            


        }

        private static bool AddDays(object p)
        {
            throw new NotImplementedException();
        }

        private static bool SubtractDays(DateTime dateTime)
        {
            throw new NotImplementedException();
        }
    }
}
