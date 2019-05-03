using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quick_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] Array01 = new int [3];
            Queue<int> Queue01 = new Queue<int>();
            List<int> List01 = new List<int>();
            Stack<int> Stack01 = new Stack<int>();
            Dictionary<int, int> dictionary01 = new Dictionary<int, int>(); 

            Array01[0] = 2;
            Array01[1] = 4;
            Array01[2] = 6;

            Queue01.Enqueue(2);
            Queue01.Enqueue(4);
            Queue01.Enqueue(6);  
            



            foreach (int item in Array01)
            {
                Queue01.Enqueue(item *2);
            }

            while (Queue01.Count > 0)
            {
                List01.Add(Queue01.Dequeue() * 2);
            }

            foreach (int item in List01)
            {
                Stack01.Push(item * 2);
            }

            for (int i = 0; i < 3; i++)
            {
                dictionary01[i] = Stack01.Pop() * 2;
            }

            var total = 0; 

            foreach (var key in dictionary01.Keys) //LOOK UP ".Keys" on google. What is it ?
            {

                total += dictionary01[key]; 
            }

            Console.WriteLine(total);

           // for (int j = 0; j < 4; j++)
            //{
              //  List01.Add(j*2)
            //}
        }
    }
}
