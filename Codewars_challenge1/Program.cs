using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars_challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            //*Jaden Smith, the son of Will Smith, is the star of films such as The Karate Kid(2010) and After Earth(2013).
            //* Jaden is also known for some of his philosophy that he delivers via Twitter.
            //* When writing on Twitter, he is known for almost always capitalizing every word.


            //Your task is to convert strings to how they would be written by Jaden Smith.
            //The strings are actual quotes from Jaden Smith, but they are not capitalized in the same way he originally typed them.

            ///Example:


            //Not Jaden - Cased: "How can mirrors be real if our eyes aren't real"
            //Jaden - Cased:     "How Can Mirrors Be Real If Our Eyes Aren't Real"
            //Note that the Java version expects a return value of null for an empty string or null.
            // Convert String Using the String Class.
            //Convert a String to Uppercase. Convert a String to Lowercase.
            //Convert String Using the TextInfo Class.
            //Convert a String to Title Case.
            //Step-by-Step Example.
            //Note on the InvariantCulture Property.
            string NotJadenCased = "How can mirrors be real if our eyes aren't real";// Mixed cased String
            //string NotJadenCased = "converted from lowercase";

            string upperNotJadenCased = NotJadenCased.ToUpper();//String converted to Upper Case

            Console.WriteLine(upperNotJadenCased);
            //CODE HAS BEEN MADE 


        }

    }
}

    