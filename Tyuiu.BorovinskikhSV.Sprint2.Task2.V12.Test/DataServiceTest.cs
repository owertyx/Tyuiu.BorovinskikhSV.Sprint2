using Tyuiu.BorovinskikhSV.Sprint2.Task2.V12.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task2.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(4, 4));
            Assert.IsTrue(ds.CheckDotInShadedArea(10, 3));
            Assert.IsTrue(ds.CheckDotInShadedArea(13, 7));
            Assert.IsTrue(ds.CheckDotInShadedArea(7, 12));
            Assert.IsTrue(ds.CheckDotInShadedArea(12, 12));
        }

        [TestMethod]
        public void InvalidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 1));
            Assert.IsFalse(ds.CheckDotInShadedArea(7, 4));
            Assert.IsFalse(ds.CheckDotInShadedArea(13, 5));
            Assert.IsFalse(ds.CheckDotInShadedArea(9, 9));
            Assert.IsFalse(ds.CheckDotInShadedArea(4, 9));
        }
    }
}
