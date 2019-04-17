using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eman1;

namespace lab_06_namespace
{
    class Program
    {
        static void Main(string[] args)
        {

            var item = new eman1.GreatTrainer();
            var item2 = new GreatTrainer();
            var item3 = new eman2.ExcellentLearning();
            Console.WriteLine(item3.LearnLots);


        }
    }
}

namespace eman1
{
    public class GreatTrainer { }


}

namespace eman2
{
    public class ExcellentLearning {

        public string LearnLots = "running C#";


    }


}