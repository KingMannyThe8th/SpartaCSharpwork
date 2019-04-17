using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_18_bytes
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b = 0b10101010; // latest c# has literal binary type

            //also use hex

            byte bb = 0xFF; //f=15 decimal = 1111 in binary
                            //so FFFF will be 1111 1111 in binary
                            //

            char c = 'f';

            Console.WriteLine(c);

            Console.WriteLine((int)c);  

            char c02 = 'g';
            Console.WriteLine((int)c02);

            char c03 = (char)104;
            Console.WriteLine(c03);

            string s = "abcdef";
            foreach(char item in s) //break down string into individual items 
            {
                Console.WriteLine(item);
            }

        }
    }
}
