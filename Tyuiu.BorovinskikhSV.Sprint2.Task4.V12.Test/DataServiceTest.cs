using Tyuiu.BorovinskikhSV.Sprint2.Task4.V12.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task4.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateCondTrue()
        {
            DataService ds = new DataService();

            Assert.AreEqual(387420489, ds.Calculate(9, 1));
        }

        [TestMethod]
        public void ValidCalculateCondFalse()
        {
            DataService ds = new DataService();

            Assert.AreEqual(0.747, ds.Calculate(0, 1));
        }
    }
}
