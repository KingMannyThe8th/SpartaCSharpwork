using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_25_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //A METHOD IS A FUNCTION WHICH WE CAN CALL!
            //IT ALWAYS HAS A RETURN TYPE 
            //VOID IS USED FOR SIMPLE TYPES WHERE WE'RE RETURNING NOTHING.
            //
            void DoThis()//THIS IS A DECLARATION ONLY, NO CODE IS BEING RUN
            {

                Console.WriteLine("I am doing something");
            }

            DoThis();//THIS IS A RECALL OF IT, SO NOW CODE IS BEING RUN !!!!!!!!

            void DoThis2()//THIS IS A DECLARATION ONLY, NO CODE IS BEING RUN
            {

                Console.WriteLine("I am doing something");
            }
            void DoThis3()//THIS IS A DECLARATION ONLY, NO CODE IS BEING RUN
            {

                Console.WriteLine("I am doing something");
            }

            DoThis();
            DoThis2();
            DoThis3();

            for(int i = 1; i < 4; i++)
            {

                DoThis();
            }
        }
    }
}
