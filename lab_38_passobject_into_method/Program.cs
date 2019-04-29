using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_38_passobject_into_method
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Animal("lion", 12,200); //
            var b = new Animal("Tiger", 13, 150); //

            ProcessAnimal(a);
            ProcessAnimal(a);// the more that the METHOD is recalled, 
                             // the more it will increment AGE and increase the WEIGHT 
            ProcessAnimal(a);
            ProcessAnimal(a);
            Console.WriteLine($"after processing animal has age {a.Age} and height {a.Weight}");

        }

        // process animals

        static void ProcessAnimal(Animal animal) {
            animal.Age++;
            animal.Weight += 20; 


        }
    }

    class Animal
    {
        public string Type { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        // constructor  
        public Animal(string type, int age, double weight)
        {
            this.Type = type;
            this.Age = age;
            this.Weight = weight;

        }


    }
}
