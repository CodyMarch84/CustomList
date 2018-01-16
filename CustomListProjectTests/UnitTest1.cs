using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomList;

namespace CustomListProjectTests
{
    [TestClass]
    public class UnitTest1
    {   
        [TestMethod]
        public void Add_ValueIsInserted()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 5;

            // Act
            customList.Add(5);
            int actual = customList[0];
            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Count_ItemsInArray()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 7;

            // Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Add(4);
            customList.Add(5);
            customList.Add(6);
            customList.Add(7);
            int actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void LastItem()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            int expected = 3;

            // Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            int actual = customList[2];

            // Assert
            Assert.AreEqual(expected, actual);

        }
    }

}
