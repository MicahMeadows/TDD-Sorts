using NUnit.Framework;
using System;
using TDD_Sorts.Sorting;
using System.Linq;

namespace TDD_Sorts.Tests
{
    [TestFixture]
    class BubbleSortTests
    {
        [Test]
        public void BubbleSort_WhenTwoSevenEightSixFive_ReturnsTwoFiveSixSevenEight()
        {
            // Arrange
            int[] unsortedInput = { 2, 7, 8, 6, 5 };

            // Act
            BubbleSort.Sort(unsortedInput);

            // Assert
            int[] sortedOutput = { 2, 5, 6, 7, 8 };
            Assert.IsTrue(Enumerable.SequenceEqual(unsortedInput, sortedOutput));
        }
    }
}
