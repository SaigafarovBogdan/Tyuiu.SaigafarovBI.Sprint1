using Tyuiu.SaigafarovBI.Sprint1.Task7.V22.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task7.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 5;
            Assert.AreEqual(10, ds.Calculate(x, y));
        }
    }
}