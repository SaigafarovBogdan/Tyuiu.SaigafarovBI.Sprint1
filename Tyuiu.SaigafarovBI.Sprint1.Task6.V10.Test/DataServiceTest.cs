using Tyuiu.SaigafarovBI.Sprint1.Task6.V10.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task6.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();
            Assert.AreEqual("fghg ft ", ds.DeleteMiddleLetter("fghg fot g"));
        }
    }
}