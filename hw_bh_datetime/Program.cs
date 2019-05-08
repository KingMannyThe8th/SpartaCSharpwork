using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_bh_datetime
{
    class Program
    {
        static void Main(string[] args)
        {

            //Create today's date then go back 100 years, and then also add 10 seconds and print out the date
            DateTime dateTime = new DateTime(2019, 5, 7, 16, 19, 30);

            DateTime newDate = dateTime.AddYears(-100).AddSeconds(10);//Minus 100 years, add 10 seconds 

            Console.WriteLine($"today's date and time is  {dateTime}");

            Console.WriteLine($"100 years ago the date and time was {newDate}");

            //   Print out the date in several formats eg DDMMYY

            Console.WriteLine(dateTime.ToString("ddMMyy")); // 070519
            //, DD-MMM - YYYY, 

            Console.WriteLine(dateTime.ToString("dd-MMM-yyyy")); // 07 - May - 2019
                                                                 //as an integer number of seconds since time zero, etc.

            Console.WriteLine(dateTime.ToString("dd-MM-yy")); //07 - 05 - 19 


            Console.WriteLine(dateTime.ToString("dddd, dd MMM yyyy"));

        }
    }
}
 