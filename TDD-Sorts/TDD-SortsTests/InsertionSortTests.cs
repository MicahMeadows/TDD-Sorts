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
        [TestCase(new int[] { -2, -7, -8, -6, -5 }, new int[] { -8, -7, -6, -5, -2 })]
        [TestCase(new int[] { -4, -5, -3, -1, -2 }, new int[] { -5, -4, -3, -2, -1 })]
        public void InsertionSort_WhenUnsortedPositiveAndNegativeArray_ReturnsSortedPositiveAndNegativeArray(int[] unsortedInput, int[] sortedOutput)
        {
            // Act
            InsertionSort.Sort(unsortedInput);

            // Assert
            Assert.AreEqual(unsortedInput, sortedOutput);
        }

        [Test]
        public void InsertionSort_WhenEmptyArray_VerifyNoIssues()
        {
            int[] emptyArray = { };
            InsertionSort.Sort(emptyArray);
            Assert.IsFalse(emptyArray.Any());
        }

    }
}
