using Tyuiu.BorovinskikhSV.Sprint2.Task1.V14.Lib;
namespace Tyuiu.BorovinskikhSV.Sprint2.Task1.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetLogicOperations()
        {
            DataService ds = new DataService();

            bool[] res = ds.GetLogicOperations(185, 216, 174, 917);
            bool[] wait = { false, true, true, true, true, false };

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
