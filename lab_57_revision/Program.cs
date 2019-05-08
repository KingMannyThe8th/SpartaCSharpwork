using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_57_revision
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog(100); //d is an instance - INSTANTITION - MAKING AN OBJECT FROM A CLASS
            var s = new Spaniel();
            s.Height = 100000;

            var p = new Parent();
            var c1 = new Child();
            var c2 = new Child2();
            var c3 = new Child3();
            

            p.HaveAParty();
            c1.HaveAParty(); 
            c2.HaveAParty();
            c3.HaveAParty();
        }
    }

    class Dog
    {
        public int Height { get; set; }
        internal int Length { get; set; }
        protected int Weight { get; set; }
        private int _age { get; set; } //encapsulated - underscore & lowercase

        public Dog() { } //default constructor 

        public Dog(int Height) //constructor 
        {
            this.Height = Height;
        }

       


    }
    class Spaniel : Dog
    {

        public Spaniel()
        {
           // this.
        }


    }

    class Parent
    {
        public virtual void HaveAParty() { Console.WriteLine("Parent fun"); }
    }

    class Child : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Sleep"); }
    }

    class Child1 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Eat"); }
    }
    class Child2 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Party"); }
    }
    class Child3 : Parent
    {
        public override void HaveAParty() { Console.WriteLine("Cinema"); }
    }
}
