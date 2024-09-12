using System.Numerics;
using Tyuiu.SaigafarovBI.Sprint1.Task3.V15.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task3.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int v1 = 5;
            int v2 = 10;
            int S = 10;
            int T = 5;
            Assert.AreEqual(85, ds.DistanceOverTime(v1, v2, S, T));
        }
    }
}