using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_30_queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> Queue01 = new Queue<int>();
            
           
            
            for(int i = 0; i < 10; i++)
            {
                Queue01.Enqueue(i * 10);

            }
            Console.WriteLine($"This contains the item 50 ?" + $"{Queue01.Contains(50)}");
            Console.WriteLine("Display full queue first before we begin");

            foreach (int item in Queue01)
            {


            }

        }
    }
}
