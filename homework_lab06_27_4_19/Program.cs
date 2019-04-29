using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab06_27_4_19
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] array01 = new string[5];
            array01[0] = "Afternoon";
            array01[1] = "Hi";
            array01[2] = "Howdy";
            array01[3] = "Bye";
            array01[4] = "Adios";


            




            foreach (string value in array01)
            {
                Console.WriteLine(value); //shows code BEFORE change of 3rd value



            }

            
            string[] array02 = array01;//directly copies the 1st array into the 2nd array

            array01[2] = "Wilkommen"; //individual change of one variable 

            foreach (string value in array01) //shows array AFTER change in value
            {
                Console.WriteLine(value);



            }

            foreach (string value2 in array02) //shows copied array after change in Value 
            {
                Console.WriteLine(value2);


            }
        }
    }

}
