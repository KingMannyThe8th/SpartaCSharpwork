using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_34_OptionalParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            DoThis(10, "hi", true);
            DoThis(10, "hi");
            
            

            DoThat(d: 7, c: 6, a: 10);
        }

         static void DoThis(int x, string y, bool z = false)
        {


        }

        static void DoThat(int a, int b = 5, int c = 6, int d = 7)
            
            {

        }

    }
}
