using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using NUnit.Framework.Internal;

namespace Task1.NUnitTests
{
    [TestFixture]
    public class SearchingIndexLogicTests
    {
        [TestCase(new int[] {1, 2, 38, 58, 3, 15, 25, 77}, ExpectedResult = 5)]
        [TestCase(new int[] {1, 2, 38, 58, 3, 15, 25, 78}, ExpectedResult = -1)]
        [TestCase(new int[] {1, 2, 3, 4, 5, 15, 5, 4, 3, 2, 1}, ExpectedResult = 5)]
        public int Search_SumBeforeAndAfterIsEqual(int[] array)
        {
            return SearchingIndexLogic.Search(array);
        }

        [TestCase(new int[] {1, 2})]
        [TestCase(null)]
        [Test]
        public void Search_WrongParameters(int[] array)
        {
            //Assert.That(()=>SearchingIndexLogic.Search(array), Throws.TypeOf<ArgumentException>());
            Assert.Throws<ArgumentException>(()=>
            SearchingIndexLogic.Search(array));
        }
    }
}