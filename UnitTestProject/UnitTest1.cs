using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MaximumProblemUsingGenerics1;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
       FindMaximumAmongThree<int> maxInt;

        FindMaximumAmongThree<float> maxFloat;


        [TestInitialize]
        public void SetUp()
        {

            maxInt = new FindMaximumAmongThree<int>(10,20,30);
            maxFloat = new FindMaximumAmongThree<float>(1.2f, 3.5f, 6.7f);

        }
        [TestMethod]
        public void TestIntMethod()
        {

            int expected = 30;
            int actual = maxInt.TestMaximum();
            Assert.AreEqual(expected,actual);
        }
        [TestMethod]
        public void TestFloatMethod()
        {

            float expected = 6.7f;
            float actual = maxFloat.TestMaximum();
            Assert.AreEqual(expected, actual);
        }
    }
}

   