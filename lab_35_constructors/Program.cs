using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_35_constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent("fred", 32);
            varp2 = new Parent(); 

        }
    }
}  class Parent{  
        public string Name { get; set; } //PROPERTY
        public int Age;
    //creater constructor : same name as class 
    //this keyword refers to 'instance' i.e 'p' above
        public Parent(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }
     //CONSTRUCTOR IS PRESENT EVEN WHEN WE DONT CODE ONE. 
     //DEFAULT (BLANK) CONSTRUCTOR WHICH IS WHY WE USE NEW ....KEYWORD WITH CLASS NAME AND BRACKETS
      // there is a method called the destructor or finaliser which can be called when we are destroying an object.
      
    //BE AWARE WHEN YOU CODE YOUR OWN CONSTRUCTOR, THE DEFAULT (BLANK) ONE NO LONGER EXISTS

    //BE AWAR
       public Parent() { } //CONSTRUCTOR IS PRESENT AGAIN, making p2 okay
        }


   }

   class Child : Parent { }

