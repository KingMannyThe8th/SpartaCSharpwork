using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_40_abstracts
{
    class Program
    {
        static void Main(string[] args)
        {
            //var h = new Holiday(); 
             //var h = LetsGo(); 
        }
    }
}  abstract class Holiday
{
    //REAL METHOD
    void VisitGeysers()
    {
        //WOW = HAVE A GREAT TIME
    }

    //ABSTRACT METHOD
    public abstract void GettingToIceland(); 

    class LetsGo : Holiday
    {
        public override void GettingToIceland()
        {
            //yes we do travel by plane and hire a car
        }

    }
}
