using Tyuiu.SaigafarovBI.Sprint1.Task1.V7.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 1.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(2.5, res);
        }
    }
}