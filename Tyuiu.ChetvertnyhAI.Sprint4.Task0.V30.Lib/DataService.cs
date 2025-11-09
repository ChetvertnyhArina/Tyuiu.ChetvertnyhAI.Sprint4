using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task0.V30.Lib
{
    public class DataService : ISprint4Task0V30
    {
        public int GetSumEvenArrEl(int[] array)
        {
            int count = 0;
            for (int i = 0; i <= array.Length - 1; i++)
            {
                if (array[i] % 2 == 0)
                {
                    count += array[i];
                }
            }
            return count;
        }
    }
}
