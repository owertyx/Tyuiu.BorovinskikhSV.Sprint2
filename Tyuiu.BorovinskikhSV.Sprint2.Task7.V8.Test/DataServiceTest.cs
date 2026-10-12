using Tyuiu.BorovinskikhSV.Sprint2.Task7.V8.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task7.V8.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsTrue(ds.CheckDotInShadedArea(3, 1));
            Assert.IsTrue(ds.CheckDotInShadedArea(2, 4));    
            Assert.IsTrue(ds.CheckDotInShadedArea(4, 0));    
        }

        [TestMethod]
        public void InvalidCheckDotInShadedArea()
        {
            DataService ds = new DataService();

            Assert.IsFalse(ds.CheckDotInShadedArea(1, 2));   
            Assert.IsFalse(ds.CheckDotInShadedArea(-2, 1));  
            Assert.IsFalse(ds.CheckDotInShadedArea(5, 5));   
            Assert.IsFalse(ds.CheckDotInShadedArea(3, -1));  
        }
    }
}
