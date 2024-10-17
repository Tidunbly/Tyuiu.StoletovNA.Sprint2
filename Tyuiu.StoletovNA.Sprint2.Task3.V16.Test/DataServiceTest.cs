using Tyuiu.StoletovNA.Sprint2.Task3.V16.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task3.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 2;
            double res = ds.Calculate(x);
            Assert.AreEqual(29, res);

        }
        [TestMethod]
        public void TestMethod2()
        {
            DataService ds = new DataService();
            double x = 0;
            double res = ds.Calculate(x);
            Assert.AreEqual(0.75, res);

        }
        [TestMethod]
        public void TestMethod3()
        {
            DataService ds = new DataService();
            double x = 1;
            double res = ds.Calculate(x);
            Assert.AreEqual(128, res);

        }
        [TestMethod]
        public void TestMethod4()
        {
            DataService ds = new DataService();
            double x = -21;
            double res = ds.Calculate(x);
            Assert.AreEqual(-230.952, res);

        }
    }
}