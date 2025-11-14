using Tyuiu.ChetvertnyhAI.Sprint4.Task7.V22.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task7.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            int n = 5;
            int m = 3;
            int[,] mtrx = new int[n, m];
            string str = "695324951753684";
            DataService ds = new DataService();
            int res = ds.Calculate(n, m, str);
            int wait = 9216;
            Assert.AreEqual(wait, res);
        }
    }
}
