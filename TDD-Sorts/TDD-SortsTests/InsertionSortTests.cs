using NUnit.Framework;
using System.Linq;
using TDD_Sorts.Sorting;

namespace TDD_SortsTests
{
    [TestFixture]
    class InsertionSortTests
    {
        [Test]
        [TestCase(new int[]{4,5,3,1,2}, new int[]{1,2,3,4,5})]
        public void InsertionSort_WhenUnsortedPositiveArray_ReturnsSortedPositiveArray(int[] unsortedInput, int[] sortedOutput)
        {
            // Act
            InsertionSort.Sort(unsortedInput);

            // Assert
            Assert.IsTrue(Enumerable.SequenceEqual(unsortedInput, sortedOutput));
        }
    }
}
