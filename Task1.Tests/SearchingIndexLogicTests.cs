using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.Tests
{
    [TestClass]
    public class SearchingIndexLogicTests
    {
        [TestMethod]
        public void Search_SumBeforeAndAfterIsEqual_Returned5()
        {
            // Arrange
            int[] array = {1, 2, 38, 58, 3, 15, 25, 77};
            int expected = 5;
            //Act
            int actual = SearchingIndexLogic.Search(array);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Search_SumBeforeAndAfterIsNotEqual_ReturnedMinus1()
        {
            // Arrange
            int[] array = { 1, 2, 38, 58, 3, 15, 28, 77 };
            int expected = -1;
            //Act
            int actual = SearchingIndexLogic.Search(array);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Search_ArrayLengthLowerThan3_ReturnedArgumentException()
        {
            // Arrange
            int[] array = { 1, 2};
           
            //Act
            var actual = SearchingIndexLogic.Search(array);
            //Assert
            
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Search_ArrayIsNull_ReturnedArgumentException()
        {
            // Arrange
            int[] array = null;
            
            //Act
            var actual = SearchingIndexLogic.Search(array);
            //Assert

        }
    }
}
