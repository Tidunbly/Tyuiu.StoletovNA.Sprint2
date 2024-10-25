using Tyuiu.StoletovNA.Sprint2.Task4.V8.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task4.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = -1.5;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 6.0;
            double y = -4.0;
            var res = 15712.007;
            Assert.AreEqual(res, ds.Calculate(x, y));
        }
    }
}