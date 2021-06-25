using NUnit.Framework;

namespace TDD_SortsTests
{
    [TestFixture]
    public class IntArrayToStringTests
    {
        [Test]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, "1, 2, 3, 4, 5")]
        public void IntArrayToString_WhereDefault_ReturnsStringifiedIntArray()
        {

        }
    }
}
