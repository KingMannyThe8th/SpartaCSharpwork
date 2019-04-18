using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mini_lab_01_loopCountdown
{
    class Program
    {
        static void Main(string[] args)
        {

            int optiona = 1;
            int optionb = 2;
            int optionc = 3;
            int optiond = 4;


            Console.WriteLine("Countdown from 1 million:");
            for(int j = 1000000; j > 0; j--)
            {
               

                if(j % 100 == 0)
                {
                    Console.WriteLine("Good Morning");
                }
                else if(j % 205 == 0)
                {
                    Console.WriteLine("Good Afternoon");     
                }

                else if(j % 105 == 0)
                {
                    Console.WriteLine("Good Evening");
                }

                else if(j % 5 == 0)
                {
                    Console.WriteLine("Good Night");
                }
                else
                {
                    Console.WriteLine(j);
                }    
            }
        }
    }
}
