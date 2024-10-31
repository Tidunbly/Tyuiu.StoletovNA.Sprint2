using Tyuiu.StoletovNA.Sprint2.Task7.V13.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task7.V13.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 0.1;
            double y = 0.2;

            Assert.IsTrue(ds.CheckDotInShadedArea(x, y));
        }
    }
}