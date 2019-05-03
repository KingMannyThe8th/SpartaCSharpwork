using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICE_RUN
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array01 = new int[4];
            Queue<int> queue01 = new Queue<int>(); 
            List<int> list01 = new List<int>();
            Stack<int> stack01 = new Stack<int>();
            Dictionary<int, int > dictionary01 = new Dictionary<int, int>();

            array01[0] = 1;
            array01[1] = 2;
            array01[2] = 3;
            array01[3] = 4;

            foreach (var item01 in array01)
            {
                queue01.Enqueue(item01 + 5);
            }

            while (queue01.Count > 0)
            {
                list01.Add(queue01.Dequeue() + 5);
            }

            foreach (var item01 in list01)
            {
                stack01.Push(item01 + 5);
            }

            for (int i = 0; i < 3 ; i++)
            {
                dictionary01[i] = stack01.Pop(); 
            }
            var total = 0;

            foreach (var key in dictionary01.Keys)
            {
                total += dictionary01[key]; 
            }

            Console.WriteLine(total);

        }
    }
}
