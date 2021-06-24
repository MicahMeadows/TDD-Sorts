using NUnit.Framework;
using System.Linq;
using TDD_Sorts.Sorting;

namespace TDD_SortsTests
{
    [TestFixture]
    class InsertionSortTests
    {
        [Test]
        [TestCase(new int[] { 4, 5, 3, 1, 2 }, new int[] { 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 2, 7, 8, 6, 5 }, new int[] { 2, 5, 6, 7, 8 })]
        public void InsertionSort_WhenUnsortedPositiveArray_ReturnsSortedPositiveArray(int[] unsortedInput, int[] sortedOutput)
        {
            // Act
            InsertionSort.Sort(unsortedInput);

            // Assert
            Assert.AreEqual(unsortedInput, sortedOutput);
        }
    }
}
