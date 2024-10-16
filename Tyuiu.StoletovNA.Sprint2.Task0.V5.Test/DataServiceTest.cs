using Tyuiu.StoletovNA.Sprint2.Task0.V5.Lib;
namespace Tyuiu.StoletovNA.Sprint2.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest {

        [TestMethod]
        public void TestMethod1()
        
        {
            DataService ds = new DataService();
            int x = 105;
            int y = 223;

            bool[] rs = new bool[6];
            rs = ds.GetCompareOperations(x, y);
            bool[] rs2 = new bool[6] {false, true, true, true, false, true };
            CollectionAssert.AreEqual(rs2, rs);
            
        }
    }
}