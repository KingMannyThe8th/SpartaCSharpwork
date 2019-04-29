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


            string[] array02 = array01;


            foreach (string value in array01)
            {
                Console.WriteLine(value);



            }

            foreach(string value2 in array02)
            {
                Console.WriteLine(value2);
            }
            
        }
    }

}
