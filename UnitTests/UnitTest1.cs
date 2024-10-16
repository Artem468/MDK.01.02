using TestingLab2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositive()
        {
            CollectionAssert.AreEqual(
                Convertor.FromArrayToMatrix(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 3),
                new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } }
            );
            CollectionAssert.AreEqual(
                Convertor.FromArrayToMatrix(new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 }),
                new int[4, 4] { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 13, 14, 15, 16 } }
            );
            CollectionAssert.AreEqual(
                Convertor.FromArrayToMatrix(new[] { 5, 6, 7, 8, 9, 10, 11, 12 }),
                new int[4, 4] { { 5, 6, 7, 8 }, { 9, 10, 11, 12 }, { 0, 0, 0, 0 }, { 0, 0, 0, 0 } }
            );
        }

        [TestMethod]
        public void TestNegative()
        {
            CollectionAssert.AreEqual(
                Convertor.FromArrayToMatrix(new[] { 5, 6, 7, 8, 9, 10, 11, 12 }, 0),
                null
            );
            CollectionAssert.AreEqual(
                Convertor.FromArrayToMatrix(new[] { 5, 6, 7, 8, 9, 10, 11, 12 }, -2),
                null
            );
        }
    }
}