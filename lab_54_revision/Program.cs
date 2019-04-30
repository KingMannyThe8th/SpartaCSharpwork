using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_54_revision
{
    class Program
    {
        static void Main(string[] args)
        {

            int x = 10;

            switch (x)
            {

                case 1:
                    Console.WriteLine("Item is 1");
                    break;

                case 10:
                    Console.WriteLine("Item is 10");
                    break;
                default:
                    Console.WriteLine("Item is not allowed");
                    break;
            }

            //SWITCH - ALLOWS US TO 
            // DoThis();
            ///DoThis(10);

            //static void DoThis()
            //{
            // Console.WriteLine("Doing something");
            //}

            //static void DoThis(int x) { Console.WriteLine("I am doing something"); }
            
            
            //POLYMORPHISM
            var p = new Parent();
            p.HaveAParty(); 

            var c1 = new Child1();
            c1.HaveAParty();

            var c2 = new Child2();
            c2.HaveAParty();

            var c3 = new Child3();
            c3.HaveAParty();


        }
    }  
    public  class Parent
    {
        virtual public void HaveAParty() { Console.WriteLine("Parent is working"); }
    }

    public  class Child1:Parent 
    {
        override public void HaveAParty() { Console.WriteLine("Parent is taking me to the cinema"); }
    }

    public class Child2 : Parent
    {
        override public void HaveAParty() { Console.WriteLine("Child2 is sleeping"); }
    }

    public class Child3 : Parent
    {
        override public void HaveAParty() { Console.WriteLine("Playing PS4"); }
    }
}

