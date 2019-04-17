using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_01_Hello_World
{
    class Program { 
        static void Main(string[] args)
        {
            Console.WriteLine("First Application");

            Console.ReadLine();

            System.Threading.Thread.Sleep(5000);//pause for 5 seconds 

            Console.WriteLine("finished writing - hit any key to exit");

            Console.WriteLine("Printing out arguments array");
            foreach(string item in args)
            {
                Console.WriteLine("Your item is -" + item);

            }
            Console.ReadLine();

        }
    }
}
