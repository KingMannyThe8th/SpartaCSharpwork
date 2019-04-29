using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_36_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANTIATE FIRST
            var p = new Parent();
            p.DoThis();
            p.DoThis(10);
            p.DoThis("hi");
            p.DoThis(10, "hi", true);

            //or a STATIC METHOD

            Parent.DoThat(); 

        }

    }
    class Parent
    { 
        public void DoThis() { }
        public void DoThis(int x) { Console.WriteLine("integer"); }
        public void DoThis(string y) { Console.WriteLine("string"); }
        public void DoThis(int x, string y, bool z) { Console.WriteLine("three"); }

        public static void DoThat() { Console.WriteLine("static"); }
    }
}
