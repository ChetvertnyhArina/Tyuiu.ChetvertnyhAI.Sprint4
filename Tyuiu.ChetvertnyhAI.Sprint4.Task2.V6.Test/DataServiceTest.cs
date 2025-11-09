using Tyuiu.ChetvertnyhAI.Sprint4.Task2.V6.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task2.V6.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.Calculate(numsArray);
            int wait = 243;
            Assert.AreEqual(wait, res);
        }
    }
}
