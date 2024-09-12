using Tyuiu.SaigafarovBI.Sprint1.Task5.V2.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task5.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            Assert.AreEqual(149, ds.FahrenheitTo—elsius(300.0));
        }
    }
}