using Tyuiu.ChetvertnyhAI.Sprint4.Task4.V29.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task4.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 5, 6, 5, 6, 5 },
                                          { 5, 5, 5, 8, 4 },
                                          { 8, 5, 5, 8, 8 },
                                          { 6, 5, 4, 4, 8 },
                                          { 8, 5, 6, 8, 8 } };
            int res = ds.Calculate(mas2);
            int wait = 100;
            Assert.AreEqual(wait, res);
        }
    }
}
