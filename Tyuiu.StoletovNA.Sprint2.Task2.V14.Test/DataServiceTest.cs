using Tyuiu.StoletovNA.Sprint2.Task2.V14.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task2.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 5;
            int y = 3;
            bool res = ds.CheckDotInShadedArea(x, y);
            
            Assert.IsTrue(res);
        }
    }
}