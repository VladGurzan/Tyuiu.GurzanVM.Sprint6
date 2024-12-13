using Tyuiu.GurzanVM.Sprint6.Task6.V29.Lib;

namespace Tyuiu.GurzanVM.Sprint6.Task6.V29.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds  = new DataService();

            string path = Path.Combine(new string[] { "C:", "DataSprint6", "InPutDataFileTask6V28.txt" });
            var res = ds.CollectTextFromFile(path);
            string wait = "gMxrJi rvzAEwiXzIsLRa xakZKciG";
            Assert.AreEqual(wait, res);
        }
    }
}