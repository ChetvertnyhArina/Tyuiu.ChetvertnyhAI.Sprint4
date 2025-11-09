using Tyuiu.ChetvertnyhAI.Sprint4.Task3.V10.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task3.V10.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                          { 5, 5, 5, 4, 6 },
                                          { 8, 5, 7, 4, 7 },
                                          { 7, 6, 7, 4, 7 },
                                          { 5, 8, 7, 8, 8 } };
            int res = ds.Calculate(mas2);
            int wait = 8;
            Assert.AreEqual(wait, res);
        
        }
    }
}
