using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_11_datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hi";
            String y = "there";

            //use lowercase 'string'
            //Uppercase sttring is when use string as a 
            Console.WriteLine(x + y);

            //super-long strings this is memory inefficient
            //stringbuilder: use to build very long strings

            var longString = new StringBuilder();
            for(int i = 0;i < 1000000; i++)
            {
                longString.Append($"adding{i}");
            }

            //INTEGERS ARE 32 BITS LONG
            int anyNumber = 23456;
            Console.WriteLine(anyNumber.GetType());
            
            




        }
    }
}
