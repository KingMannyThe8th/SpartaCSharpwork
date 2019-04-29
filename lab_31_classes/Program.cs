using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_31_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Parent();
            p.SetHidden("hello private data");
            p.Age = 23;
            p.Height = 1500; // 1500mm
            p.Height = -1500; 
            Console.WriteLine(p.Height);
        }

        class Parent
        {

            
            private string _hidden; //private field
            private double height; // 
            public int Age { get; set; }//public property : abbreviated form 
                                        //auto implemented properties - faster way to do getters and setters
         
         //expanded form

            public double Height
            {
                get
                {
                    return height;

                }

                set
                {
                    if(value > 0)
                    {

                        height = value;

                    }
                    
                        

                    
                     
                }

            }

            public void SetHidden(string setData)
            {
                _hidden = setData; 
            }

            public string GetHidden()
            {

                return _hidden;
            }

        }
    }
}
