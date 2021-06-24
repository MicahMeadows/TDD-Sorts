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
        public void BubbleSort_WhenAlreadySortedArray_ReturnsNoErrors()
        {
            // Arrange
            int[] unsortedInput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };

            // Act
            BubbleSort.Sort(unsortedInput);

            // Assert
            int[] sortedOutput = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            Assert.IsTrue(Enumerable.SequenceEqual(unsortedInput, sortedOutput));
        }

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
        [Test]
        public void BubbleSort_WhenFourNineSevenSixThreeNineOne_ReturnsWhenOneThreeFourSixSevenNineNine()
        {
            // Arrange
            int[] unsortedInput = { 4, 9, 7, 6, 3, 9, 1 };

            // Act
            BubbleSort.Sort(unsortedInput);

            // Assert
            int[] sortedOutput = { 1, 3, 4, 6, 7, 9, 9 };
            Assert.IsTrue(Enumerable.SequenceEqual(unsortedInput, sortedOutput));
        }

        [Test]
        public void BubbleSort_WhenArrayEmpty_ReturnsDoingNothing()
        {
            int[] emptyArray = { };
            BubbleSort.Sort(emptyArray);
            Assert.IsTrue(!emptyArray.Any());
        }

        [Test]
        public void BubbleSort_WhenArraySingleElement_ReturnsDoingNothing([Values(2, 9, 13, 22)] int input)
        {
            int[] singleElementArray = { input };
            BubbleSort.Sort(singleElementArray);
            Assert.IsTrue(singleElementArray.Length == 1 && singleElementArray[0] == input);
        }

    }
}
