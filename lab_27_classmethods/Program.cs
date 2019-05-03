using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_27_classmethods
{
    class Program
    {
        static void Main(string[] args)
        {
            var car01 = new Mercedes(); //
            car01.Speed = 10; //INITIAL CAR SPEED 
            //pass in old and get out new speed
            var increasedSpeed = car01.Accelerate(car01.Speed);
            increasedSpeed = car01.Accelerate(car01.Speed);
            increasedSpeed = car01.Accelerate(car01.Speed); //INCREASE SPEED 3 TIMES
            Console.WriteLine(increasedSpeed);

        }
    }

    class Mercedes
    {
        public int Speed;
        public int Accelerate(int oldSpeed)
        {

            oldSpeed++;
            Speed = oldSpeed;
            return Speed;
        }




    }


}

        //  IF ELSE...

