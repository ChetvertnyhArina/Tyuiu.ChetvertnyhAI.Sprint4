using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.ChetvertnyhAI.Sprint4.Task3.V10.Lib
{
    public class DataService : ISprint4Task3V10
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;
            int colums = array.Length / rows;
            int res = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colums; j++)
                {
                    if (i == 2)
                    {
                        res = Math.Max(res, array[i, j]);
                    }
                }
            }
            return res;
        }
    }
}
