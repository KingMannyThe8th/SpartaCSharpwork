using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_20_truthtables
{
    class Program
    {
        static void Main(string[] args)
        {

            //AND

            Console.WriteLine(1&1);
            Console.WriteLine(0&0);
            Console.WriteLine(1&0);
            Console.WriteLine(0&1);

            //usually we use && or || instead because it's quicker. due to not evaluating as much as the single operator
            //OR

            Console.WriteLine(1|1); //TRUE
            Console.WriteLine(0|0); //FALSE
            Console.WriteLine(1|0); //TRUE
            Console.WriteLine(0|1); //TRUE 

            // XOR - same as OR but fails if both are high 
            Console.WriteLine(1^1); //FALSE
            Console.WriteLine(0^0); //FALSE
            Console.WriteLine(1^0); // TRUE
            Console.WriteLine(0^1); //TRUE



        }
    }
}
