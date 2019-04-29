using NUnit.Framework;
using lab102_homework;

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

        
    }
}