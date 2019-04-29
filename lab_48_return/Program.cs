using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_48_return
{
    class Program
    {
        static void Main(string[] args)
        {
            string output = DoThis(10);
            Console.WriteLine(output);

        }


        static string DoThis(int x)
        {
            if (x < 10) return "Your Number is Low";
            if (x < 20) return "Your Number is Medium";
            if (x < 30) return "Your Number is High";
  
            return "Your number is off the chart"; 
        }


    }


}
