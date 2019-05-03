using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_105_hw_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    
    public class Parent
    {
        virtual public string OutputText()
        {
            return "We support Arsenal in this house";
        }
    }

    public class Child : Parent
    {
        public override string OutputText()
        {
            return "I support Man U !!!";
        }
    }


}
