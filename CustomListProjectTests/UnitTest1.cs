using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListProjectTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange -- 
            Addition addition = new Addition();
            int num1 = 4;
            int num2 = 3;
            int expected = 7;

            // Act --
            int actual = addition.addTwoNumbers(num1, num2);

            // Assert --
            Assert.AreEqual(expected, actual);
            // { 3, 5, 6, 5, 8, 2 }
        }
    }
}
