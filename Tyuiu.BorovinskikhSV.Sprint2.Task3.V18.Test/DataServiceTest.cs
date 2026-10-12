using Tyuiu.BorovinskikhSV.Sprint2.Task3.V18.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task3.V18.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculateXMoreThanOne()
        {
            DataService ds = new DataService();
            Assert.AreEqual(36, ds.Calculate(2));       
        }

        [TestMethod]
        public void ValidCalculateXZero()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.75, ds.Calculate(0));     
        }

        [TestMethod]
        public void ValidCalculateXInRange()
        {
            DataService ds = new DataService();
            Assert.AreEqual(0.5, ds.Calculate(-1));     
        }

        [TestMethod]
        public void ValidCalculateXLessThanMinus22()
        {
            DataService ds = new DataService();
            Assert.AreEqual(-252.957, ds.Calculate(-23)); 
        }
    }
}
