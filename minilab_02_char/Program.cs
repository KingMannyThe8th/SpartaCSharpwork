using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minilab_02_char
{
    class Program
    {
        static void Main(string[] args)
        {
            //#### Strings, Chars and Loops
            //A char can hold 256 different 'characters'.
            //Create a loop that will output all these characters to the screen.
            //Hint: `(char)i` (where i is an int) will cast i to a char.
            //Note: not all 256 'characters' actually represent characters.
            //Some of these 'characters' are what is referred to as 'control characters'.
            //The computer might attempt to represent these characters though, but don't be surprised if you get some weird output.
            // Create a string variable with a certain text, then have the program return the string in reverse.
            //Skip if too hard.Bonus: have the user input the string to be reversed.//

               
                
                for (int i = 0; i < 256; i++)
                {

                    Console.Write((char)i);

                


                }
                   
            }
        }
    }



    
