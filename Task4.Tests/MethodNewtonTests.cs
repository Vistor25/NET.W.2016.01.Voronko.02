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
            int n = 2;
            var expected = 2.8284;
            //Act
            var actual = MethodNewton.SqrtByNewtonMetod(a,n);
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
