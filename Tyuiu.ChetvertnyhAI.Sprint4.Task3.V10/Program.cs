using Tyuiu.ChetvertnyhAI.Sprint4.Task3.V10.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Двумерные массивы. (статический ввод)                             *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #10                                                             *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
        Console.WriteLine("* статическими значениями в диапазоне от 4 до 8. Найдите максимальный     *");
        Console.WriteLine("* элемент в третьей строке массива.                                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[,] mtrx = new int[5, 5] { { 5, 7, 6, 6, 5 },
                                          { 5, 5, 5, 4, 6 },
                                          { 8, 5, 7, 4, 7 },
                                          { 7, 6, 7, 4, 7 },
                                          { 5, 8, 7, 8, 8 } };
        int rows = mtrx.GetUpperBound(0) + 1;
        int colums = mtrx.Length / rows;

        DataService ds = new DataService();

        Console.WriteLine("Массив: ");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < colums; j++)
            {
                Console.Write($"{mtrx[i, j]} \t");
            }
            Console.WriteLine();
        }
        
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(mtrx);
        Console.WriteLine("Максимальный элемент в третьей строке массива = " + res);
        Console.ReadKey();

    }
}