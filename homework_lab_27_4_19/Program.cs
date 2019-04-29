using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab1_27_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare 3 objects in array
            Dog[] BreedArray = new Dog[3];

            //Initialize the objects(breed)

            BreedArray[0] = new Dog(); //1st dog
            BreedArray[1] = new Dog(); //2nd dog
            BreedArray[2] = new Dog(); //3rd dog 

            //BARK FUNCTION RECALLED
            BreedArray[0].Bark(); //DOG 1 BARK 
            BreedArray[1].Bark(); //DOG 2 BARK 
            BreedArray[2].Bark(); //DOG 3 BARK 

        }
    }
    public class Dog
    {

        //public string PedigreeBreed;
        //public string AndrexBreed;
        //public string BulldogBreed;
        public int i;

        public void Bark() //BARK FUNCTION 
        {
            Console.WriteLine("BARK!");

        }
       

       //BULLDOG



      //ANDREX




        


        
       


    







    }

}
