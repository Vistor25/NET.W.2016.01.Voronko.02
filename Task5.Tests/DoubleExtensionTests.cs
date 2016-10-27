using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task5.Tests
{
    [TestClass]
    public class DoubleExtensionTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            double a = 1991.829;
           

            string expected = "0100000010011111000111110101000011100101011000000100000110001001";
            //Act              
            string actual =a.ConvertToBits();
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
