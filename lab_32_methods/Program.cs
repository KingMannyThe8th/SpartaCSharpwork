using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_32_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Inside another method ( not recommended as it can get messy with nesting with 'nesting')

            void DoSomething()
            {

                Console.WriteLine("I am doing something");
            }
            //call it
            DoSomething();

            // call static method 
            DoSomethingElse();

            // look at class dog

            var d = new Dog();
            d.Bark();

            Console.WriteLine(Dog.NumLegs);

        }
        // 2. In the same class using the STATIC KEYWORD whic attaches the keyowrd to this class 
        static void DoSomethingElse()
        {

            Console.WriteLine("Hey I'm doing something else");

        }

        //3. In another class either as a STATIC or INSTANCE method

        class Dog
        { 

        //instance g 
        public void Bark()
        {
            Console.WriteLine("dog is now barking loudly");
        }


        //static field
        public static int NumLegs = 4;



        }


    }
}
