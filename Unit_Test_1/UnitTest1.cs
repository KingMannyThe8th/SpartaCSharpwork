using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using lab_42_test_me;
using lab102_homework; 

namespace Unit_Test_1
{
    [TestClass]
    public class Demo_Test_For_Lab_42_TestMe
    {
        public void Lab_42_testMe_Test01()
        {
            //arrange
            var instance01 = new testMe();
            var expected = 14.0;

            //act

            var actual = instance01.BIDMAS01(10, 20, 5);


            //assert 
            Assert.AreEqual(expected, actual);      

        }

        [TestMethod]
        public void Demo_Test_For_Lab_42_TestMe02()
        {
            //arrange
            var instance02 = new testMe();
            var expected2 = 53.0;

            //act

            var actual2 = instance02.BIDMAS01(50, 30, 10);


            //assert 
            Assert.AreEqual(expected2, actual2);
        }
            
            [TestCase (1,2,3,4,5, -11)]
            public void Lab_102_Collections_Test01(int a, int b, int c, int d, int e, int expected)
            {
                //arrange


                //act
                var actual = Collections.UseCollections(a, b, c, d, e);

                //assert 
                Assert.AreEqual(expected, actual); 

            }

          
         
    
  

}




