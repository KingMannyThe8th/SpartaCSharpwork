using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_24_inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var p01 = new Parent();
            p01.Name = "Father";
            p01.Age = 25;//give age 
            p01.Name = "Sam";
            var c01 = new Child();
            c01.Name = "Simeon";
            c01.Age = 5;
            c01.Height = 300;


            for (int i = 0; i<10; i++)
            {

                c01.Grow();//make grow in loop: 10 times

                Console.WriteLine($"Child has name {c01.Name}, height {c01.Height} and age {c01.Age}");
                //Check if person has grown
            }

            c01.Grow();//make grow in loop: 10 times
            var output = c01.Grow2();
            Console.WriteLine(output);
            
        }
    }

    class Parent
    {

        public string Name;
        public int Age; //age
        public double Height;//grow 

        public void Grow() //increments age - void means no value is returned in print
        {

            Age++; 

        }

        public int Grow2()
        {
            Age++;
            return Age;

        }

    }

    class Child : Parent
    {
        public string Name;
        public int Age;
        public double Height;

        public void Grow()
        {

            Age++;


        }

    } //allows for variables of parent to be available to child



}
