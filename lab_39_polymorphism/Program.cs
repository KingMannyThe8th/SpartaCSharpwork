using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_39_polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {

          var p = new BaseParent();
            p.HaveAParty();
            var c = new DerivedChild();
            c.HaveAParty(); 

        }
    }
    class BaseParent {
        public virtual void HaveAParty() { Console.WriteLine("Having a Dinner Party"); } //PARENT codes CAN BE OVERRIDDEN
    }

    class DerivedChild : BaseParent
    {
        public override void HaveAParty()
        {
            Console.WriteLine("Having a Swimming Party"); // Child OVERRIDESS code of parent OPTIONALLY//

        }

    }
    class DerivedTeenager : BaseParent {
        public override void HaveAParty()
            {
                Console.WriteLine("Going out with friends"); // Teenager also OVERRIDESS code of parent OPTIONALLY//

            }
        }

       }
