using NUnit.Framework;
using TDD_Sorts.Utility;

namespace TDD_SortsTests
{
    [TestFixture]
    public class MakeIntArrayTests
    {
        [Test]
        [TestCase("1, 2, 3, 4, 5", new int[] { 1, 2, 3, 4, 5 })]
        [TestCase("1, 3, 4, 5, 2", new int[] { 1, 3, 4, 5, 2 })]
        [TestCase("1, 3, 4, 5, 2,", new int[] { 1, 3, 4, 5, 2 })]
        [TestCase("", null)]
        [TestCase("1", new int[] { 1 })]
        [TestCase(" ", null)]
        [TestCase(null, null)]
        public void MakeIntArray_WhereBasicExpression_ReturnsCorrectAnswer(string inputString, int[] outputArray)
        {
            // Act
            int[] createdIntArray = SortManager.MakeIntArray(inputString);

            // Assert
            Assert.AreEqual(outputArray, createdIntArray);
        }
    }
}
