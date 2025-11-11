using Tyuiu.ChetvertnyhAI.Sprint4.Task6.V13.Lib;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task6.V13.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var a = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };
            int res = ds.Calculate(a);
            int wait = 4;
            Assert.AreEqual(wait, res);
        }
    }
}
