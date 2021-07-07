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
        public void TestingFirstString()
        {
            string first = "Peach", second = "Apple", third = "Banana";
            string expected = first;

            string actual = three.FindMaximumString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingSecondString()
        {
            string first = "Banana", second = "Peach", third = "Apple";
            string expected = second;

            string actual = three.FindMaximumString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestingThirdString()
        {
            string first = "Banana", second = "Apple", third = "Peach";
            string expected = third;

            string actual = three.FindMaximumString(first, second, third);

            Assert.AreEqual(expected, actual);
        }
    }
}
   