using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task3.Tests
{
    [TestClass]
    public class BitInsertionTests
    {
        [TestMethod]
        public void Insertion_145in78from7to18_Return206()
        {
            // Arrange
            int a = 78;
            int b = 145;
            int firstIndex = 7;
            int secondIndex = 18;

            int expected = 206;
            //Act
            int actual = BitInsertion.Insertion(a, b, firstIndex, secondIndex);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Insertion_145in78fromMinus7to18_ReturnArgumentExeption()
        {
            // Arrange
            int a = 78;
            int b = 145;
            int firstIndex = -7;
            int secondIndex = 18;

            int expected = 206;
            //Act
            int actual = BitInsertion.Insertion(a, b, firstIndex, secondIndex);
            //Assert

        }
    }
}
