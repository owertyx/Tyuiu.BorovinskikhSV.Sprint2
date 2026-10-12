using Tyuiu.BorovinskikhSV.Sprint2.Task5.V1.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task5.V1.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual(31, ds.FindMonthDaysCount(1));
            Assert.AreEqual(28, ds.FindMonthDaysCount(2));
            Assert.AreEqual(30, ds.FindMonthDaysCount(4));
            Assert.AreEqual(31, ds.FindMonthDaysCount(12));
        }

        [TestMethod]
        public void InvalidFindMonthDaysCount()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0, ds.FindMonthDaysCount(0));
            Assert.AreEqual(0, ds.FindMonthDaysCount(13));
        }
    }
}
