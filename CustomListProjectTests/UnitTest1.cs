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

        [TestMethod]
        public void Remove_ListItem()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            // Act
            int actual = customList.Count;
            customList.Remove(2);

            // Assert
            Assert.AreNotEqual(actual, customList.Count);
        }

        [TestMethod]
        public void Remove_EmptyList()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(2);
            int itemToBeRemoved = 2;

            // Act
            customList.Remove(2);

            // Assert
            Assert.AreNotEqual(itemToBeRemoved, customList[0]);
        }

        [TestMethod]
        public void Remove_Objects()
        {
            // Arrange
            CustomList<object> customList = new CustomList<object>();
            object objectToBeRemoved = customList;

            // Act
            customList.Add(customList);
            customList.Add(customList);
            customList.Remove(customList);
            customList.Remove(customList);
            
            // Assert
            Assert.AreNotEqual(objectToBeRemoved, customList[0]);
        }

        [TestMethod]
        public void itemToString()
        {
            // Arrange
            CustomList<int> customList = new CustomList<int>() { 2, 4, 6, 8 };

            // Act
            string actual = customList.ToString();
            string expected = "2468";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void intItemToString()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>() { "1", "2", "3" };

            // Act
            string actual = customList.ToString();
            string expected = "123";

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void emptyCustomListToString()
        {
            // Arrange
            CustomList<string> customList = new CustomList<string>();

            // Act
            string expected = "";
            string actual = customList.ToString();
            
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }

}
