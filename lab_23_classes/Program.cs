using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_23_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create first object from Blueprint 'class'  
            var p01 = new Parent();
            //p01 is our new project
            p01.Age = 21;
            p01.Height = 1500;
            p01.Name = "Ayo";
            Console.WriteLine($"Person has name {p01.Name}, height {p01.Height} and age {p01.Age}");
            //Check if person has grown
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
            p01.Grow();
            Console.WriteLine($"New age is {p01.Age}");
        }
    }
}
    class Parent
    {
         public string Name;
         public int Age;
         public double Height;

         public void Grow()
         {
            Age++;
         }
    }