using Tyuiu.GurzanVM.Sprint6.Task1.V3.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task1.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        DataService ds = new DataService();
        [TestMethod]
        public void TestMethod1()
        {
            int startValue = -5;
            int endValue = 5;
            double[] ResArray = ds.GetMassFunction(startValue, endValue);
            double[] wait = new double[11] { 19.81, 16.79, 13.87, 10.98, 7.94, 3, 3.23, -0.45, -3.79, -6.97, -10.0 };
            CollectionAssert.AreEqual(ResArray, wait);
        }
    }
}