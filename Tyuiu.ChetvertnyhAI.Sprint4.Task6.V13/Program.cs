using Tyuiu.ChetvertnyhAI.Sprint4.Task6.V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        Console.Title = "Спринт #4 | Выполнила: Четвертных А. И. | ИСТНб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Тема: Класс Array                                                       *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #13                                                             *");
        Console.WriteLine("* Выполнила: Четвертных Арина Игоревна | ИСТНб-25-1                       *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных ['Ford', 'Toyota', 'Honda', 'Chevrolet',    *");
        Console.WriteLine("* 'Mercedes', 'BMW', 'Audi'] используя класс Array подсчитайте количество *");
        Console.WriteLine("* элементов, длина которых больше 4.                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        
        DataService ds = new DataService();
        var a = new string[] { "Ford", "Toyota", "Honda", "Chevrolet", "Mercedes", "BMW", "Audi" };

      
        Console.WriteLine("Исходный массив:");
        for (int i = 0; i < a.Length; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.Calculate(a);
        Console.WriteLine("Количество элементов, длина которых больше 4:");
        Console.WriteLine(res);
        Console.ReadKey();
    }
}