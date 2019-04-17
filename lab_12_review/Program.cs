using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_12_review
{
    class Program
    {
        static void Main(string[] args)
        {
            //DATA TYPES
            // INT
            //SIGNED 
            // short x; //16bits 
            // Int16 xx;// same thing

            //long l; - 64 bits 
            //Int64 xxx - same

            // int i, 32 bits 
            //Int32 xx, same thing 

            //unsigned positive only

            //ushort u1; 

            // danger : integer division TRUNCATES

            //Console.WriteLine(12/6); //2/4
            //Console.WriteLine(12/6); //2/4




            //Console.WriteLine(12.0/5); //2.4
            //Console.WriteLine(12/5.0); //2.4




            // decimals : default is DOUBLE and has 64 bit precision 

            //var num1 = 1.23456778901234567890// DOUBLE FLOAT - 64 BITS
            //var num1 = 1.23456778901234567890F;// THE "F" on the end makes it become a SINGLE FLOAT, thereby reducing its precision 
            //32 bit precision

            //float 32 bit
            // double 64 bit
            // decimal 128 bits long (precise for memory)


            //division

            //DO WHILE
            int number = 0;
            do
            {
                Console.WriteLine(number);
                number++;

            }
            while (number < 5);



            // WHILE
            int number2 = 0;

            while(number2 < 5)
            {
                Console.WriteLine(number2);
                number2++;
            }


            //FOR - count to 5


            int i;

            for (i= 0; i < 6; i++)
            {

                Console.WriteLine(i);
            }







            //FOR EACH
            string[] myArray = new string[]{ "one", "two", "three", "four" };

            foreach(string item in myArray)
            {

                Console.WriteLine(item);
            }
            //NAMESPACE: SEPERATE CODE 

            // main() always run first
            //.sln SOLUTION CONTAINER FOR MULTIPLE PROJECTS
            // .csproj PROJECT ==> GNERATES EXE OR DLL

            //OPERATOR

            //INCREMENT ++ AND DECREMENT-- 

            //RULE: PUT ON ++ SEPERATE LINE

            //BOOLEAN 
            var isOff = true;
            var isOn = false; 

        }
    }
}
