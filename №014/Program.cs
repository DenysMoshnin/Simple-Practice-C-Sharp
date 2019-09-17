using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _014
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Напишите метод MinMax(X, Y), записывающий в переменную X минимальное из значений X и Y,
             а в переменную Y – максимальное из этих значений (X и Y – вещественные параметры, являющиеся одновременно входными и выходными).
             */
            Console.WriteLine("Введите значение X: ");
            int X = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение Y: ");
            int Y = int.Parse(Console.ReadLine());
            MinMax(ref X, ref Y);
            Console.WriteLine("\nX = " + X + "\nY= " + Y);

        }

        static void MinMax(ref int X, ref int Y)
        {

            if (X > Y)
            {
                //если X больше то создаем временную переменную, где сохраняем значение Y
                int Min = Y;
                Y = X;
                X = Min;
            }
            else { }
        }
    }
}
