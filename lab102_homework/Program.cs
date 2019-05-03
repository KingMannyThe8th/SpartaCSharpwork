using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab102_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //Collections.UseCollections(1,2,3,4,5);  
        }

    }
    public class Collections
    {

        //int stackvalue2; //

        public static int UseCollections(int a, int b, int c, int d, int e)
        {
            //Create a list with these 5 items
            var  Numbers = new List<int>();
            var myStack = new Stack<int>();
            var Queue = new Queue<int>(); 


            Numbers.Add(a);
            Numbers.Add(b);
            Numbers.Add(c);
            Numbers.Add(d);
            Numbers.Add(e);

            Console.WriteLine("Numbers.Count");

            //foreach(var value in Numbers)
            //{
              // Console.WriteLine(value);
            //}

            //ITERATE OVER LIST :MULTIPLY BY 2: ADD TO A STACK !


            for (int i = 0; i < Numbers.Count; i++)
            {
                   myStack.Push(2 * Numbers[i]);
            }


            //ITERATE OVER STACK: ADD 10 TO EACH NUMBER
            while(myStack.Count != 0)
            {
                Queue.Enqueue(10 + myStack.Pop()); //10 is the top number in the stock so it's popped and taken
                                                  //to be added to each remaining number
            }

            //ITERATE OVER QUEUE : RETURN TOTAL

            var sum = 0;

            while (Queue.Count != 0)
            {
                sum += Queue.Dequeue(); 
            }

            return sum;


            
                // 1,2,3,4,5
           // * 2 = 2,4,6,8,10
            // Console.WriteLine($"Number of items in 'Numbers' so far =", Numbers.Count);



            // Then iterate over this list : multiply each item by 2 : then add to a stack  !
            // Creating a Stack of strings 
           // Stack<string> myStack = new Stack<string>();
           
           // myStack.push(2);
           // myStack.push(4);
           // myStack.push(6);
           // myStack.push(8);
           // myStack.push(10);
            //the interate over the stack : add 10 to each number : then add to a QUEUE

            //iterate over the Queue and return the total 

            //Pop top number









           
        }

       

    }



}



