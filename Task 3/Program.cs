using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static double len(double x1, double x2, double y1, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
        static void Main(string[] args)
        {
            //Запрашиваем переменные
            Console.WriteLine("Введите x1: ");
            string x1 = Console.ReadLine();
            Console.WriteLine("Введите x1: ");
            string x2 = Console.ReadLine();
            Console.WriteLine("Введите x1: ");
            string y1 = Console.ReadLine();
            Console.WriteLine("Введите x1: ");
            string y2 = Console.ReadLine();

            //Приводим строки в числа
            double x11 = double.Parse(x1);
            double x22 = double.Parse(x2);
            double y11 = double.Parse(y1);
            double y22 = double.Parse(y2);

            //Вызываем метод
            double res = len(x11, x22, y11, y22);
            //Форматируем до 2х знаков после запятой
            string result = String.Format("{0:f2}", res);
            //Выводим результат
            Console.WriteLine(result);


            //Заглушка
            Console.ReadLine();
        }
    }
}
