using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MaximumProblemUsingGenerics1;
namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        FindMaximumAmongThree three;
        [TestInitialize]
        public void SetUp()
        {
            three = new FindMaximumAmongThree();
        }
        [TestMethod]
        public void TestingFirstValue()
        {
            int first = 70, second = 35, third = 67;
            int expected = first;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingSecondValue()
        {
            int first = 15, second = 20, third = 17;
            int expected = second;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingThirdValue()
        {
            int first = 30, second = 60, third = 90;
            int expected = third;

            int actual = three.FindMaximum(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }
}
