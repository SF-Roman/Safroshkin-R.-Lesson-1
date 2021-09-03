using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Task2
{
    class Program
    {
        #region Задача 2
        static float MassIndex(float m, float h)
        {
            float Mi = m / (h * h);
            return Mi;
        }
        #endregion


        #region Задача 1
        static void Main(string[] args)
        {

            //Запрашиваем данные для анкеты
            Console.WriteLine("Добрый день! Заполните анкету:");

            Console.WriteLine("Введите ваше имя");
            string Fname = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string Sname = Console.ReadLine();

            Console.WriteLine("Введите ваш возраст");
            string age = Console.ReadLine();

            Console.WriteLine("Введите ваш рост в метрах (прим. 1,75)");
            string height = Console.ReadLine();

            Console.WriteLine("Введите ваш вес");
            string weight = Console.ReadLine();

            //Приводим строковые переменные к числовым для дальнейшего использования в высчитывании индекса массы тела
            int N_age = int.Parse(age);
            float N_height = float.Parse(height);
            float N_weight = float.Parse(weight);

            //Выводим тремя способами

            //Console.WriteLine("Здравствуйте, " + Fname + " " + Sname + ", ваш возраст " + N_age + ", ваш рост " + N_height + ",ваш вес " + N_weight + ".");
            //Console.WriteLine("Здравствуйте, {0} {1}, ваш возраст {2}, ваш рост {3} , ваш вес {4}.", Fname, Sname, N_age, N_height, N_weight);
            Console.WriteLine($"Здравствуйте, {Fname} {Sname}, ваш возраст {N_age}, ваш рост {N_height} , ваш вес {N_weight}.");
            Console.ForegroundColor = ConsoleColor.Green;
            float resInd = MassIndex(N_weight, N_height);
            Console.WriteLine($"Индекс массы вашего тела: {resInd}");


            Console.ReadLine();

            #endregion
        }
    }
}
