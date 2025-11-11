using Tyuiu.ChetvertnyhAI.Sprint4.Task5.V5.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task5.V5.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { -5, 1, 5, 3, -4 },
                                          { 6, 7, 3, 8, 4 },
                                          { 2, -5, -4, -2, 4 },
                                          { 6, -5, 4, -3, 3 },
                                          { 2, -5, 6, 8, 1 } };
            int res = ds.Calculate(mas2);
            int wait = 73;
            Assert.AreEqual(wait, res);
        }
    }
}
