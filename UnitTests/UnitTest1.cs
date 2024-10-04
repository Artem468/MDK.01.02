using TestingLab2;

namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestPositive()
        {
            Assert.AreEqual(Convertor.NumberConvertor(10, 7), 13);
            Assert.AreEqual(Convertor.NumberConvertor(51, 3), 1220);
            Assert.AreEqual(Convertor.NumberConvertor(623, 5), 4443);
            Assert.AreEqual(Convertor.NumberConvertor(99, 6), 243);
            Assert.AreEqual(Convertor.NumberConvertor(46, 8), 56);
        }
        [TestMethod]
        public void TestNegative()
        {
            Assert.AreEqual(Convertor.NumberConvertor(10, 1), 0);
            Assert.AreEqual(Convertor.NumberConvertor(12, 110), 0);
            Assert.AreEqual(Convertor.NumberConvertor(-2, 3), 0);
        }
    }
}