using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab3_27_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Dog();
             d.Bark();
            var p = new Pitbull();
             p.Bark();
            var dal = new Dalmation();
            dal.Bark();
            var b = new Bulldog();
            b.Bark();
            var h = new Huskie();
            h.Bark(); 
            
            


        }
    }
    class Dog
    {
        public virtual void Bark()
        {
            Console.WriteLine("WOOF !");

        } //PARENT codes CAN BE OVERRIDDEN
    }

    class Pitbull : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("WOOF WOOF"); // Pitbull OVERRIDESS code of Dog OPTIONALLY//

        }

    }
    class Dalmation : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("WOOF WOOF WOOF"); 
            // Dalmation OVERRIDESS code of Dog OPTIONALLY//

        }
    }

    class Bulldog : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("WOOF WOOF WOOF WOOF "); 
            // Bulldog OVERRIDESS code of Dog OPTIONALLY//

        }
    }
    class Huskie : Dog
    {
        public override void Bark()
        {
            Console.WriteLine("WOOF WOOF WOOF WOOF WOOF WOOF"); 
            // Huskie OVERRIDESS code of Dog OPTIONALLY//

        }
    }

}

