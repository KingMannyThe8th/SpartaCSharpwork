using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_102_list
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //STACK 
            //STACK 10 ITEMS - PUSH & POP

            Stack<int> stacks = new Stack<int>(); //

            stacks.Push(1);//BOTTOM MOST
            stacks.Push(2);
            stacks.Push(3);
            stacks.Push(4);
            stacks.Push(5);
            stacks.Push(6);
            stacks.Push(7);
            stacks.Push(8);
            stacks.Push(9);
            stacks.Push(10);//TOP MOST

            foreach (int integer in stacks)
            {

                Console.WriteLine(integer); //DISPLAYING STACK ELEMENTS
            }

            Console.WriteLine($"Number of stack elements =" + stacks.Count); //STACK COUNT
            Console.WriteLine(stacks.Contains(10)); //Search for 10 if its there
            Console.WriteLine(stacks.Pop());// Bring out 10 and take it off the stack
            Console.WriteLine($"Top item is {stacks.Peek()}");
            // use every item in the stack 
            Console.WriteLine($"Using every item from stack {stacks.Peek()}");
            while (stacks.Count > 0)
            {
                Console.WriteLine(stacks.Pop());
            }


            //LISTS - INTEGERS
            List<int> CubedNumbers = new List<int>();
            CubedNumbers.Add(1);
            CubedNumbers.Add(8);
            CubedNumbers.Add(27);
            CubedNumbers.Add(64);
            CubedNumbers.Add(125);
            CubedNumbers.Add(216);
            CubedNumbers.Add(343);
            CubedNumbers.Add(512);
            CubedNumbers.Add(729);
            CubedNumbers.Add(1000);

            Console.WriteLine($"No. of cubed numbers present in List:\t"   +   CubedNumbers.Count );

            Console.WriteLine("\nFollowing cubes are:");
            Console.WriteLine(CubedNumbers[0]);
            Console.WriteLine(CubedNumbers[1]);
            Console.WriteLine(CubedNumbers[2]);
            Console.WriteLine(CubedNumbers[3]);
            Console.WriteLine(CubedNumbers[4]);
            Console.WriteLine(CubedNumbers[5]);
            Console.WriteLine(CubedNumbers[6]);
            Console.WriteLine(CubedNumbers[7]);
            Console.WriteLine(CubedNumbers[8]);
            Console.WriteLine(CubedNumbers[9]);

            //LISTS - CHARACTERS
            List<char> Characters = new List<char>();
            Characters.Add('a');   
            Characters.Add('b'); 
            Characters.Add('c'); 
            Characters.Add('d'); 
            Characters.Add('e'); 
            Characters.Add('f'); 
            Characters.Add('g'); 
            Characters.Add('h'); 
            Characters.Add('i');

            Console.WriteLine($"\nNumber of characters present in List:\t" + Characters.Count );

            Console.WriteLine(Characters[0]);
            Console.WriteLine(Characters[1]);
            Console.WriteLine(Characters[2]);
            Console.WriteLine(Characters[3]);
            Console.WriteLine(Characters[4]);
            Console.WriteLine(Characters[5]);
            Console.WriteLine(Characters[6]);
            Console.WriteLine(Characters[7]);
            Console.WriteLine(Characters[8]);


            //QUEUE

            Queue<int> Bus = new Queue<int>(); //QUEUE FOR BUSES LEAVING A BUS GARAGE IN STREATHAM HILL 

            Console.WriteLine("\nBuses:");
            Bus.Enqueue(59);
            Bus.Enqueue(137);
            Bus.Enqueue(319);
            Bus.Enqueue(159);
            Bus.Enqueue(109);
            Bus.Enqueue(250);
            Bus.Enqueue(50);
            Bus.Enqueue(417);
            Bus.Enqueue(333);
            Bus.Enqueue(255);



            Bus.Dequeue(); //Releases first bus in queue

            foreach (int busnumber in Bus) {

                Console.WriteLine(busnumber);

            }

            Console.WriteLine("Number of buses in queue:" + Bus.Count);

            Console.WriteLine("\nBus 59 still in the garage ? " + Bus.Contains(59));
        }

        
    }
}
