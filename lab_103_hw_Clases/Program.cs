using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_103_hw_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Dog
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public Dog() { }

        public int Grow(out int height, out int resultheight)
        {
            height = Height + 5;

            return Age + 1; 
        }


      //Create Dog Class and Grow() method : check when you call this the Age increases by one year and the height increases by 5 as well




    }
}   


