using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_bh_loops
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] myarray = new int[1001];

            for (int i = 0; i < myarray.Length; i++)
            {
                Console.WriteLine(i);  
            }


            foreach (var item in myarray)
            {
                Console.WriteLine(item);
            }

        }
    }
}
