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
            var p = new Parent();
            p.OutputText();
            var c = new Child();
            c.OutputText(); 
        }
    }

    
    public class Parent
    {
        public virtual string OutputText()
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
