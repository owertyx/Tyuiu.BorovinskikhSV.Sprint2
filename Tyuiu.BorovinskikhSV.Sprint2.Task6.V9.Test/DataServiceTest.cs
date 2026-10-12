using Tyuiu.BorovinskikhSV.Sprint2.Task6.V9.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task6.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidFindDateOfNextDay()
        {
            DataService ds = new DataService();

            Assert.AreEqual("16.05", ds.FindDateOfNextDay(5, 15));   
            Assert.AreEqual("01.02", ds.FindDateOfNextDay(1, 31));   
            Assert.AreEqual("01.03", ds.FindDateOfNextDay(2, 28));   
            Assert.AreEqual("01.05", ds.FindDateOfNextDay(4, 30));   
            Assert.AreEqual("31.12", ds.FindDateOfNextDay(12, 30));  
        }
    }
}
