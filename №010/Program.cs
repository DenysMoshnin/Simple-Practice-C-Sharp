using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010
{
    class Program
    {
        static void Main(string[] args)
        {
            //Напишите метод, который запрашивает ввести два числа и потом возвращает сумму этих чисел.

            Console.WriteLine("Введите x: ");
            int x = int.Parse(Console.ReadLine()); // инициализируем x
            Console.WriteLine("Введите y: ");
            int y = int.Parse(Console.ReadLine()); // инициализируем y
            TheSum(ref x, y);
            Console.WriteLine("x + y = " + x);
        }
        static void TheSum(ref int a, int b)
        {
            a += b;
        }
    }
}
