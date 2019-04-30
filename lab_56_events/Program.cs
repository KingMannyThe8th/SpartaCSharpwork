using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_56_events
{
    class Program
    {
        //Delegate : says that our event can only trigger methods which have a set pattern

        delegate void MyDelegate(); //pattern: method must be void....()

        //eventnow uses this delegate

        static event MyDelegate myEvent; //Create Event; when it triggers any methods, must match this pattern 



        //goal: to manually replace calling 3 methods with 1 event which triggers these methods
        static void Main(string[] args)
        {
            MyMethod01();
            MyMethod02();
            MyMethod03();

            //attach methods to our event

            myEvent += MyMethod01;

            //call the event
            myEvent();
        }

        static void MyMethod01()
        {
            Console.WriteLine("Doing something 01");
        }

        static void MyMethod02()
        {
            Console.WriteLine("Doing something 02");
        }
        static void MyMethod03()
        {
            Console.WriteLine("Doing something 03");
        }


     }



      
     
}
