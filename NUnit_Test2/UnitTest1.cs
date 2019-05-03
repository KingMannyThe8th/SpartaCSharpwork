using NUnit.Framework;
using lab102_homework;
using lab_103_hw_Clases;
using lab_104__hw_stopwatch;
using lab_105_hw_polymorphism; 

namespace Tests
{
    public class Tests
    {

        [TestCase(1, 2, 3, 4, 5, -1)] //add 2 more tests 
        public void Lab_102_Collections_Test01(int a, int b, int c, int d, int e, int expected)
        {
            //arrange


            //act
            var actual = Collections.UseCollections(a, b, c, d, e);

            //assert 
            Assert.AreEqual(expected, actual);

        }

        [TestCase(-1, -1, -1, -1)]
        public void lab_103_hw_Clases_Test(int initialAge, int initalHeight,
            int finalAge, int FinalHeight)
        {
            //arrange

            var expected = -1;
            var instance = new Dog();


            //assert

            var actual = instance.Grow(out int finalheight);




            //act 

            Assert.AreEqual(expected, actual);  //age
            Assert.AreEqual(expected, actual);  //height 
        }
      //POLYMORPHISM TEST CASE

        [TestCase(true, "I support Man U !!!")]
        [TestCase(false, "We support Arsenal in this house !!!")]
        public void lab_05_hw_polymorphism(bool Child, string expected)
        {
            Child son = new Child();
            Parent Papa = new Parent();
            if (Child)
                Assert.AreEqual(expected, son.OutputText());
            else
                Assert.AreEqual(expected, Papa.OutputText());
        }

        //STOPWATCH TESTING !!


       //STILL NOT UNDERSTANDING ASSIGNMENT OF TEST CASE FOR EXAMPLE CODE 
        public void Lab_hw_Stopwatch(int expected, int limit)
        {
            //n=8 3 seconds
            //n=9 12 seconds
            //n=10 36 seconds
            int power = 0, time = 0;
            while (time < limit * 1000)
            {
                power++;
                time = CountNumber.CountNow(power, limit);
            }
            var actual = power;
            Assert.AreEqual(expected, actual);
        }




        //TestCase for classes - ? 
        public void lab_103_hw_Classes(int initialAge,int InitialHeight, int finalAge, int finalHeight)
        {
            var expected = finalAge;
            var instance = new Dog();
            instance.Height = InitialHeight; 
            var actual = instance.Grow(initialAge, out int resultheight);
            Assert.AreEqual(expected, actual);//height
            actual = resultheight;
            expected = finalHeight;
            Assert.AreEqual(expected, actual);//age
        }


    }
        
       

    }
}