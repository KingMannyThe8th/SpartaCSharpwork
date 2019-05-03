using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_50_exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ///something can go wrong here
            }
            catch (Exception e)
            {

                //process the 'exception' i.e. handle it'
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
            }

            finally
            {
                // always do this code regardless if exception or not
            }

            //divide by zero
            int x = 10, y = 0;


            try { int z = x / y; }


            //CATCH DIVIDE BY ZERO EXCEPTION DAILY 
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Error division by Zero");
                Console.WriteLine(e);
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);
                //File.WriteAllText; 

            }

            //CATCH EVERY EXCEPTION FO ALL TYPES
            catch (Exception e)
            {
                Console.WriteLine("OOPS! SNAP! Something went wrong");
                Console.WriteLine(e.Data);
                Console.WriteLine(e.Message);



            }
            finally
            {

                Console.WriteLine("Programs stil works here");

            }

            Console.WriteLine("Program still works here");





        }
    }
}