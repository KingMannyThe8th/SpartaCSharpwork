using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_42_test_me
{
    public class testMe
    {
        public double BIDMAS01(int x, int y, int z)
        {
            //goal : x + y/z observing BIDMAS rules 
            double Y = y;
            double Z = z;


            //return -1; //in computer language '-1' means FAIL
            return x + (Y / Z);
        }
    }
}
