using Tyuiu.GurzanVM.Sprint6.Task0.V24.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task0.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = 1024;
            Assert.AreEqual(wait, res);
        }
    }
}