using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_lab2_27_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            Spaniel derived_Spaniel = new Spaniel();
            Poodle derived_poodle = new Poodle();
            Greyhound derived_GreyHound = new Greyhound();

            derived_Spaniel.SpanielBark();
            derived_poodle.PoodleBark();
            derived_GreyHound.GreyhoundBark();

            derived_Spaniel.Bark();
            derived_poodle.Bark();
            derived_GreyHound.Bark();

        }
    }

    class Dog
    {
        virtual public void Bark()
        {
           Console.WriteLine("PARENTDOG: Bark!");
        }
    }

    class Spaniel : Dog
    {
        public void SpanielBark()
        {
            Console.WriteLine("SPANIEL - BARK!!");
        }


    }

    class Poodle : Dog
    {
        public  void PoodleBark()
        {
            Console.WriteLine("PODDLE - BARK"); //ASK ABOUT 'BASE' !!
        }
    }

    class Greyhound : Dog
    {
        public  void GreyhoundBark()
        {
            Console.WriteLine("Greyhound - BARK!"); 
        }
    }

}
