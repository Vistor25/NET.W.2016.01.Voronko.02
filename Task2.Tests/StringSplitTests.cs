using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task2.Tests
{
    [TestClass]
    public class StringSplitTests
    {
        [TestMethod]
        public void StringSplitting_Returnabcdefgh()
        { 
            // Arrange
            string a = "aaabbccdd";
            string b = "eeffggghhh";
            
            string expected = "abcdefgh"; 
            //Act
            string actual = StringSplit.StringSplitting(a,b);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringSplitting_OneStringIsNull_ReturnArgumentExceptionn()
        {
            // Arrange
            string a = "aaabbccdd";
            string b = null;

            //Act
            var actual = StringSplit.StringSplitting(a, b);
            //Assert

        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void StringSplitting_OneStringIsEmpty_ReturnArgumentException()
        {
            // Arrange
            string a = String.Empty;
            string b = "eeffggghhh";
            //Act
            var actual = StringSplit.StringSplitting(a, b);
            //Assert

        }
    }
}
