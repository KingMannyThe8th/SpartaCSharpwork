using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_bh_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myarray = new int[5];
            Queue<int> queue01 = new Queue<int>();
            List<int> mylist = new List<int>();
            Stack<int> myStack = new Stack<int>();
            ArrayList myarraylist = new ArrayList();
            HashSet<int> myhashset = new HashSet<int>();

            myarray[0] = 10;
            myarray[1] = 20;
            myarray[2] = 30;
            myarray[3] = 40;
            myarray[4] = 50;

            Console.WriteLine(myarray);



            foreach (var arraynumber in myarray)
            {
                queue01.Enqueue(arraynumber);

               
            }

            

            foreach (var item01 in queue01)
            {
                mylist.Add(item01);

                Console.WriteLine();
            }





        }   
    }
}
