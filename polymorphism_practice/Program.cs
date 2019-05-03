using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphism_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new BaseMacdeesMenu();
            p.HappyMeal();

            var c = new DerivedMenu();
            c.HappyMeal(); 
        }
    }
    class BaseMacdeesMenu
    {
        public virtual void HappyMeal() { Console.WriteLine("Ordering a Happy Meal"); } //PARENT codes CAN BE OVERRIDDEN
    }

    class DerivedMenu : BaseMacdeesMenu
    {
        public override void HappyMeal()
        {
            Console.WriteLine("Ordering a Chicken Legend"); // Chicken Legend Choice OVERRIDESS} 
        }

        class DerivedMenu2 : BaseMacdeesMenu2
        {

        }
    }

    internal class BaseMacdeesMenu2
    {
    }
}
