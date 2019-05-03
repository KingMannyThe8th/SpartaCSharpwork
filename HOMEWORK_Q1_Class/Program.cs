using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HOMEWORK_Q1_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dog1 = new Dog();  //INSTANTIATION - CREATION OF OBJECT 

            


        }
    }

    class Dog //CLASS
    {
        // FIELD VARIABLES
        int age;            
        int weight; //in kg
        string breed;


        public void Bark() // METHOD/FUNCTION
        {
            
            Console.WriteLine("BAAAAAARK !!!!!");
        }

        public void Age()
        {
            age++;
            

        }

        public void Size()
        {
            weight++; 
        }






    }




  

}
