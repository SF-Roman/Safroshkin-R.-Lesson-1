using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Три переменных
            int a = 1;
            int b = 2;
            int res;

            res = a;
            a = b;
            b = res;


            // Две переменных
            int c = 3;
            int d = 4;

            c = -c - d;
            d = -c - d;
            c = -c - d;


            Console.ReadLine();

        }
    }
}
