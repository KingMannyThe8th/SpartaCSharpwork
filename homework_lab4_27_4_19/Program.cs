using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab4_27_4_19
{
    class Program
    {
        static void Main(string[] args)
        {


            int i = 10;
            int e = 15;

            Add10(i);
            //with value
            Console.WriteLine(i + 10);

            //with reference
            Ref10(ref e);
            Console.WriteLine(e + 10);

            Console.WriteLine("The value after calling the method is {0}= ",   (e + 10) );
           
        }

        

        static void Add10(int n)
        {

            n *= n; 
             
        }
        //with reference
        static void Ref10(ref int b)
        {
            b *= b;
            Console.WriteLine("value inside ref method is", b);
        }

    }

    
}
