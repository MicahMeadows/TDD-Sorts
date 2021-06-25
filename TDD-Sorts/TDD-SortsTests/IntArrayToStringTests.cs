using NUnit.Framework;
using TDD_Sorts.Utility;

namespace TDD_SortsTests
{
    [TestFixture]
    public class IntArrayToStringTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, "1, 2, 3, 4, 5")]
        [TestCase(null, null)]
        [TestCase(new int[]{}, null)]
        [TestCase(new int[] { 1 }, "1")]
        [TestCase(new int[] { 2, 28, 2, 0, 1, 9 }, "2, 28, 2, 0, 1, 9")]
        public void IntArrayToString_WhereDefault_ReturnsStringifiedIntArray(int[] inputArray, string outputString)
        {
            string convertedString = SortManager.IntArrayToString(inputArray);
            Assert.AreEqual(outputString, convertedString);
        }
    }
}
