using Tyuiu.SaigafarovBI.Sprint1.Task4.V22.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task4.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 10.0;
            double y = 10.0;
            Assert.AreEqual(0.011, ds.Calculate(x, y));
        }
    }
}