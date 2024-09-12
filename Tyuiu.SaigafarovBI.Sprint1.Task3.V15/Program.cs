using Tyuiu.SaigafarovBI.Sprint1.Task3.V15.Lib;
namespace Tyuiu.SaigafarovBI.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Сайгафаров Б. И. | ПКТб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Сайгафаров Богдан Ирекович | ПКТб-24-1                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine("Введите V1");
            int v1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите V2");
            int v2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите S");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите T");
            int T = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            
            Console.WriteLine(ds.DistanceOverTime(v1,v2,S,T));
            Console.ReadKey();
        }
    }
}
