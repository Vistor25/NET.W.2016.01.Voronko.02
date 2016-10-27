using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task4.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SqrtByNewtonMetod_Sqrt4_Return2()
        {
            // Arrange
            int a = 8;
            int n = 3;
            var expected = 2;
            //Act
            var actual = MethodNewton.SqrtByNewtonMetod(a, n);
            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtByNewtonMetod_nIsMinus3_ReturnArgumentException()
        {
            // Arrange
            int a = 8;
            int n = -3;
            var expected = 2;
            //Act
            var actual = MethodNewton.SqrtByNewtonMetod(a, n);
            //Assert


        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void SqrtByNewtonMetod_eIsOver1_ReturnArgumentException()
        {
            // Arrange
            int a = 8;
            int n = 3;
            double e = 2;
            var expected = 2;
            //Act
            var actual = MethodNewton.SqrtByNewtonMetod(a, n, e);
            //Assert


        }
    }
}
