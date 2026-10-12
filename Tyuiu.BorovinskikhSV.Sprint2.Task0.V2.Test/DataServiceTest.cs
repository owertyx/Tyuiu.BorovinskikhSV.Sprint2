using Tyuiu.BorovinskikhSV.Sprint2.Task0.V2.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task0.V2.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCompareOperations()
        {
            DataService ds = new DataService();

            bool[] res = ds.GetCompareOperations(123, 123);
            bool[] wait = { false, true, false, true, false, true };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
