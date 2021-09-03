using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{

    #region Задача 6
    public class Kunshtyaki
    {
        public void PosPrint(string str, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(str);
        }
        public void Pause()
        {
            Console.ReadLine();
        }

    }
    #endregion


    #region Задача 5
    class Program
    {



        static void Main(string[] args)
        {
            Console.WriteLine("Введите ваше имя");
            string Fname = Console.ReadLine();

            Console.WriteLine("Введите вашу фамилию");
            string Sname = Console.ReadLine();

            Console.WriteLine("Введите ваш город");
            string city = Console.ReadLine();


            string str = ($"Добрый день, {Sname} {Fname} из г . {city}");


            Kunshtyaki mes = new Kunshtyaki();

            mes.PosPrint(str, 45, 15);
            mes.Pause();

            //Print(str, 40, 15);
            //Pause();

        }
    }
    #endregion
}
