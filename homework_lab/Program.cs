using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //count to 1000

            //int counter;
            Console.WriteLine($"Count up: ");

            for(int i = 1; i < 1001; i++)
            {
                

                if (i % 100 == 0)
                {
                    Console.WriteLine("I'm a SNAIL");
                }
                else { Console.WriteLine(i); }
                    
                
            }
            //now 

            Console.WriteLine($"\nCount down: "); //Added newline to text to make countdown clearer 

            for (int j = 1000; j > 0; j--) //initialise j at 1000
            {                              // 

                
                if(j % 100 == 0)
                {
                    Console.WriteLine($"I'm a SNAIL");
                }
                else { Console.WriteLine(j); }

            }


        }
    }
}
