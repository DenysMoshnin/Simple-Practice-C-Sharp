using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Задание №3. Условные конструкции.
             * Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию (A<B<C) или убыванию (A>B>C), то удвойте их.
             * В противном случае замените значение каждой переменной на противоположное (поменять знак числа). Выведите новые значения переменных A, B, C на консоль.*/

            //Инициализация переменных
            Console.WriteLine("Введите число А: ");
            double A = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число В: ");
            double B = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите число С: ");
            double C = double.Parse(Console.ReadLine());
            //Задаем условия сравнений
            bool increase = (A < B) && (B < C);
            bool decrease = (A > B) && (B > C);
            bool res = decrease || increase;
            //Вывод в консоль согласно условий
            if (res == true)
            {
                A = A * 2;
                B = B * 2;
                C = C * 2;
                if (decrease == true)
                {
                    Console.WriteLine("Так как значения упорядочнены по убыванию, производим удвовоение значений." + "\nA = " + A + "\nB = " + B + "\nC = " + C);
                }
                else
                {
                    Console.WriteLine("Так как значения упорядочнены по возрастанию, производим удвовоение значений." + "\nA = " + A + "\nB = " + B + "\nC = " + C);
                }
            }
            else
            {
                A = (-1) * A;
                B = (-1) * B;
                C = (-1) * C;
                Console.WriteLine("Так как значения не упорядочнены ни по возрастанию, ни по убыванию, производим смену знака." + "\nA = " + A + "\nB = " + B + "\nC = " + C);
            }
        }
    }
}
